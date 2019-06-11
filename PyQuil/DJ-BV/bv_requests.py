"""
The main program that performs the Bernstein-Vazirani experiment
"""

from pyquil import Program
from pyquil.gates import *
from pyquil import get_qc
from pyquil.api import local_qvm
import time


class Bernstein_Vazirani():

    def __init__(self, n, map=None):
        """
        Initialize the class with a particular n
        :param n: the number of bits to use in the circuit
        """
        self.p = Program()
        self.ro = self.p.declare('ro', 'BIT', n)
        self.n = n
        # build a map of the aspen bits:
        self.map = map

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

    def build_circuit(self, a, b):
        """
        Return a Program that consists of the entire Bernstein-Vazirani experiment
        :param a: the a given in equation a*x + b
        :param b: the b given in equation a*x + b
        :return:
        """
        self.initialize_experiment()
        self.left_hadamards()
        self.insert_Uf(a, b)
        self.right_hadamards()
        self.measure_ro()
        return self.p

    def initialize_experiment(self):
        """
        Initialize the first qubits to 0 and the last (helper) qubit to 1
        :return: program state after this operation
        """
        self.p += Program([I(self.from_map(i)) for i in range(self.n)] + [X(self.from_map(self.n))])
        return self.p

    def left_hadamards(self):
        """
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in BV)
        :return: program state after this operation
        """
        self.p += Program([H(self.from_map(i)) for i in range(self.n + 1)])
        return self.p

    def insert_Uf(self, a=2, b=2):
        """
        Inserts a U_f following Bernstein-Vazirani U_f into a given Program and returns the Program
        :param a: given a
        :param b: given b
        :return p: program state after this operation
        """

        # if b is not even, then we need to flip the helper qubit (the last one)
        if b % 2 != 0:
            self.p += Program(X(self.from_map(self.n)))

        # first convert a into a bitstring for easy use
        a = self.int_to_bits(a, self.n)
        print('# Expected:', a)

        for i, _a in enumerate(a):
            # wherever _a is 1, we insert a CNOT into the system targeting the helper bit
            if _a == 1:
                self.p += Program(CNOT(self.from_map(i), self.from_map(self.n)))

        # return the program, which now has U_f inserted
        return self.p

    def right_hadamards(self):
        """
        Add a Hadamard gate to every qubit but the helper (corresponds to the right-hand-side hadamards in BV)
        :return: program state after this operation
        """
        self.p += Program([H(self.from_map(i)) for i in range(self.n)])
        return self.p

    def measure_ro(self):
        """
        Measure every qubit but the last one
        :return: program state after this operation
        """
        self.p += Program([MEASURE(self.from_map(i), self.ro[i]) for i in range(self.n)])
        return self.p

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


def run_BV(n, a, b, pr=False, map=None):
    # setup the experiment
    bv = Bernstein_Vazirani(n, map=map)
    p = bv.build_circuit(a, b)

    if pr:
        print(p)
        return None

    # actually perform the measurement
    qvm = get_qc('Aspen-4-12Q-A')
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
    n = 6  # the number of bits in f: {0,1}^n → {0,1}

    print('# --- Complex:')
    a = (2**n)-1  # the a in f(x) = a*x + b
    b = 0  # the b in f(x) = a*x + b
    run_BV(n, a, b, pr=True, map=[0, 1, 2, 6, 7, 10, 11, 13, 14, 15, 16, 17])

    print('# --- Simple:')
    a = 0  # the a in f(x) = a*x + b
    b = 1  # the b in f(x) = a*x + b
    run_BV(n, a, b, pr=True, map=[0, 1, 2, 6, 7, 10, 11, 13, 14, 15, 16, 17])


if __name__ == '__main__':
    main()
