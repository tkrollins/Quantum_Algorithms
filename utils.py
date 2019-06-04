from numpy import array


def getResultsArray(resultsDict, n):
    qubits = [0, 1, 2, 7, 14, 15]
    qubits = qubits[:n]
    results = array([resultsDict[i] for i in qubits])
    return results.transpose()
