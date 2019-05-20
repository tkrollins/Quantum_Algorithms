from pyquil import Program, get_qc
from pyquil.gates import *
from pyquil.api import local_qvm
import numpy as np
from scipy.linalg import null_space
import time
import matplotlib.pyplot as plt

class Simon():

    def __init__(self, f, qubits):
        """
        Initialize the class with a particular n, and the qubits indices
        :param qubits: legal qubit indices from given topology
        :param f: the oracle function, represented as a truth table. First n/2 elements are the input bits,
        second n/2 bits are output
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
        self.p += Program([H(i) for i in self.qubit[:self.n]])
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
            x = bitstring[:self.n]
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
        self.p += Program([H(i) for i in self.qubit[:self.n]])
        return self.p

    def measure_ro(self):
        """
        Measure every qubit but the last one
        :return: program state after this operation
        """
        self.p += Program([MEASURE(j, self.ro[i]) for i, j in enumerate(self.qubit[:self.n])])
        return self.p


def run_Simon(f, naive=False):
    """
    :param naive: True will run the naive solver to find s
    :param f: The oracle function with the property s encoded
    :return: Prints the non-0^n value of s
    """
    def naive_solve(y_set):
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
    # qvm.compiler.client.timeout = 300  # number of seconds
    qubits = qvm.qubits()

    # setup the circuit
    simon = Simon(f, qubits)
    p = simon.build_circuit()

    shots = simon.n*2
    # 2n y's will be collected per iteration
    p.wrap_in_numshots_loop(shots)

    with local_qvm():

        while True:
            executable = qvm.compile(p)
            # collcet y's and remove duplicates
            y_set = np.unique(qvm.run(executable), axis=0)
            if simon.n > 1:
                # removes 0 vector
                y_set = np.delete(y_set, np.where(~y_set.any(axis=1))[0], axis=0)
            if len(y_set) > simon.n-1 and simon.n != 1:
                # remove one y so n-1 left
                y_set = y_set[:-1]
            if len(y_set) == (simon.n-1) or (simon.n == 1 and len(y_set) == 1):
                break

        if naive:
            # set of all currently valid s values
            s_set = set([i for i in range(1, 2 ** simon.n)])
            # remove invalid s values
            s_set = s_set.intersection(naive_solve(y_set))
            # array of valid s values found. Does not include 0 vector
            result = [np.array(list(f'{s:0{simon.n}b}')).astype(int) for s in s_set]
        else:
            # Solve by finding null space of n-1 y matrix
            ns = null_space(y_set)
            # make all elements positive, norm to 0/1
            result = np.sign(ns*ns).transpose()

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

# 4-bit function. s = [1, 1, 1, 1]
f_4 = [[0,0,0,0, 1,1,1,1], [0,0,0,1, 1,1,1,0], [0,0,1,0, 1,1,0,1], [0,0,1,1, 1,1,0,0], [0,1,0,0, 1,0,1,1], [0,1,0,1, 1,0,1,0],
       [0,1,1,0, 1,0,0,1], [0,1,1,1, 1,0,0,0], [1,0,0,0, 1,0,0,0], [1,0,0,1, 1,0,0,1], [1,0,1,0, 1,0,1,0], [1,0,1,1, 1,0,1,1],
       [1,1,0,0, 1,1,0,0], [1,1,0,1, 1,1,0,1], [1,1,1,0, 1,1,1,0], [1,1,1,1, 1,1,1,1]]


# Will return [1]
run_Simon(f_1)

# Will return [1,1]
run_Simon(f_2)

# Will return [1,1,0]
run_Simon(f_3)



