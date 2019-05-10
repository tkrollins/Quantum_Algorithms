from pyquil import Program, get_qc
from pyquil.gates import *
from pyquil.api import local_qvm


class Deutsch_Jozsa():

    def __init__(self, f):
        """
        Initialize the class with a particular n
        :param f: the oracle function, represented as a truth table. First n-1 elements are the input bits,
        element n is the output bit
        """
        self.f = f
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
        self.p += Program([I(i) for i in range(self.n)] + [X(8)])
        return self.p

    def left_hadamards(self):
        """
        Add a Hadamard gate to every qubit (corresponds to the left-hand-side hadamards in DJ)
        :return: program state after this operation
        """
        self.p += Program([H(i) for i in range(self.n)] + [H(8)])
        return self.p

    def build_Uf(self):
        """
        Builds a U_f gate by chaining CCNOT gates. Idea is that any input, x,
        that results in f(x) = 1 will flip qubit b.
        If n > 2, then helper bits are used
        to implement the CCNOT gates correctly.
        :return: program state after this operation
        """
        h = 5  # position of first helper bit in circuit
        q = 0  # position of first qubit bit in circuit
        b = 8  # position of b in circuit

        def add_CCNOT(x1, x2, target):
            """
            Adds a CCNOT gate to self.p, with bits x1, x2, controlling target. If bits x1 or x2 == 0,
            then a X gate is temporarily used to flip them
            :param x1: Position of first control qubit
            :param x2: Position of second control qubit
            :param target: Position of controlled qubit
            """
            if x1 < self.n and self.bitstring[x1] == 0:
                self.uf += X(x1)
            if x2 < self.n and self.bitstring[x2] == 0:
                self.uf += X(x2)

            self.uf += CCNOT(x1, x2, target)

            if x1 < self.n and self.bitstring[x1] == 0:
                self.uf += X(x1)
            if x2 < self.n and self.bitstring[x2] == 0:
                self.uf += X(x2)

        def add_gates(q, h):
            """
            Recursively adds CCNOT gates to the circuit until it reaches the last input qubit (q == self.n-1).
            Then adds all the CCNOT gates a second time on the way up to reverse previous X-gates.
            :param q: Input qubit position
            :param h: Helper qubit position
            """
            # if q == n-1, this is the final CCNOT gate that will flip b
            if q == self.n - 1:
                add_CCNOT(q, h, b)
            else:
                # These CCNOT gates flip helper bits
                add_CCNOT(q, h, h + 1)
                add_gates(q + 1, h + 1)
                add_CCNOT(q, h, h + 1)

        # flip all helper bits to |1>
        self.uf += Program(X(h), X(h + 1), X(h + 2))

        for bitstring in self.f:
            self.bitstring = bitstring
            # Only create gates for inputs that result in f(x) = 1
            if bitstring[-1] == 1:
                # if n == 1, then only one CCNOT gate is needed to flip b
                if self.n == 1:
                    add_CCNOT(q, h, b)
                # if n == 2, then only one CCNOT gate is needed to flip b
                elif self.n == 2:
                    add_CCNOT(q, q + 1, b)
                else:
                    add_CCNOT(q, q + 1, h)
                    add_gates(q + 2, h)
                    add_CCNOT(q, q + 1, h)

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


def run_DJ(f):
    # setup the experiment
    dj = Deutsch_Jozsa(f)
    p = dj.build_circuit()

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


# Balanced f, represented by truth table. First n-1 elements are the input bits, element n is the output bit
f_bal = [[0,0,0,1], [0,0,1,0], [0,1,0,0], [0,1,1,1], [1,0,0,1], [1,0,1,0], [1,1,0,0], [1,1,1,1]]
# Constant f, represented by truth table. First n-1 elements are the input bits, element n is the output bit
f_const = [[0,0,0,0], [0,0,1,0], [0,1,0,0], [0,1,1,0], [1,0,0,0], [1,0,1,0], [1,1,0,0], [1,1,1,0]]

print('Balanced:')
run_DJ(f_bal)
print('Constant:')
run_DJ(f_const)



