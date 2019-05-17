"""
The main program that performs the Bernstein-Vazirani experiment
"""

from pyquil import Program
from pyquil.gates import *
from pyquil import get_qc
from pyquil.api import local_qvm
import time
import numpy as np


class Grover():

    def __init__(self, n):
        """
        Initialize the class with a particular n
        :param n: the number of bits to use in the circuit
        """
        self.p = Program()
        self.ro = self.p.declare('ro', 'BIT', n)
        self.n = n

    def build_circuit(self, k):
        """
        Return a Program that consists of the entire Grover experiment
        :param k: the specific value for which f(x) returns 1
        :return:
        """
        self.initialize_experiment()
        self.left_hadamards()
        self.insert_Gs(k)
        self.measure_ro()
        return self.p

    def initialize_experiment(self):
        """
        Initialize all qubits to 0
        :return: program state after this operation
        """
        self.p += Program(RESET(i) for i in range(self.n))
        return self.p

    def left_hadamards(self):
        """
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in the circuit)
        :return: program state after this operation
        """
        self.p += Program([H(i) for i in range(self.n)])
        return self.p

    def insert_Gs(self, k):
        """
        Add the required number of G chunks that are required by the system
        :return: program state after this operation
        """
        total_gs = int(np.floor(self.num_tries(self.n)))
        for _ in range(total_gs):
            self.p += self.G(k)
        return self.p

    def G(self, k):
        """
        Adds a single G circuit chunk to the program
        :param k: the specific value for which f(x) returns 1
        :return: program state after this operation
        """

        # add z_f
        self.p += self.z_f(k)

        return self.p

    def z_f(self, k):
        """
        Adds a single z_f circuit chunk to the program
        :param k: the specific value for which f(x) returns 1
        :return: program state after this operation
        """

        # add a X for every bit in k that is 0
        k_bits = self.int_to_bits(k, self.n)
        self.p += Program([X(k_b) for k_b in range(len(k_bits)) if k_bits[k_b] == 0])

        # add a controlled Z to the first (arbitrary) qubit. All other qubits will be controls
        Z_gate = Z(0)
        for i in range(self.n-1):
            Z_gate.controlled(i+1)
        self.p += Program(Z_gate)

        # add a X for every bit in k that is 0 (again)

        print(self.p)
        exit(0)

        return self.p

    def measure_ro(self):
        """
        Measure every qubit but the last one
        :return: program state after this operation
        """
        self.p += Program([MEASURE(i, self.ro[i]) for i in range(self.n)])
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


def run_grover(n, k):
    # setup the experiment
    gr = Grover(n)
    p = gr.build_circuit(k)

    # actually perform the measurement
    qvm = get_qc('9q-square-qvm')
    with local_qvm():
        # one way of measuring:
        t = time.time()
        executable = qvm.compile(p)
        result = qvm.run(executable)
        return_time = time.time() - t

        print('Result:', result)
        print()

    return result, return_time

def main():
    n = 5   # the number of bits in f: {0,1}^n → {0,1}
    k = 5   # f(k) = 1, f(!k) = 0

    # run the experiment with specific n and k
    run_grover(n, k)


if __name__ == '__main__':
    main()
