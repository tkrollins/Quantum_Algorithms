import matplotlib.pyplot as plt

def main():
    plt.style.use('seaborn-darkgrid')

    n = [i for i in range(1, 11)]

    complex_times = [763, 1166, 1755, 2294, 2877, 3647, 3238, 3305, 3418, 3903]
    simple_times = [714, 1020, 1447, 1939, 2650, 3537, 3285, 3219, 3179, 3262]

    plt.figure()
    plt.plot(n, complex_times, label='a != 0, b = 0')
    plt.plot(n, simple_times, label='a = 0, b = 1')
    plt.legend()
    plt.xticks(n)
    plt.xlabel('Input Bits')
    plt.ylabel('Run Time (clock cycles)')
    plt.tight_layout()
    plt.savefig('Q#_BV_runtime_100K.png')
    plt.show()


if __name__ == '__main__':
    main()
