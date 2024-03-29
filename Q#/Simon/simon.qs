// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

//////////////////////////////////////////////////////////////////////
// This file contains reference solutions to all tasks.
// The tasks themselves can be found in Tasks.qs file.
// We recommend that you try to solve the tasks yourself first,
// but feel free to look up the solution if you get stuck.
//////////////////////////////////////////////////////////////////////

namespace Simon {
    
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Diagnostics;
    
    
    //////////////////////////////////////////////////////////////////
    // Part I. Oracles
    //////////////////////////////////////////////////////////////////
    
    // Task 1.1. f(x) = x₀ ⊕ ... ⊕ xₙ₋₁ (parity of the number of bits set to 1)
    operation Oracle_CountBits_Reference (x : Qubit[], y : Qubit) : Unit
    is Adj {
        
        let N = Length(x);

        for (i in 0 .. N - 1) {
            CNOT(x[i], y);
        }
    }
    
    
    // Task 1.2. Bitwise right shift
    operation Oracle_BitwiseRightShift_Reference (x : Qubit[], y : Qubit[]) : Unit
    is Adj {
        
        let N = Length(x);

        for (i in 1 .. N - 1) {
            CNOT(x[i - 1], y[i]);
        }
    }
    
    
    // Task 1.3. Linear operator
    operation Oracle_OperatorOutput_Reference (x : Qubit[], y : Qubit, A : Int[]) : Unit
    is Adj {
        
        let N = Length(x);
            
        for (i in 0 .. N - 1) {
            if (A[i] == 1) {
                CNOT(x[i], y);
            }
        }
    }
    
    
    // Task 1.4. Multidimensional linear operator
    operation Oracle_MultidimensionalOperatorOutput_Reference (x : Qubit[], y : Qubit[], A : Int[][]) : Unit
    is Adj {
        
        let N1 = Length(y);
        let N2 = Length(x);
            
        for (i in 0 .. N1 - 1) {
            for (j in 0 .. N2 - 1) {
                if ((A[i])[j] == 1) {
                    CNOT(x[j], y[i]);
                }
            }
        }
    }
    
    
    //////////////////////////////////////////////////////////////////
    // Part II. Simon's Algorithm
    //////////////////////////////////////////////////////////////////
    
    // Task 2.1. State preparation for Simon's algorithm
    operation SA_StatePrep_Reference (query : Qubit[]) : Unit
    is Adj {        
        ApplyToEachA(H, query);
    }
    
    
    // Task 2.2. Quantum part of Simon's algorithm
    operation Simon_Algorithm_Reference (N : Int, Uf : ((Qubit[], Qubit[]) => Unit)) : Int[] {
                
        // allocate input and answer registers with N qubits each
        using ((x, y) = (Qubit[N], Qubit[N])) {
            // prepare qubits in the right state
            SA_StatePrep_Reference(x);
            
            // apply oracle
            Uf(x, y);
            
            // apply Hadamard to each qubit of the input register
            ApplyToEach(H, x);
            
            // measure all qubits of the input register;
            // the result of each measurement is converted to an Int
            mutable j = new Int[N];
            for (i in 0 .. N - 1) {
                if (M(x[i]) == One) {
                    set j w/= i <- 1;
                }
            }
            
            // before releasing the qubits make sure they are all in |0⟩ states
            ResetAll(x);
            ResetAll(y);
            return j;
        }
    }
    // Creates DJ circuit with balanced Uf based right bit shift of input
    // Inputs:
    //      1) the number of qubits in the input register N for the function f
    operation Simon_Bitwise_Shift(N : Int) : Int[]
    {
        return Simon_Algorithm_Reference(N, Oracle_BitwiseRightShift_Reference);
    }

    // Creates DJ circuit with balanced Uf based multi-dimensional operator on input
    // Inputs:
    //      1) the number of qubits in the input register N for the function f
    //      2) The operator to use on input
    operation Simon_Multi(N : Int, A : Int[][]) : Int[]
    {
        return Simon_Algorithm_Reference(N, Oracle_MultidimensionalOperatorOutput_Reference(_,_,A));
    }

    // Test that qubits are automatically returned to inital state at the end of "using".
    // Spoiler: they aren't.  You must call ResetAll() manually
    operation Test_Qubit_Reset() : Int
    {
        using (test_qubits = Qubit[3])
        {
            AssertAllZero(test_qubits);
            Message("All qubits started in Zero state");
            ApplyToEach(X, test_qubits);
            AssertQubit(One, test_qubits[0]);
            AssertQubit(One, test_qubits[1]);
            AssertQubit(One, test_qubits[2]);
            Message("All qubits now in One state");

            // Will throw an exception here.
            // Qubits were not reset manually.
        }

        using (test_qubits_after = Qubit[3])
        {
            Message("Qubits re-aquired");
            if ( (M(test_qubits_after[0]) == One) or
                 (M(test_qubits_after[1]) == One) or
                 (M(test_qubits_after[2]) == One) )
                 {
                    Message("Qubits not returned to Zero state");
                    return 0;
                 }
        }
        Message("All qubits returned to Zero state.");
        return 1;
    }
    
}