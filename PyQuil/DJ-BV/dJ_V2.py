from pyquil import Program, get_qc
from pyquil.gates import *
from pyquil.api import local_qvm
import numpy as np


class Deutsch_Jozsa():

    def __init__(self, f, qubits):
        """
        Initialize the class with a particular n
        :param f: the oracle function, represented as a truth table. First n-1 elements are the input bits,
        element n is the output bit
        """
        self.f = f
        self.qubit = qubits  # change qubit index based on topology
        self.p = Program()
        self.uf = Program()
        self.n = len(f[0]) - 1
        self.ro = self.p.declare('ro', 'BIT', self.n)

    def build_circuit(self):
        """
        Return a Program that consists of the entire Deutsch-Jozsa experiment
        :param Uf: U_f encoded with oracle function f
        :return:
        """
        self.initialize_experiment()
        self.left_hadamards()
        self.build_Uf()
        self.right_hadamards()
        self.measure_ro()
        return self.p

    def initialize_experiment(self):
        """
        Initialize the first qubits to 0 and the last (helper) qubit to 1
        :return: program state after this operation
        """
        self.p += Program([I(i) for i in self.qubit[:self.n]] + [X(self.qubit[self.n])])
        return self.p

    def left_hadamards(self):
        """
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in DJ)
        :return: program state after this operation
        """
        self.p += Program([H(i) for i in self.qubit[:self.n+1]])
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

        count = 0

        for bitstring in self.f:
            b = bitstring[-1]
            x = bitstring[:-1]
            if b == 1:
                count += 1
                if count > (2**(self.n-1)):
                    # U_f(b) = b XOR f(x) = NOT(b)
                    self.p += X(b)
                    return self.p
                X_gates = NOTs(x)
                # all 0 x bits are NOT'd
                self.uf += X_gates
                # flips b controlled on all input bits
                self.uf += nbit_CNOT(x, self.qubit[self.n])
                # undo previous NOT
                self.uf += X_gates
        self.p += self.uf
        return self.p

    def right_hadamards(self):
        """
        Add a Hadamard gate to every qubit but the helper (corresponds to the right-hand-side hadamards in DJ)
        :return: program state after this operation
        """
        self.p += Program([H(i) for i in self.qubit[:self.n+1]])
        return self.p

    def measure_ro(self):
        """
        Measure every qubit but the last one
        :return: program state after this operation
        """
        self.p += Program([MEASURE(j, self.ro[i]) for i, j in enumerate(self.qubit[:self.n])])
        return self.p


def run_DJ(f):
    # set topology of qvm
    qvm = get_qc('Aspen-4-6Q-A-qvm')
    qvm.compiler.client.timeout = 30  # number of seconds
    qubits = qvm.qubits()

    # setup the experiment
    dj = Deutsch_Jozsa(f, qubits)
    p = dj.build_circuit()

    # multiple trials - check to make sure that the probability for getting the given outcome is 1
    p.wrap_in_numshots_loop(5)

    with local_qvm():
        # one way of measuring:
        executable = qvm.compile(p)
        result = qvm.run(executable)
        print('Results:')
        print(result)
        print()


# Balanced f's, represented by truth table. First n-1 elements are the input bits, element n is the output bit

f_bal_1 = [[0,0],[1,1]]

f_bal_2 = [[0,0,0], [0,1,0], [1,0,1], [1,1,1]]

f_bal_3 = [[0,0,0,1], [0,0,1,0], [0,1,0,0], [0,1,1,1], [1,0,0,1], [1,0,1,0], [1,1,0,0], [1,1,1,1]]

f_bal_4 = [[0,0,0,0,1],[0,0,0,1,0],[0,0,1,0,1],[0,0,1,1,0],[0,1,0,0,1],[0,1,0,1,0],[0,1,1,0,1],[0,1,1,1,0],
           [1,0,0,0,1],[1,0,0,1,0],[1,0,1,0,1],[1,0,1,1,0],[1,1,0,0,1],[1,1,0,1,0],[1,1,1,0,1],[1,1,1,1,0]]

f_bal_5 = [[0,0,0,0,0,1],[0,0,0,0,1,1],[0,0,0,1,0,1],[0,0,0,1,1,1],[0,0,1,0,0,1],[0,0,1,0,1,1],[0,0,1,1,0,1],[0,0,1,1,1,1],
           [0,1,0,0,0,0],[0,1,0,0,1,0],[0,1,0,1,0,0],[0,1,0,1,1,0],[0,1,1,0,0,0],[0,1,1,0,1,0],[0,1,1,1,0,0],[0,1,1,1,1,0],
           [1,0,0,0,0,0],[1,0,0,0,1,0],[1,0,0,1,0,0],[1,0,0,1,1,0],[1,0,1,0,0,0],[1,0,1,0,1,0],[1,0,1,1,0,0],[1,0,1,1,1,0],
           [1,1,0,0,0,1],[1,1,0,0,1,1],[1,1,0,1,0,1],[1,1,0,1,1,1],[1,1,1,0,0,1],[1,1,1,0,1,1],[1,1,1,1,0,1],[1,1,1,1,1,1]]


# Constant f's, represented by truth table. First n-1 elements are the input bits, element n is the output bit
# Constant f with output of 0
f_const_1_0 = [[0,0],[1,0]]

f_const_2_0 = [[0,0,0], [0,1,0], [1,0,0], [1,1,0]]

f_const_3_0 = [[0,0,0,0], [0,0,1,0], [0,1,0,0], [0,1,1,0], [1,0,0,0], [1,0,1,0], [1,1,0,0], [1,1,1,0]]

f_const_4_0 = [[0,0,0,0,0],[0,0,0,1,0],[0,0,1,0,0],[0,0,1,1,0],[0,1,0,0,0],[0,1,0,1,0],[0,1,1,0,0],[0,1,1,1,0],
           [1,0,0,0,0],[1,0,0,1,0],[1,0,1,0,0],[1,0,1,1,0],[1,1,0,0,0],[1,1,0,1,0],[1,1,1,0,0],[1,1,1,1,0]]

f_const_5_0 = [[0,0,0,0,0,0],[0,0,0,0,1,0],[0,0,0,1,0,0],[0,0,0,1,1,0],[0,0,1,0,0,0],[0,0,1,0,1,0],[0,0,1,1,0,0],[0,0,1,1,1,0],
           [0,1,0,0,0,0],[0,1,0,0,1,0],[0,1,0,1,0,0],[0,1,0,1,1,0],[0,1,1,0,0,0],[0,1,1,0,1,0],[0,1,1,1,0,0],[0,1,1,1,1,0],
           [1,0,0,0,0,0],[1,0,0,0,1,0],[1,0,0,1,0,0],[1,0,0,1,1,0],[1,0,1,0,0,0],[1,0,1,0,1,0],[1,0,1,1,0,0],[1,0,1,1,1,0],
           [1,1,0,0,0,0],[1,1,0,0,1,0],[1,1,0,1,0,0],[1,1,0,1,1,0],[1,1,1,0,0,0],[1,1,1,0,1,0],[1,1,1,1,0,0],[1,1,1,1,1,0]]

# Constant f with output of 1
f_const_1_1 = [[0,1],[1,1]]

f_const_2_1 = [[0,0,1], [0,1,1], [1,0,1], [1,1,1]]

f_const_3_1 = [[0,0,0,1], [0,0,1,1], [0,1,0,1], [0,1,1,1], [1,0,0,1], [1,0,1,1], [1,1,0,1], [1,1,1,1]]

f_const_4_1 = [[0,0,0,0,1],[0,0,0,1,1],[0,0,1,0,1],[0,0,1,1,1],[0,1,0,0,1],[0,1,0,1,1],[0,1,1,0,1],[0,1,1,1,1],
           [1,0,0,0,1],[1,0,0,1,1],[1,0,1,0,1],[1,0,1,1,1],[1,1,0,0,1],[1,1,0,1,1],[1,1,1,0,1],[1,1,1,1,1]]

# Will return [0 0 0 1]
run_DJ(f_bal_4)
# Will return [0 0 0 0]
run_DJ(f_const_4_0)
# Will return [0 0 0 0]
run_DJ(f_const_4_1)
