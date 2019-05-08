from pyquil import Program
from pyquil.gates import *


def initialize_experiment(p, n):
    p += Program([I(i) for i in range(n)] + [X(n)])
    return p


def left_hadamards(p, n):
    p += Program([H(i) for i in range(n+1)])
    return p


def right_hadamards(p, n):
    p += Program([H(i) for i in range(n)])
    return p


def measure_ro(p, n, ro):
    p += Program([MEASURE(i, ro[i]) for i in range(n)])
    return p