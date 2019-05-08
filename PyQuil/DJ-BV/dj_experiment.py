from pyquil import Program, get_qc
from pyquil.gates import *
from pyquil.api import local_qvm


class Deutsch_Jozsa():

    def __init__(self, n):
        """
        Initialize the class with a particular n
        :param n: the number of bits to use in the circuit
        """
        self.p = Program()
        self.ro = self.p.declare('ro', 'BIT', n)
        self.n = n

    def build_circuit(self, Uf):
        """
        Return a Program that consists of the entire Deutsch-Jozsa experiment
        :param Uf: U_f encoded with oracle function f
        :return:
        """
        self.initialize_experiment()
        self.left_hadamards()
        self.insert_Uf(Uf)
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
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in DJ)
        :return: program state after this operation
        """
        self.p += Program([H(i) for i in range(self.n + 1)])
        return self.p

    def insert_Uf(self, Uf):
        """
        Inserts a U_f following Deutsch-Jozsa U_f into a given Program and returns the Program
        :param Uf: U_f encoded with oracle function f
        :return p: program state after this operation
        """

        self.p += Program(Uf)

        # return the program, which now has U_f inserted
        return self.p

    def right_hadamards(self):
        """
        Add a Hadamard gate to every qubit but the helper (corresponds to the right-hand-side hadamards in DJ)
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


def run_DJ(balanced=True):
    Uf_balanced = CNOT(0, 3) # balanced U_f corresponding to an f that returns the first bit of a bitstring
    Uf_constant = I(0) # constant U_f corresponding to an f that always returns 0
    n = 3   # the number of bits in f: {0,1}^n → {0,1}

    # setup the experiment
    dj = Deutsch_Jozsa(n)
    if balanced:
        print('Expected:')
        print('[1 0 0]')
        p = dj.build_circuit(Uf_balanced)
    else:
        print('Expected:')
        print('[0 0 0]')
        p = dj.build_circuit(Uf_constant)

    # multiple trials - check to make sure that the probability for getting the given outcome is 1
    p.wrap_in_numshots_loop(5)

    # actually perform the measurement
    qvm = get_qc('9q-square-qvm')
    with local_qvm():
        # one way of measuring:
        executable = qvm.compile(p)
        result = qvm.run(executable)
        print('Results:')
        print(result)
        print()


run_DJ(balanced=True)

run_DJ(balanced=False)
