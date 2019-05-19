## Instructions for running the Deutsch-Jozsa and Bernstein-Vazirani algorithms

### Simon


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