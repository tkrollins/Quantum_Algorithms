"""
The main program that performs the Bernstein-Vazirani experiment
"""

import cirq
import time


class Bernstein_Vazirani():

    def __init__(self, n):
        """
        Initialize the class with a particular n
        :param n: the number of bits to use in the circuit
        """
        self.n = n
        self.qubits = cirq.LineQubit.range(n + 1)
        self.circuit = cirq.Circuit()
        self.insert_strategy = cirq.InsertStrategy.NEW

    def build_circuit(self, a, b):
        """
        Return a Circuit that consists of the entire Bernstein-Vazirani experiment
        :param a: the a given in equation a*x + b
        :param b: the b given in equation a*x + b
        :return: the Cirq circuit
        """
        self.initialize_experiment()
        self.left_hadamards()
        self.insert_Uf(a, b)
        self.right_hadamards()
        self.measure_ro()
        return self.circuit

    def initialize_experiment(self):
        """
        Initialize the first qubits to 0 and the last (helper) qubit to 1
        :return p: circuit state after this operation
        """
        self.circuit.append([cirq.X(self.qubits[self.n])], strategy=self.insert_strategy)
        return self.circuit

    def left_hadamards(self):
        """
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in BV)
        :return: circuit state after this operation
        """
        self.circuit.append([cirq.H(self.qubits[i]) for i in range(self.n+1)], strategy=cirq.InsertStrategy.NEW_THEN_INLINE)
        return self.circuit

    def insert_Uf(self, a=2, b=2):
        """
        Inserts a U_f following Bernstein-Vazirani U_f into a given Program and returns the Program
        :param a: given a
        :param b: given b
        :return p: circuit state after this operation
        """

        # if b is not even, then we need to flip the helper qubit (the last one)
        if b % 2 != 0:
            self.circuit.append([cirq.X(self.qubits[self.n])], strategy=self.insert_strategy)

        # first convert a into a bitstring for easy use
        a = self.int_to_bits(a, self.n)
        print('Expected:', a)

        for i, _a in enumerate(a):
            # wherever _a is 1, we insert a CNOT into the system targeting the helper bit
            if _a == 1:
                self.circuit.append([cirq.CNOT(self.qubits[i], self.qubits[self.n])], strategy=self.insert_strategy)

        # return the program, which now has U_f inserted
        return self.circuit

    def right_hadamards(self):
        """
        Add a Hadamard gate to every qubit but the helper (corresponds to the right-hand-side hadamards in BV)
        :return: circuit state after this operation
        """
        self.circuit.append([cirq.H(self.qubits[i]) for i in range(self.n)], strategy=cirq.InsertStrategy.NEW_THEN_INLINE)
        return self.circuit

    def measure_ro(self):
        """
        Measure every qubit but the last one
        :return: circuit state after this operation
        """
        self.circuit.append([cirq.measure(self.qubits[i]) for i in range(self.n)], strategy=cirq.InsertStrategy.NEW_THEN_INLINE)
        return self.circuit

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


def run_BV(n, a, b):
    # setup the experiment
    bv = Bernstein_Vazirani(n)
    circuit = bv.build_circuit(a, b)

    # start simulator
    simulator = cirq.Simulator()
    t = time.time()
    result = simulator.run(circuit, repetitions=50)
    return_time = time.time() - t
    print(result)

    return result, return_time

def main():
    n = 5   # the number of bits in f: {0,1}^n → {0,1}

    a = 25  # the a in f(x) = a*x + b
    b = 1   # the b in f(x) = a*x + b

    run_BV(n, a, b)


if __name__ == '__main__':
    main()
