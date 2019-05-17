from pyquil import Program, get_qc
from pyquil.gates import *
from pyquil.api import local_qvm
import numpy as np

class Simon():

    def __init__(self, f, qubits):
        """
        Initialize the class with a particular n, and the qubits indices
        :param qubits: legal qubit indices from given topology
        :param f: the oracle function, represented as a truth table. First n-1 elements are the input bits,
        element n is the output bit
        """
        self.f = f
        self.qubit = qubits # change qubit index based on topology
        self.p = Program()
        self.uf = Program()
        self.n = int(len(f[0]) / 2)
        self.ro = self.p.declare('ro', 'BIT', self.n)

    def build_circuit(self):
        """
        Return a Program that consists of the entire Simon experiment
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
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards)
        :return: program state after this operation
        """
        self.p += Program([H(i) for i in range(self.n)])
        return self.p

    def build_Uf(self):
        """
        Builds a U_f gate by chaining controlled-X gates. For any x, f(x) = b_0...b_n-1.
        if b_i=1, it will be passed through an X-gate controlled by x.
        :return: program state after this operation
        """

        def NOTs(x):
            """
            :param x: input bitstring
            :return: A Program containing X-gates at each qubit index in which the input bit = 0
            """
            NOTs = Program()
            for i, bit in enumerate(x):
                if bit == 0:
                    NOTs += X(self.qubit[i])
            return NOTs

        def nbit_CNOT(x, b):
            """
            :param x: input bitstring
            :param b: helper bit to be flipped
            :return: X-gate on helper bit, controlled by each input bit
            """
            nBit_CNOT = X(b)
            for i in range(len(x)):
                nBit_CNOT = nBit_CNOT.controlled(self.qubit[i])
            return nBit_CNOT

        for bitstring in self.f:
            bitstring = np.array(bitstring)
            # input bits
            x = bitstring[0:self.n]
            # output bits
            f_x = bitstring[self.n:]
            X_gates = NOTs(x)
            # all 0 x bits are NOT'd
            self.uf += X_gates
            for i, b in enumerate(f_x):
                i += self.n
                if b == 1:
                    # flips b controlled on all input bits
                    self.uf += nbit_CNOT(x, self.qubit[i])
            # undo previous NOT
            self.uf += X_gates
        self.p += self.uf
        return self.p

    def right_hadamards(self):
        """
        Add a Hadamard gate to every qubit but the helper (corresponds to the right-hand-side hadamards)
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


def run_Simon(f, iter=5):
    """
    :param iter: number of iterations run
    :param f: The oracle function with the property s encoded
    :return: The non-0^n value of s
    """
    def solve(y_set):
        """
        Naive solver for s given a set of y vectors.
        :param y_set: y vectors returned from quantum part of algorithm.   For every y, <y, s> = 0
        :return: A set of all valid s values in integer form. Does not include 0.
        """
        # number of bits in y/s
        n = len(y_set[0])
        # set of all currently valid s values
        s_set = set([s for s in range(1, 2 ** n)])
        for y in y_set:
            to_be_removed = set()
            for s in s_set:
                s_bin = np.array(list(f'{s:0{n}b}')).astype(int)
                # mod 2 dot product
                if np.dot(y, s_bin) % 2 != 0:
                    # s values that do not satisfy <y, s> = 0
                    to_be_removed.add(s)
            s_set = s_set.difference(to_be_removed)
        return s_set

    # set topology of qvm
    qvm = get_qc('Aspen-4-6Q-A-qvm')
    qubits = qvm.qubits()

    # setup the circuit
    simon = Simon(f, qubits)
    p = simon.build_circuit()

    # n-1 y's will be collected per iteration
    p.wrap_in_numshots_loop((simon.n-1) if simon.n > 1 else simon.n)

    with local_qvm():
        # set of all currently valid s values
        s_set = set([i for i in range(1, 2 ** simon.n)])
        executable = qvm.compile(p)
        for i in range(iter):
            y_set = qvm.run(executable)
            # remove invalid s values
            s_set = s_set.intersection(solve(y_set))
        # array of valid s values found. Does not include 0 vector
        result = [np.array(list(f'{s:0{simon.n}b}')).astype(int) for s in s_set]
        print('Results:')
        print(result)
        print()

# Oracle functions.  First n/2 bits are input, second n/2 bits are output

# 1-bit function. s = [1]
f_1 = [[0,1], [1,1]]

# 2-bit function. s = [1, 1]
f_2 = [[0,0,0,0], [0,1,1,1], [1,0,1,1], [1,1,0,0]]

# 3-bit function. s = [1, 1, 0]
f_3 = [[0,0,0,1,0,1], [0,0,1,0,1,0], [0,1,0,0,0,0], [0,1,1,1,1,0], [1,0,0,0,0,0], [1,0,1,1,1,0], [1,1,0,1,0,1], [1,1,1,0,1,0]]

# Will likely return [1]
run_Simon(f_1)

# # Will likely return [1,1]
run_Simon(f_2)
#
# # Will likely return [1,1,0]
run_Simon(f_3)
