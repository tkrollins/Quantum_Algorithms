import cirq

a = cirq.NamedQubit("a")    # if we were creating a circuit for the Bristlecone device we would use cirq.GridQubit(5, 0)
b = cirq.NamedQubit("b")    # to refer to the qubit in the left-most position in the Bristlecone
c = cirq.NamedQubit("c")

# building a circuit with from_ops (1):
# basic circuit... 'PyQuil themed'
ops = [cirq.H(a), cirq.H(b), cirq.CNOT(b, c), cirq.H(b)]
circuit = cirq.Circuit.from_ops(ops)
print(circuit)
print()

# print unitary matrix
print(cirq.unitary(cirq.H))
print()

# print each 'moment' (organized in time-slices/layers/columns)
for i, moment in enumerate(circuit):
    print(moment)
print()

# print moment another way (internal representation of the circuit)
print(repr(circuit))
print()

# this can be used to simulate a line of named qubits (like in PyQuil)
line = cirq.LineQubit.range(5)

# yield: is a lazy list comprehension... it won't generate all the values right away, like in list comprehension


