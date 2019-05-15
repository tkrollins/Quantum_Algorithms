## Instructions for running the Deutsch-Jozsa and Bernstein-Vazirani algorithms

### Deutsch-Jozsa
```dj_experiment.py``` is the script used run the Deutsch-Jozsa algorithm on a given 
oracle function (f).  To use this script, you need to type out f as a list of lists. 

The outer list will consist of 2^n inner lists. Each inner list will be n+1 in length. 
The first n elements will be the input bitstring to f, and the final element will be 
the resulting output. 

Due to the use of helper bits in this implementation, ```n ≤ 5``` for any f. 

Example:

    f = [[0,0,0], [0,1,0], [1,0,1], [1,1,1]]
    
    Here n = 2 and f is a balanced function as half the outputs are 1.

Once you have your f ready, all that is necessary is to call ```run_DJ(f)```.
This function will run Deutsch-Jozsa on f 5 times, and will print the 5 results 
in an array.

Currently there are 3 calls to run_DJ() present at the end of the script. 
You can add your call after these or simply delete them.

### Bernstein-Vazirani

```bv_experiment.py``` is the script used run the Bernstein-Vazirani algorithm on a 
given function. To use this script, you will need to define the integers n, a, and b. 

The variable n is used to represent the number of input bits. The variables a and b 
are used to represent the function, ```f(x)=a*x+b```. Simply pass these values into 
```run_BV(n, a, b)``` and it will create the circuit, insert U_f, compile the program, 
and run it on a qvm. This function will run Bernstein-Vazirani on f 5 times, and will 
print the 5 results in an array. The results and execution time is returned by this 
function.

You may add your calls to ```run_BV()``` at the end of the ```main()``` function.