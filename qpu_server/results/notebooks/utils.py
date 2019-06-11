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
