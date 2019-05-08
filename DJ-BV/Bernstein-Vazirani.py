# py -m pip install

import numpy as np

from pyquil import Program, get_qc
from pyquil.gates import *
from pyquil.api import WavefunctionSimulator
from pyquil.api import local_qvm

qvm = get_qc('9q-square-qvm')

# initializing the bits
state_prep = Program(I(0), I(1), I(2), X(3))

# add hadamards
hadamards_left = Program(H(0), H(1), H(2), H(3))

# add U_f
U_f = Program(CNOT(1, 3))

# add last hadamards
hadamards_right = Program(H(0), H(1), H(2))

wf_sim = WavefunctionSimulator()
wavefunction = wf_sim.wavefunction(state_prep + hadamards_left + U_f + hadamards_right)
print(wavefunction)

# # one way of declaring program:
# p = Program()
# ro = p.declare('ro', 'BIT', 3)
# p += H(0)
# p += H(1)
# p += H(2)
# p += X(3)
# p += H(3)
# p += CNOT(1, 3)
# p += MEASURE(0, ro[0])
# p += MEASURE(1, ro[1])
# p += MEASURE(2, ro[2])
#
# print(p)
# # multiple trials
# p.wrap_in_numshots_loop(5)
#
# with local_qvm():
#     # one way of measuring:
#     executable = qvm.compile(p)
#     result = qvm.run(executable)
#     print(result)
#
#     # another way of measuring:
# #     results = qvm.run_and_measure(p, trials=10)
# #     print(results[0])
# #     print(results[1])
