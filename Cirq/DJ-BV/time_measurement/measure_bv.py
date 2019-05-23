import sys
sys.path.insert(0, '..\\')

from bernstein_vazirani import Bernstein_Vazirani
import cirq
import time
import numpy as np
import matplotlib.pyplot as plt


def run_bv(n, a, b):
    # setup the experiment
    bv = Bernstein_Vazirani(n)

    # start simulator
    simulator = cirq.Simulator()

    t = time.time()
    circuit = bv.build_circuit(a, b)
    result = simulator.run(circuit, repetitions=1)
    return_time = time.time() - t
    print(result)

    return result, return_time

def main():
    plt.style.use('seaborn-darkgrid')

    complex_times = []
    simple_times = []
    for n in [1, 2, 3, 4, 5, 6, 7, 8]:
        _, return_time = run_bv(n, a=(2**n)-1, b=0)
        complex_times.append([n, return_time])

        _, return_time = run_bv(n, a=0, b=1)
        simple_times.append([n, return_time])

    complex_times = np.array(complex_times)
    simple_times = np.array(simple_times)

    plt.figure()
    plt.plot(complex_times[:, 0], complex_times[:, 1], label='a != 0, b = 0')
    plt.plot(simple_times[:, 0], simple_times[:, 1], label='a = 0, b = 1')
    plt.legend()
    plt.xlabel('Input Bits')
    plt.ylabel('Run Time (s)')
    plt.show()


if __name__ == '__main__':
    main()
