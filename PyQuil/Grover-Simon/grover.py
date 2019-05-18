"""
The main program that performs the Grover experiment
"""

from pyquil import Program
from pyquil.gates import *
from pyquil import get_qc
from pyquil.api import local_qvm
import time
import numpy as np
from pyquil.api import WavefunctionSimulator


class Grover:

    def __init__(self, n, qubits=None):
        """
        Initialize the class with a particular n
        :param n: the number of bits to use in the circuit
        :param map: map of qubits for the QPC
        """
        self.p = Program()
        self.ro = self.p.declare('ro', 'BIT', n)
        self.n = n
        # build a map of the aspen bits:
        self.map = qubits

    def build_circuit(self, k):
        """
        Return a Program that consists of the entire Grover experiment
        :param k: the specific value for which f(x) returns 1
        :return:
        """
        self.initialize_experiment()
        self.all_hadamards()
        self.insert_Gs(k)
        self.measure_ro()
        return self.p

    def from_map(self, i):
        """
        Returns a mapping to the qubits if one exists - otherwise just return identity
        :param i: the qubit index of the map you want to map to
        :return: the new qubit
        """
        if self.map is None:
            return i
        else:
            return self.map[i]

    def initialize_experiment(self):
        """
        Initialize all qubits to 0
        :return: program state after this operation
        """
        # already reset ... just do nothing
        # self.p += Program(RESET(self.from_map(i)) for i in range(self.n))
        return self.p

    def all_hadamards(self):
        """
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in the circuit)
        :return: program state after this operation
        """
        self.p += Program([H(self.from_map(i)) for i in range(self.n)])
        return self.p

    def insert_Gs(self, k):
        """
        Add the required number of G chunks that are required by the system
        :return: program state after this operation
        """
        total_gs = int(np.round(self.num_tries(self.n)))
        assert total_gs > 0
        for _ in range(total_gs):
            self.G(k)

        return self.p

    def G(self, k):
        """
        Adds a single G circuit chunk to the program
        :param k: the specific value for which f(x) returns 1
        :return: program state after this operation
        """

        # add z_f
        self.z_f(k)
        
        # add more Hadamards
        self.all_hadamards()
        
        # add z_f (z_f when k = 0)
        self.z_f(0)

        # add more Hadamrds
        self.all_hadamards()

        # negate everything by adding a Z to the first qubit
        self.p += Program(Z(self.from_map(0)))

        return self.p

    def z_f(self, k):
        """
        Adds a single z_f circuit chunk to the program
        :param k: the specific value for which f(x) returns 1
        :return: program state after this operation
        """

        # add a X for every bit in k that is 0
        k_bits = self.int_to_bits(k, self.n)
        self.p += Program([X(self.from_map(k_b)) for k_b in range(len(k_bits)) if k_bits[k_b] == 0])

        # add a controlled Z to the first (arbitrary) qubit. All other qubits will be controls
        Z_gate = Z(self.from_map(0))
        for i in range(self.n-1):
            Z_gate.controlled(self.from_map(i+1))
        self.p += Program(Z_gate)

        # add a X for every bit in k that is 0 (again)
        self.p += Program([X(self.from_map(k_b)) for k_b in range(len(k_bits)) if k_bits[k_b] == 0])

        return self.p

    def measure_ro(self):
        """
        Measure every qubit but the last one
        :return: program state after this operation
        """
        self.p += Program([MEASURE(self.from_map(i), self.ro[i]) for i in range(self.n)])
        return self.p

    @staticmethod
    def num_tries(n):
        return np.pi / (4 * np.arcsin(1 / np.sqrt(n))) - 0.5

    @staticmethod
    def int_to_bits(i, n):
        """
        Helper function for converting int to a bitstring representation
        :param i: int to convert
        :param n: number of bits to convert i into
        :return: the converted bitstring as an array
        """
        y = [int(digit) for digit in bin(i)[2:]]
        while len(y) < n:
            y = [0] + y
        return y


def run_grover(n, k, numshots=5, sim_wave=False, print_p=False, use_aspen=True):
    """
    Run a single experiment of Grover
    :param n: the number of bits to use in the circuit
    :param k: the specific value for which f(x) returns 1
    :param numshots: number of times to run simulation (if enabled)
    :param sim_wave: generate waveform (if True) or run simulation (if False)
    :param print_p: print the circuit prior to running
    :param use_aspen: whether to compile using the Aspen QPC when available (3 <= n <= 5)
    :return:
    """

    # setup the experiment
    qvm = get_qc('Aspen-4-{}Q-A-qvm'.format(n) if use_aspen else '9q-square-qvm')
    gr = Grover(n, qubits=(qvm.qubits() if use_aspen else None))
    p = gr.build_circuit(k)
    if print_p:
        print(p)

    with local_qvm():
        if sim_wave:
            # debug waveform
            wf_sim = WavefunctionSimulator()
            wavefunction = wf_sim.wavefunction(p)

            # The amplitudes are stored as a numpy array on the Wavefunction object
            print(wavefunction.amplitudes)
            prob_dict = wavefunction.get_outcome_probs()  # extracts the probabilities of outcomes as a dict
            print(prob_dict)
        else:
            # multiple trials - check to make sure that the probability for getting the given outcome is 1
            p.wrap_in_numshots_loop(numshots)

            # actually perform the measurement
            t = time.time()
            executable = qvm.compile(p)
            result = qvm.run(executable)
            return_time = time.time() - t

            # count the different occurences and pick the largest one
            counts = {}
            for i in (result):
                found = False
                for key in counts.keys():
                    if str(i) == key:
                        found = True
                        break
                if not found:
                    counts[str(i)] = 1
                else:
                    counts[str(i)] += 1
            print(counts)

            most_probable = None
            for key in counts.keys():
                if most_probable is None or counts[key] > counts[most_probable]:
                    most_probable = key

            print('Most probable result: k={}'.format(most_probable))
            print()

            return result, return_time


def main():
    n = 4   # the number of bits in f: {0,1}^n → {0,1}
    k = 2   # f(x = k) = 1, f(x != k) = 0

    # run the experiment with specific n and k
    run_grover(n, k, numshots=5*n, sim_wave=False, use_aspen=True)


if __name__ == '__main__':
    main()
