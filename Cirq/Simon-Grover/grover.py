"""
The main program that performs the Grover experiment
"""

# from pyquil import Program
# from pyquil.gates import *
# from pyquil import get_qc
# from pyquil.api import local_qvm
# import time
# import numpy as np
# from pyquil.api import WavefunctionSimulator

import cirq
import time
import numpy as np


class Grover:

    def __init__(self, n):
        """
        Initialize the class with a particular n
        :param n: the number of bits to use in the circuit
        """
        self.n = n
        self.qubits = cirq.LineQubit.range(n)
        self.circuit = cirq.Circuit()

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
        return self.circuit

    def initialize_experiment(self):
        """
        Initialize all qubits to 0
        :return: program state after this operation
        """
        # already reset ... just do nothing
        # self.p += Program(RESET(self.from_map(i)) for i in range(self.n))
        return self.circuit

    def all_hadamards(self):
        """
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in the circuit)
        :return: program state after this operation
        """
        self.circuit.append([cirq.H(self.qubits[i]) for i in range(self.n)],
                            strategy=cirq.InsertStrategy.NEW_THEN_INLINE)
        return self.circuit

    def insert_Gs(self, k):
        """
        Add the required number of G chunks that are required by the system
        :return: program state after this operation
        """
        total_gs = int(np.round(self.num_tries(self.n)))
        print('adding {} G blocks...'.format(total_gs))
        assert total_gs > 0
        for _ in range(total_gs):
            self.G(k)

        return self.circuit

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
        
        # add z_0 (can be thought of as z_f when k = 0)
        self.z_f(0)

        # add more Hadamrds
        self.all_hadamards()

        # negate everything by adding a Z to the first qubit
        self.circuit.append(cirq.Z(self.qubits[0]))

        return self.circuit

    def z_f(self, k):
        """
        Adds a single z_f circuit chunk to the program
        :param k: the specific value for which f(x) returns 1
        :return: program state after this operation
        """

        # add a X for every bit in k that is 0
        k_bits = self.int_to_bits(k, self.n)
        self.circuit.append([cirq.X(self.qubits[k_b]) for k_b in range(len(k_bits)) if k_bits[k_b] == 0],
                            strategy=cirq.InsertStrategy.NEW_THEN_INLINE)
        # self.p += Program([X(self.from_map(k_b)) for k_b in range(len(k_bits)) if k_bits[k_b] == 0])

        # add a controlled Z to the first (arbitrary) qubit. All other qubits will be controls
        Z_gate = cirq.Z(self.qubits[0])
        for i in range(self.n-1):
            Z_gate = Z_gate.controlled_by(self.qubits[i+1])
            # Z_gate = cirq.ControlledGate(cirq.Z).on(self.qubits[0], self.qubits[i+1])
        self.circuit.append([Z_gate], strategy=cirq.InsertStrategy.NEW_THEN_INLINE)

        # add a X for every bit in k that is 0 (again)
        self.circuit.append([cirq.X(self.qubits[k_b]) for k_b in range(len(k_bits)) if k_bits[k_b] == 0],
                            strategy=cirq.InsertStrategy.NEW_THEN_INLINE)

        return self.circuit

    def measure_ro(self):
        """
        Measure every qubit but the last one
        :return: program state after this operation
        """
        self.circuit.append([cirq.measure(self.qubits[i]) for i in range(self.n)],
                            strategy=cirq.InsertStrategy.NEW_THEN_INLINE)
        return self.circuit

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


def run_grover(n, k, numshots=5, print_p=False):
    """
    Run a single experiment of Grover
    :param n: the number of bits to use in the circuit
    :param k: the specific value for which f(x) returns 1
    :param numshots: number of times to run simulation (if enabled)
    :param print_p: print the circuit prior to running
    :return:
    """

    # setup the experiment
    gv = Grover(n)
    circuit = gv.build_circuit(k)

    if print_p:
        print(circuit)
        return

    # start simulator
    simulator = cirq.Simulator()
    t = time.time()
    result = simulator.run(circuit, repetitions=numshots)
    return_time = time.time() - t
    print(result)

    return result, return_time


def main():
    n = 2   # the number of bits in f: {0,1}^n → {0,1}
    k = 2   # f(x = k) = 1, f(x != k) = 0
    # run the experiment with specific n and k
    run_grover(n, k, numshots=2**n)

    n = 3   # the number of bits in f: {0,1}^n → {0,1}
    k = 2   # f(x = k) = 1, f(x != k) = 0
    # run the experiment with specific n and k
    run_grover(n, k, numshots=2**n)

    n = 4   # the number of bits in f: {0,1}^n → {0,1}
    k = 2   # f(x = k) = 1, f(x != k) = 0
    # run the experiment with specific n and k
    run_grover(n, k, numshots=2**n)

    n = 5   # the number of bits in f: {0,1}^n → {0,1}
    k = 2   # f(x = k) = 1, f(x != k) = 0
    # run the experiment with specific n and k
    run_grover(n, k, numshots=2**n)

    n = 6   # the number of bits in f: {0,1}^n → {0,1}
    k = 2   # f(x = k) = 1, f(x != k) = 0
    # run the experiment with specific n and k
    run_grover(n, k, numshots=2**n)


if __name__ == '__main__':
    main()
