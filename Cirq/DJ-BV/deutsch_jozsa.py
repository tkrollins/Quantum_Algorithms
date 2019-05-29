import cirq
import time


class Deutsch_Jozsa():

    def __init__(self, f):
        """
        Initialize the class with a particular f
        :param f: the oracle function, represented as a truth table. First n-1 elements are the input bits,
        element n is the output bit
        """
        self.f = f
        self.n = len(f[0]) - 1
        self.qubits = cirq.LineQubit.range(self.n + 1)
        self.circuit = cirq.Circuit()
        self.uf = cirq.Circuit()

    def build_circuit(self):
        """
        Return a Circuit that consists of the experiment
        :return: the Cirq circuit
        """
        self.initialize_experiment()
        self.left_hadamards()
        self.insert_Uf()
        self.right_hadamards()
        self.measure_ro()
        return self.circuit

    def initialize_experiment(self):
        """
        Initialize the first qubits to 0 and the last (helper) qubit to 1
        :return p: circuit state after this operation
        """
        self.circuit.append([cirq.X(self.qubits[self.n])], strategy=cirq.InsertStrategy.NEW)
        return self.circuit

    def left_hadamards(self):
        """
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in BV)
        :return: circuit state after this operation
        """
        self.circuit.append([cirq.H(self.qubits[i]) for i in range(self.n+1)], strategy=cirq.InsertStrategy.NEW_THEN_INLINE)
        return self.circuit

    def insert_Uf(self):
        """
        Inserts a U_f into a given Program and returns the Program
        :return p: circuit state after this operation
        """

        def NOTs(x):
            """
            :param x: input bitstring
            :return: A Program containing X-gates at each qubit index in which the input bit = 0
            """
            NOTs = cirq.Circuit()
            for i, bit in enumerate(x):
                if bit == 0:
                    NOTs.append(cirq.X(self.qubits[i]))
            return NOTs

        count = 0

        for bitstring in self.f:
            b = bitstring[-1]
            x = bitstring[:-1]
            if b == 1:
                count += 1
                if count > (2 ** (self.n - 1)):
                    # U_f(b) = b XOR f(x) = NOT(b)
                    self.circuit.append(cirq.X(self.qubits[-1]))
                    return self.circuit
                X_gates = NOTs(x)
                # all 0 x bits are NOT'd
                self.uf += X_gates
                # flips b controlled on all input bits
                controlled_not = cirq.ControlledGate(cirq.X, self.qubits[:-1], self.n)
                self.uf.append(controlled_not(self.qubits[-1]))
                # undo previous NOT
                self.uf += X_gates
        self.circuit.append(self.uf)
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


def run_DJ(f):
    # setup the experiment
    bv = Deutsch_Jozsa(f)
    circuit = bv.build_circuit()

    # start simulator
    simulator = cirq.Simulator()
    t = time.time()
    result = simulator.run(circuit, repetitions=10)
    return_time = time.time() - t
    print(result)

    return result, return_time

# Balanced f's, represented by truth table. First n-1 elements are the input bits, element n is the output bit

f_bal_1 = [[0, 0], [1, 1]]

f_bal_2 = [[0, 0, 0], [0, 1, 0], [1, 0, 1], [1, 1, 1]]

f_bal_3 = [[0, 0, 0, 1], [0, 0, 1, 0], [0, 1, 0, 0], [0, 1, 1, 1], [1, 0, 0, 1], [1, 0, 1, 0], [1, 1, 0, 0],
           [1, 1, 1, 1]]

f_bal_4 = [[0, 0, 0, 0, 1], [0, 0, 0, 1, 0], [0, 0, 1, 0, 1], [0, 0, 1, 1, 0], [0, 1, 0, 0, 1], [0, 1, 0, 1, 0],
           [0, 1, 1, 0, 1], [0, 1, 1, 1, 0],
           [1, 0, 0, 0, 1], [1, 0, 0, 1, 0], [1, 0, 1, 0, 1], [1, 0, 1, 1, 0], [1, 1, 0, 0, 1], [1, 1, 0, 1, 0],
           [1, 1, 1, 0, 1], [1, 1, 1, 1, 0]]

f_bal_5 = [[0, 0, 0, 0, 0, 1], [0, 0, 0, 0, 1, 1], [0, 0, 0, 1, 0, 1], [0, 0, 0, 1, 1, 1], [0, 0, 1, 0, 0, 1],
           [0, 0, 1, 0, 1, 1], [0, 0, 1, 1, 0, 1], [0, 0, 1, 1, 1, 1],
           [0, 1, 0, 0, 0, 0], [0, 1, 0, 0, 1, 0], [0, 1, 0, 1, 0, 0], [0, 1, 0, 1, 1, 0], [0, 1, 1, 0, 0, 0],
           [0, 1, 1, 0, 1, 0], [0, 1, 1, 1, 0, 0], [0, 1, 1, 1, 1, 0],
           [1, 0, 0, 0, 0, 0], [1, 0, 0, 0, 1, 0], [1, 0, 0, 1, 0, 0], [1, 0, 0, 1, 1, 0], [1, 0, 1, 0, 0, 0],
           [1, 0, 1, 0, 1, 0], [1, 0, 1, 1, 0, 0], [1, 0, 1, 1, 1, 0],
           [1, 1, 0, 0, 0, 1], [1, 1, 0, 0, 1, 1], [1, 1, 0, 1, 0, 1], [1, 1, 0, 1, 1, 1], [1, 1, 1, 0, 0, 1],
           [1, 1, 1, 0, 1, 1], [1, 1, 1, 1, 0, 1], [1, 1, 1, 1, 1, 1]]

# Constant f's, represented by truth table. First n-1 elements are the input bits, element n is the output bit
# Constant f with output of 0
f_const_1_0 = [[0, 0], [1, 0]]

f_const_2_0 = [[0, 0, 0], [0, 1, 0], [1, 0, 0], [1, 1, 0]]

f_const_3_0 = [[0, 0, 0, 0], [0, 0, 1, 0], [0, 1, 0, 0], [0, 1, 1, 0], [1, 0, 0, 0], [1, 0, 1, 0], [1, 1, 0, 0],
               [1, 1, 1, 0]]

f_const_4_0 = [[0, 0, 0, 0, 0], [0, 0, 0, 1, 0], [0, 0, 1, 0, 0], [0, 0, 1, 1, 0], [0, 1, 0, 0, 0], [0, 1, 0, 1, 0],
               [0, 1, 1, 0, 0], [0, 1, 1, 1, 0],
               [1, 0, 0, 0, 0], [1, 0, 0, 1, 0], [1, 0, 1, 0, 0], [1, 0, 1, 1, 0], [1, 1, 0, 0, 0], [1, 1, 0, 1, 0],
               [1, 1, 1, 0, 0], [1, 1, 1, 1, 0]]

f_const_5_0 = [[0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 1, 0], [0, 0, 0, 1, 0, 0], [0, 0, 0, 1, 1, 0], [0, 0, 1, 0, 0, 0],
               [0, 0, 1, 0, 1, 0], [0, 0, 1, 1, 0, 0], [0, 0, 1, 1, 1, 0],
               [0, 1, 0, 0, 0, 0], [0, 1, 0, 0, 1, 0], [0, 1, 0, 1, 0, 0], [0, 1, 0, 1, 1, 0], [0, 1, 1, 0, 0, 0],
               [0, 1, 1, 0, 1, 0], [0, 1, 1, 1, 0, 0], [0, 1, 1, 1, 1, 0],
               [1, 0, 0, 0, 0, 0], [1, 0, 0, 0, 1, 0], [1, 0, 0, 1, 0, 0], [1, 0, 0, 1, 1, 0], [1, 0, 1, 0, 0, 0],
               [1, 0, 1, 0, 1, 0], [1, 0, 1, 1, 0, 0], [1, 0, 1, 1, 1, 0],
               [1, 1, 0, 0, 0, 0], [1, 1, 0, 0, 1, 0], [1, 1, 0, 1, 0, 0], [1, 1, 0, 1, 1, 0], [1, 1, 1, 0, 0, 0],
               [1, 1, 1, 0, 1, 0], [1, 1, 1, 1, 0, 0], [1, 1, 1, 1, 1, 0]]

# Constant f with output of 1
f_const_1_1 = [[0, 1], [1, 1]]

f_const_2_1 = [[0, 0, 1], [0, 1, 1], [1, 0, 1], [1, 1, 1]]

f_const_3_1 = [[0, 0, 0, 1], [0, 0, 1, 1], [0, 1, 0, 1], [0, 1, 1, 1], [1, 0, 0, 1], [1, 0, 1, 1], [1, 1, 0, 1],
               [1, 1, 1, 1]]

f_const_4_1 = [[0, 0, 0, 0, 1], [0, 0, 0, 1, 1], [0, 0, 1, 0, 1], [0, 0, 1, 1, 1], [0, 1, 0, 0, 1], [0, 1, 0, 1, 1],
               [0, 1, 1, 0, 1], [0, 1, 1, 1, 1],
               [1, 0, 0, 0, 1], [1, 0, 0, 1, 1], [1, 0, 1, 0, 1], [1, 0, 1, 1, 1], [1, 1, 0, 0, 1], [1, 1, 0, 1, 1],
               [1, 1, 1, 0, 1], [1, 1, 1, 1, 1]]

def main():
    run_DJ(f_bal_3)
    run_DJ(f_const_3_1)


if __name__ == '__main__':
    main()
