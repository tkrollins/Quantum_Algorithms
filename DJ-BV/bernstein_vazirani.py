from pyquil import Program
from pyquil.gates import *


def insert_Uf(p, n, a=2, b=2):
    """
    Inserts a U_f following Bernstein-Vazirani U_f into a given Program and returns the Program
    :param p: the input Program
    :param n: number of bits in representation
    :param a: given a
    :param b: given b
    :return p: the changed Program
    """

    # if b is not even, then we need to flip the helper qubit (the last one)
    if b % 2 != 0:
        p += Program(X(n))

    # first convert a into a bitstring for easy use
    a = int_to_bits(a, n)
    print('Expected:')
    print(a)
    print()

    for i, _a in enumerate(a):
        # wherever _a is 1, we insert a CNOT into the system targeting the helper bit
        if _a == 1:
            p += Program(CNOT(i, n))

    # return the program, which now has U_f inserted
    return p


def int_to_bits(i, n):
    """
    helper function for converting int to a bitstring representation
    :param i: int to convert
    :param n: number of bits to convert i into
    :return: the converted bitstring as an array
    """
    y = [int(digit) for digit in bin(i)[2:]]
    while len(y) < n:
        y = [0] + y
    return y
