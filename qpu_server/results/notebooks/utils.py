import numpy as np


def getResultsArray(resultsDict, n, Aspen12Q=True):
    """
    Turns dict returned from QPU server into matrix.
    :param resultsDict: results dict from QPU server
    :param n: qubits measured
    :return: matrix with results. Each row is a single run.
    """

    qubits = [0, 1, 2, 6, 7, 10, 11, 13, 14, 15, 16, 17] if Aspen12Q else [0, 1, 2, 7, 14, 15]
    qubits = qubits[:n]
    results = np.array([resultsDict[i] for i in qubits])
    return results.transpose()

def compareResults(qvm, qpu):
    """
    Compares results between QVM and QPU runs.
    :param qvm: matrix of qvm results
    :param qpu: matrix of qpu results
    :return: fraction of equality
    """
    comp = np.equal(qvm, qpu)
    row_comp = np.array([row.all() for row in comp])
    row_comp_int = row_comp.astype(int)
    frac_equal = row_comp_int.sum() / len(row_comp_int)
    return frac_equal

def DJ_balancedResultsCorrectness(qpu_results):
    """
    Determines fraction of correct results from QPU for DJ.
    Correctness is any row that has at least a single 1.
    :param qpu_results: matrix of qpu results
    :return: fraction of correctness
    """
    correctness = qpu_results.astype(bool)
    correctness = np.array([row.any() for row in correctness])
    correctness = correctness.astype(int)
    frac_correct = correctness.sum() / len(correctness)
    return frac_correct

def DJ_constantResultsCorrectness(qpu_results):
    """
    Determines fraction of correct results from QPU for DJ.
    Correctness is any row that has all 0's.
    :param qpu_results: matrix of qpu results
    :return: fraction of correctness
    """
    correctness = np.invert(qpu_results.astype(bool))
    correctness = np.array([row.all() for row in correctness])
    correctness = correctness.astype(int)
    frac_correct = correctness.sum() / len(correctness)
    return frac_correct

def s_solver(y_set):
    """
    Naive solver for s given a set of y vectors.
    :param y_set: y vectors returned from quantum part of algorithm.   For every y, <y, s> = 0
    :return: A set of all valid s values in integer form. Does not include 0.
    """

    y_set = np.unique(y_set, axis=0)
    # number of bits in y/s
    n = len(y_set[0])

    if n > 1:
        # removes 0 vector
        y_set = np.delete(y_set, np.where(~y_set.any(axis=1))[0], axis=0)
    if len(y_set) > n-1 and n != 1:
        # remove one y so n-1 left
        y_set = y_set[:-1]
        
    # set of all currently valid s values
    s_set = set([s for s in range(1, 2 ** n)])
    for y in y_set:
        to_be_removed = set()
        for s in s_set:
            s_bin = np.array(list(f'{s:0{n}b}')).astype(int)
            # mod 2 dot product
            if np.dot(y, s_bin) % 2 != 0:
                # s values that do not satisfy <y, s> = 0
                to_be_removed.add(s)
        s_set = s_set.difference(to_be_removed)
    return s_set

def y_error(qvm, qpu):

    qvm = np.unique(qvm, axis=0)
    correct = 0
    for y1 in qpu:
        for y2 in qvm:
            if np.array_equal(y1, y2):
                correct += 1
                break
    return 1 - (correct / len(qpu))

def time_per_shot(shots20, shots25):
    return (shots25 - shots20) / 5


def get_error_rate(qvm, qpu):
    """
    Compares results between QVM and QPU runs.
    :param qvm: matrix of qvm results
    :param qpu: matrix of qpu results
    :return: fraction of error
    """
    errors = 0
    total_bits = (len(qvm) * len(qvm[0]))
    for run_qvm, run_qpu in zip(qvm, qpu):
        if not np.array_equal(run_qvm, run_qpu):
            for bit_qvm, bit_qpu in zip(run_qvm, run_qpu):
                errors += int(bit_qvm != bit_qpu)
    print(f'Errors: {errors}')
    print(f'Total Bits: {total_bits}')
    return errors / total_bits