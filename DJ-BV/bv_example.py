'''
The program performs the Bernstein-Vazirani experiment
'''

from custom_gates import *
from bernstein_vazirani import insert_Uf

from pyquil import Program, get_qc
from pyquil.gates import *
from pyquil.api import local_qvm

n = 3

qvm = get_qc('9q-square-qvm')

p = Program()
ro = p.declare('ro', 'BIT', n)

# initializing the bits
p = initialize_experiment(p, n)

# add hadamards
p = left_hadamards(p, 3)
# p += Program(H(0), H(1), H(2), H(3))

# add U_f
p = insert_Uf(p, n, a=5, b=2)

# add last hadamards
p = right_hadamards(p, n)

# measure
p = measure_ro(p, n, ro)

# multiple trials - check to make sure that our probabilities are 1
p.wrap_in_numshots_loop(5)

with local_qvm():
    # one way of measuring:
    executable = qvm.compile(p)
    result = qvm.run(executable)
    print('Results:')
    print(result)
    print()

# # note: can also look at mathematical expression using wavesim:
# from pprint import pprint
# from pyquil.api import WavefunctionSimulator
# print('Probabilities:')
# wf_sim = WavefunctionSimulator()
# wavefunction = wf_sim.wavefunction(p)
# prob_dict = wavefunction.get_outcome_probs()    # extracts the probabilities of outcomes as a dict
# pprint(prob_dict)
