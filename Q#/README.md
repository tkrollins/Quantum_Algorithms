## Instructions for running the Deutsch-Jozsa, Bernstein-Vazirani, Simon, and Grover algorithms in Q#

### Deutsch-Jozsa
`DJ/DJ_Driver.cs` is the file used to run the Deutsch-Jozsa algorithm. 
Currently there are 4 functions called within `Main()`: `DJ_bal_odd()`, `DJ_bal_Kth_ref()`, 
`DJ_const_zero()`, and `DJ_const_one()`.  Each of these functions take the quantum simulator, 
a maximum n, and number of iterations as parameters. There are two `const int` declared, 
`ITER` and `MAX_N`, that are passed into all functions. They will run all values of n from 
`1...MAX_N`, `ITER` number of times each and then display the result and execution time for each n.

The balanced functions will have a result of false, while the constant functions will have a 
result of true.  You can edit the values of `ITER`/`MAX_N` to change the parameters of all functions 
at once, or edit each function’s parameters individually.

### Bernstein Vazirani
`BV/BV_Driver.cs` is the script used to run the Bernstein-Vazirani algorithm on a 
given function. To use this script, you will need to start a quantum simulator and define 
the integers `n`, `ITER`, `a`, and `b`. 

The quantum simulator object is created by using the following: 
    
    var qsim = new QuantumSimulator()
    
The variable `n` is used to represent the number of 
input bits. `ITER` is used to represent the number of times the simulation should be run 
for the given `n`. The variables `a` and `b` are used to represent the function, `f(x)=a*x+b`.
Simply pass these values into `run_bv(qsim, n, ITER, a, b)` and it will create the 
circuit, insert the correct U_f, compile the program, and simulate it using the Q# simulator.

The averaged execution time is returned by `run_bv()`, and the results are printed at the 
end of the function. You may add your calls to `run_bv()` at the end of the `Main()`
function. We suggest to perform a dry run of the simulator on a meaningless circuit 
in order to give the simulator time to warm up.

### Simon
`Simon/Simon_Driver.cs` is the file used to run the Simon algorithm. 
Currently there are 4 functions called within `Main()`: `time_simon_bitshift()`, 
`time_simon_multi()`, `run_simon_bitshift()`, and `Test_Qubit_Reset()`.  The first two 
functions are strictly for timing simon’s with different Uf implementation.  
Their parameters are: the quantum simulator object,  a maximum `n`, and number of iterations. 
There are two `const int` declared, `ITER` and `MAX_N`, that are passed into these 
functions. They will run all values of `n` from `1...MAX_N`, `ITER` number of times 
each and then display the execution time for each `n`.

After this there are two calls to `run_simon_bitshift()`.  One with `n=2`, and one 
with `n=3` as parameters.  This will display the resulting s for a 2 or 3 bit bitshift.
  Additional calls can be added to run other `n` values, or you can edit the existing calls.

Lastly there is quantum operation call that tests the qubit reset functionality.  
This can be removed if you like, it will always fail with Q#’s current settings.

### Grover
`Grover/Grover_Driver.cs` is the script used to run the Grover algorithm on a given function.
 To use this script, you will need to define the integers `n`, `k`, and `grover_repeats`.

The quantum simulator object is created by using the following: 
    
    var qsim = new QuantumSimulator()
    
The variable `n` is used to represent the 
number of input bits. `ITER` is used to represent the number of times the simulation 
should be run for the given `n`. The variable `k` is used to represent the value of x 
where `f(x)=1`. It is assumed that in all other cases of f, `f(x)=0`. The variable 
`grover_repeats` is used to tell circuit builder how many times the G subcircuit will be 
placed into the circuit. Simply pass these values into 
`run_grover(qsim, n, ITER, k, grover_repeats)` and it will create the circuit, 
compile the program, and run it on the Q#simulator.

The averaged execution time is returned by `run_grover()`, and the results are 
printed at the end of the function. You may add your calls to `run_grover()` at 
the end of the `Main()` function. We suggest to perform a dry run of the simulator 
on a meaningless circuit in order to give the simulator time to warm up.