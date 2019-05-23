import cirq

# define the length of the grid.
length = 3
# define qubits on the grid.
# qubits = [cirq.GridQubit(i, j) for i in range(length) for j in range(length)]
qubits = cirq.LineQubit.range(length)
print(qubits)
# prints
# [cirq.GridQubit(0, 0), cirq.GridQubit(0, 1), cirq.GridQubit(0, 2), cirq.GridQubit(1, 0), cirq.GridQubit(1, 1), cirq.GridQubit(1, 2), cirq.GridQubit(2, 0), cirq.GridQubit(2, 1), cirq.GridQubit(2, 2)]

# circuit = cirq.Circuit()
# circuit.append(cirq.H(q) for i, q in enumerate(qubits) if i % 2 == 0)
# circuit.append(cirq.X(q) for i, q in enumerate(qubits) if i % 2 == 1)
# circuit.append(cirq.I(q) for i, q in enumerate(qubits))
# print(circuit)

def test1(qubits):
    for i in range(len(qubits)):
        a = qubits[i]
        if i % 2 == 0:
            yield test2(a)

    for i in range(len(qubits)):
        a = qubits[i]
        if i % 1 == 0:
            yield test3(a)

def test2(a):
    yield cirq.X(a)

def test3(a):
    yield cirq.Z(a)

circuit = cirq.Circuit().from_ops(test1(qubits))
print(circuit)