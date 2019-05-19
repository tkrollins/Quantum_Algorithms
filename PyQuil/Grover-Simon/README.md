## Instructions for running Simon's and Grover's algorithms

### Simon
```simon.py``` is the script used run Simon's algorithm on a given 
oracle function (f).  To use this script, you need to type out f as a list of lists. 

The outer list will consist of 2^n inner lists, where n is then number of input bits. 
Each inner list will be 2n in length. 
The first n elements will be the input bitstring to f, and the final element will be 
the resulting output. 

Example:

    f = [[0,0, 0,0], [0,1, 1,1], [1,0, 1,1], [1,1, 0,0]]
    
    Here n = 2 and and s = [1,1].
    f must have a valid s value, or the algorithm will fail.

Once you have your f ready, all that is necessary is to call ```run_Simon(f, naive=False)```.
This function will run Simon's on f, naive=True will use an naive solver to find s.  False will 
use matrix null_space method; naive defaults to False.  This function will print out the non-0 
value for s.

Currently there are 3 calls to run_Simon() present at the end of the script. 
You can add your call after these or simply delete them.

### Grover

```grover.py``` is the script used run the Grover algorithm on a given function. 
To use this script, you will need to define the integers n and k. 

The variable n is used to represent the number of input bits. The variable k is used 
to represent the value of x where ```f(x)=1```. It is assumed that in all other cases of 
f, ```f(x)=0```. 

Simply pass these values into ```run_grover(n, k)``` and it will create the circuit, 
compile the program, and run it on a qvm. The function takes the following 
extra parameters:
 
    numshots: governs how many times the simulation will run.
    sim_wave: when True, will provide the probabilities from the Wavefunction Simulator instead of running the simulation using a qvm.
    print_p: when True, will print the Quil code for debugging.
    use_aspen: when True, will set the qvm to use the Aspen QPC instead of the default QPC. 

The result and execution time is returned by this function. 
You may add your calls to run_grover() at the end of the main() function.