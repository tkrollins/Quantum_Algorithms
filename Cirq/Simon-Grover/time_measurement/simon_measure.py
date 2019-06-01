from simon import *
import matplotlib.pyplot as plt

def main():
    plt.style.use('seaborn-darkgrid')

    times = []
    n = [1, 2, 3, 4]

    f_n = [f_1, f_2, f_3, f_4]

    for f in f_n:
        _, return_time = run_Simon(f)
        times.append(return_time)


    plt.figure()
    plt.plot(n, times, label='Balanced')
    plt.xticks(n)
    plt.xlabel('Input Bits')
    plt.ylabel('Run Time (s)')
    plt.tight_layout()
    plt.savefig('Cirq_simon_runtime.png')
    plt.show()


if __name__ == '__main__':
    main()