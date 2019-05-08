# py -m pip install

from pprint import pprint

from pyquil import Program, get_qc
from pyquil.gates import *
from pyquil.api import WavefunctionSimulator
from pyquil.api import local_qvm

qvm = get_qc('9q-square-qvm')

p = Program()
ro = p.declare('ro', 'BIT', 3)

# initializing the bits
p += Program(I(0), I(1), I(2), X(3))

# add hadamards
p += Program(H(0), H(1), H(2), H(3))

# add U_f
p += Program(CNOT(1, 3))

# add last hadamards
p += Program(H(0), H(1), H(2), I(3))

# measure
p += Program(MEASURE(0, ro[0]), MEASURE(1, ro[1]), MEASURE(2, ro[2]))

print('Program:')
print(p)
# multiple trials - check to make sure that our probabilities are 1
p.wrap_in_numshots_loop(5)

with local_qvm():
    # one way of measuring:
    executable = qvm.compile(p)
    result = qvm.run(executable)
    print('Results:')
    print(result)
    print()

# note: can also look at mathematical expression using wavesim:
print('Probabilities:')
wf_sim = WavefunctionSimulator()
wavefunction = wf_sim.wavefunction(p)
prob_dict = wavefunction.get_outcome_probs()    # extracts the probabilities of outcomes as a dict
pprint(prob_dict)
