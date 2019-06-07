import matplotlib.pyplot as plt

def main():
    plt.style.use('seaborn-darkgrid')

    bal_times = []
    const_times = []
    n = [i for i in range(1, 11)]

    bal_odd = [422003, 712227, 1043895, 1249581, 1513813, 1787514, 2061151, 2355860, 2714343, 3117537]
    bal_Kth = [423210, 650172, 1005989, 1181451, 1423393, 1789249, 1877628, 2176813, 2452416, 3176319]
    const_zero = [525826, 612255, 877737, 1186489, 1480082, 1545100, 1766389, 2054290, 2323030, 2738597]
    const_one = [401059, 715347, 964327, 1406314, 1361564, 1607494, 1975720, 2592073, 3564355, 3363665]

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