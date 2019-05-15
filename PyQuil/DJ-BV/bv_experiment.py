"""
The main program that performs the Bernstein-Vazirani experiment
"""

from pyquil import Program
from pyquil.gates import *
from pyquil import get_qc
from pyquil.api import local_qvm


class Bernstein_Vazirani():

    def __init__(self, n):
        """
        Initialize the class with a particular n
        :param n: the number of bits to use in the circuit
        """
        self.p = Program()
        self.ro = self.p.declare('ro', 'BIT', n)
        self.n = n

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
        self.p += Program([I(i) for i in range(self.n)] + [X(self.n)])
        return self.p

    def left_hadamards(self):
        """
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in BV)
        :return: program state after this operation
        """
        self.p += Program([H(i) for i in range(self.n + 1)])
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
            self.p += Program(X(self.n))

        # first convert a into a bitstring for easy use
        a = self.int_to_bits(a, self.n)
        print('Expected:')
        print(a)

        for i, _a in enumerate(a):
            # wherever _a is 1, we insert a CNOT into the system targeting the helper bit
            if _a == 1:
                self.p += Program(CNOT(i, self.n))

        # return the program, which now has U_f inserted
        return self.p

    def right_hadamards(self):
        """
        Add a Hadamard gate to every qubit but the helper (corresponds to the right-hand-side hadamards in BV)
        :return: program state after this operation
        """
        self.p += Program([H(i) for i in range(self.n)])
        return self.p

    def measure_ro(self):
        """
        Measure every qubit but the last one
        :return: program state after this operation
        """
        self.p += Program([MEASURE(i, self.ro[i]) for i in range(self.n)])
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


def main():
    n = 5  # the number of bits in f: {0,1}^n → {0,1}

    a = 25  # the a in f(x) = a*x + b
    b = 1  # the b in f(x) = a*x + b

    # setup the experiment
    bv = Bernstein_Vazirani(n)
    p = bv.build_circuit(a, b)

    # multiple trials - check to make sure that the probability for getting the given outcome is 1
    p.wrap_in_numshots_loop(1)

    # actually perform the measurement
    qvm = get_qc('9q-square-qvm')
    with local_qvm():
        # one way of measuring:
        executable = qvm.compile(p)
        result = qvm.run(executable)
        print('Results:')
        print(result)
        print()


if __name__ == '__main__':
    main()
