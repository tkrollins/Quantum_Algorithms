import matplotlib.pyplot as plt
import numpy as np

import sys
sys.path.insert(0, '..\\')

from grover import run_grover

def main():
    plt.style.use('seaborn-darkgrid')

    complex_times = []
    simple_times = []
    k = 0
    for n in [2, 3, 4, 5, 6]:
        _, return_time = run_grover(n, k, numshots=25, sim_wave=False, use_aspen=True)
        complex_times.append([n, return_time])

        _, return_time = run_grover(n, k=(2**n)-1, numshots=25, sim_wave=False, use_aspen=True)
        simple_times.append([n, return_time])

    complex_times = np.array(complex_times)
    simple_times = np.array(simple_times)

    plt.figure()
    plt.plot(complex_times[:, 0], complex_times[:, 1], label='k={}'.format(k))
    plt.plot(simple_times[:, 0], simple_times[:, 1], label='k=[all ones]')
    plt.legend()
    plt.xlabel('Input Bits')
    plt.ylabel('Run Time (s)')
    plt.show()


if __name__ == '__main__':
    main()
