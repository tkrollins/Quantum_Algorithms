import matplotlib.pyplot as plt

def main():
    plt.style.use('seaborn-darkgrid')

    n = [i for i in range(1, 11)]

    complex_times = [2315, 3235, 4706, 4582, 4888, 4454, 10759, 9652, 10807, 11678]
    simple_times = [1834, 2787, 4182, 4284, 4649, 4876, 14655, 7662, 8475, 9127]

    plt.figure()
    plt.plot(n, complex_times, label='k=0')
    plt.plot(n, simple_times, label='k=[all ones]')
    plt.legend()
    plt.xticks(n)
    plt.xlabel('Input Bits')
    plt.ylabel('Run Time (clock cycles)')
    plt.tight_layout()
    plt.savefig('Q#_Grover_runtime.png')
    plt.show()


if __name__ == '__main__':
    main()
