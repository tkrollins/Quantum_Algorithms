"""
The main program that performs the Bernstein-Vazirani experiment
"""

from custom_gates import Bernstein_Vazirani
from pyquil import get_qc
from pyquil.api import local_qvm

n = 5   # the number of bits in f: {0,1}^n → {0,1}
a = 25  # the a in f(x) = a*x + b
b = 1   # the b in f(x) = a*x + b

# setup the experiment
bv = Bernstein_Vazirani(n)
p = bv.build_circuit(a, b)

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
