import matplotlib.pyplot as plt

def main():
    plt.style.use('seaborn-darkgrid')

    bal_times = []
    const_times = []
    n = [i for i in range(1, 11)]

    bitshift = [364817, 758787, 1207664, 1634673, 2016849, 2864943, 4636028, 12359077, 45403407, 243055127]
    multi = [393746, 836877, 1199996, 2010215, 2401572, 3388352, 5481121, 15997093, 58660739, 313207628]

    plt.figure()
    plt.plot(n, bitshift, label='Bitshift Uf')
    plt.plot(n, multi, label='Multi-Dimensional Operator Uf')
    plt.legend()
    plt.xticks(n)
    plt.xlabel('Input Bits')
    plt.ylabel('Run Time (clock cycles)')
    plt.tight_layout()
    plt.savefig('Q#_simon_runtime.png')
    plt.show()


if __name__ == '__main__':
    main()