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
    for n in [2, 3, 4, 5, 6, 7, 8, 9]:
        # run 100 times and average:
        runs_complex = []
        runs_simple = []
        for _ in range(100):
            _, return_time = run_grover(n, k, numshots=25)
            runs_complex.append(return_time)

            _, return_time = run_grover(n, k=(2**n)-1, numshots=25)
            runs_simple.append(return_time)

        complex_times.append([n, np.average(runs_complex)])
        simple_times.append([n, np.average(runs_simple)])

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
