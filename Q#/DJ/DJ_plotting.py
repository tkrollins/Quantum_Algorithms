import matplotlib.pyplot as plt

def main():
    plt.style.use('seaborn-darkgrid')

    bal_times = []
    const_times = []
    n = [i for i in range(1, 11)]

    bal_odd = [425794, 677496, 1007879, 1258729, 1568100, 1833848, 2110819, 2341726, 2705616, 3160082]
    bal_Kth = [436697, 671647, 949145, 1177349, 1424955, 1637657, 1903965, 2161037, 2506776, 2763199]
    const_zero = [395678, 603338, 857601, 1135548, 1307360, 1559886, 1747322, 2037507, 2330218, 2761679]
    const_one = [411912, 647368, 910256, 1113541, 1368588, 1686432, 1857275, 2090605, 2304730, 2672598]

    plt.figure()
    plt.plot(n, bal_odd, label='Balanced Odd 1s')
    plt.plot(n, bal_Kth, label='Balanced Kth ref bit')
    plt.plot(n, const_zero, label='Constant 0')
    plt.plot(n, const_one, label='Constant 1')
    plt.legend()
    plt.xticks(n)
    plt.xlabel('Input Bits')
    plt.ylabel('Run Time (clock cycles)')
    plt.tight_layout()
    plt.savefig('Q#_DJ_runtime.png')
    plt.show()


if __name__ == '__main__':
    main()