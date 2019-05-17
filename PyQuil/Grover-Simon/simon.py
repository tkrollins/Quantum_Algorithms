from pyquil import Program, get_qc
from pyquil.gates import *
from pyquil.api import local_qvm
import numpy as np

class Simon():

    def __init__(self, f):
        """
        Initialize the class with a particular n
        :param f: the oracle function, represented as a truth table. First n-1 elements are the input bits,
        element n is the output bit
        """
        self.f = f
        self.qubit = [i for i in range(9)] # change qubit index based on QPU
        self.p = Program()
        self.uf = Program()
        self.n = int(len(f[0]) / 2)
        self.ro = self.p.declare('ro', 'BIT', self.n)

    def build_circuit(self):
        """
        Return a Program that consists of the entire Deutsch-Jozsa experiment
        :param Uf: U_f encoded with oracle function f
        :return:
        """
        self.left_hadamards()
        self.build_Uf()
        self.right_hadamards()
        self.measure_ro()
        return self.p

    def left_hadamards(self):
        """
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in DJ)
        :return: program state after this operation
        """
        self.p += Program([H(i) for i in range(self.n)])
        return self.p

    def build_Uf(self):
        """
        Builds a U_f gate by chaining CCNOT gates. Idea is that any input, x,
        that results in f(x) = 1 will flip qubit b.
        If n > 2, then helper bits are used
        to implement the CCNOT gates correctly.
        :return: program state after this operation
        """

        def NOTs(x):
            NOTs = Program()
            for i, bit in enumerate(x):
                if bit == 0:
                    NOTs += X(self.qubit[i])
            return NOTs

        def nbit_CNOT(x, b):
            nBit_CNOT = X(b)
            for i in range(len(x)):
                nBit_CNOT = nBit_CNOT.controlled(self.qubit[i])
            return nBit_CNOT

        for bitstring in self.f:
            bitstring = np.array(bitstring)
            x = bitstring[0:self.n]
            f_x = bitstring[self.n:]
            X_gates = NOTs(x)
            self.uf += X_gates
            for i, b in enumerate(f_x):
                i += self.n
                if b == 1:
                    self.uf += nbit_CNOT(x, self.qubit[i])
            self.uf += X_gates
        self.p += self.uf
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


def run_Simon(f):

    def solve(y_set, n):
        s_set = set([s for s in range(1, 2 ** n)])
        for y in y_set:
            to_be_removed = set()
            for s in s_set:
                s_bin = np.array(list(f'{s:0{n}b}')).astype(int)
                if np.dot(y, s_bin) % 2 != 0:
                    to_be_removed.add(s)
            s_set = s_set.difference(to_be_removed)
        return s_set

    # setup the experiment
    simon = Simon(f)
    p = simon.build_circuit()

    # multiple trials - check to make sure that the probability for getting the given outcome is 1
    p.wrap_in_numshots_loop(simon.n-1)

    # actually perform the measurement
    qvm = get_qc('9q-square-qvm')
    qvm.compiler.client.timeout = 600  # number of seconds

    with local_qvm():
        s_set = set([i for i in range(1, 2 ** simon.n)])
        # one way of measuring:
        executable = qvm.compile(p)
        for i in range(5):
            y_set = qvm.run(executable)
            s_set = s_set.intersection(solve(y_set, simon.n))
        result = [np.array(list(f'{s:0{simon.n}b}')).astype(int) for s in s_set]
        print('Results:')
        print(result)
        print()


f_3 = [[0,0,0,1,0,1], [0,0,1,0,1,0], [0,1,0,0,0,0], [0,1,1,1,1,0], [1,0,0,0,0,0], [1,0,1,1,1,0], [1,1,0,1,0,1], [1,1,1,0,1,0]]

f_2 = [[0,0,0,0], [0,1,1,1], [1,0,1,1], [1,1,0,0]]

run_Simon(f_2)