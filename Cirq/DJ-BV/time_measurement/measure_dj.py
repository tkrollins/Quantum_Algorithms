from deutsch_jozsa import *
import matplotlib.pyplot as plt

def main():
    plt.style.use('seaborn-darkgrid')

    bal_times = []
    const_times = []
    n = [1, 2, 3, 4, 5]

    f_balanced = [f_bal_1, f_bal_2, f_bal_3, f_bal_4, f_bal_5]
    f_constant = [f_const_1_0, f_const_2_0, f_const_3_0, f_const_4_0, f_const_5_0]

    for f_bal, f_const in zip(f_balanced, f_constant):
        _, return_time = run_DJ(f_bal)
        bal_times.append(return_time)

        _, return_time = run_DJ(f_const)
        const_times.append(return_time)

    plt.figure()
    plt.plot(n, bal_times, label='Balanced')
    plt.plot(n, const_times, label='Constant')
    plt.legend()
    plt.xticks(n)
    plt.xlabel('Input Bits')
    plt.ylabel('Run Time (s)')
    plt.tight_layout()
    plt.savefig('Cirq_DJ_runtime.png')
    plt.show()


if __name__ == '__main__':
    main()
