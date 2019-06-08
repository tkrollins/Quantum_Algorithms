import matplotlib.pyplot as plt

def main():
    plt.style.use('seaborn-darkgrid')

    n = [i for i in range(1, 11)]

    complex_times = [2241, 3018, 4280, 3955, 4317, 4330, 10055, 9059, 9958, 11237]
    simple_times = [2156, 2991, 3889, 3597, 4045, 4406, 13080, 7199, 7873, 8774]

    plt.figure()
    plt.plot(n, complex_times, label='k=0')
    plt.plot(n, simple_times, label='k=[all ones]')
    plt.legend()
    plt.xticks(n)
    plt.xlabel('Input Bits')
    plt.ylabel('Run Time (clock cycles)')
    plt.tight_layout()
    plt.savefig('Q#_Grover_runtime_100K.png')
    plt.show()


if __name__ == '__main__':
    main()
