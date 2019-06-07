import matplotlib.pyplot as plt

def main():
    plt.style.use('seaborn-darkgrid')

    n = [i for i in range(1, 11)]

    complex_times = [928, 1417, 1706, 2924, 3756, 3724, 3870, 3226, 3268, 4060]
    simple_times = [951, 1290, 1390, 1755, 2413, 2674, 3161, 4105, 4037, 3451]

    plt.figure()
    plt.plot(n, complex_times, label='a != 0, b = 0')
    plt.plot(n, simple_times, label='a = 0, b = 1')
    plt.legend()
    plt.xticks(n)
    plt.xlabel('Input Bits')
    plt.ylabel('Run Time (clock cycles)')
    plt.tight_layout()
    plt.savefig('Q#_BV_runtime.png')
    plt.show()


if __name__ == '__main__':
    main()
