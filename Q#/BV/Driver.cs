using System;
using System.Collections;
using System.Linq;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace BV
{
    class Driver
    {
        static void Main(string[] args)
        {
            // Run for ITER number of iterations per N - the higher the number, the more accurate the time measurement
            const int ITER = 1000;
            // Iteration for n=[1, 2, ... , MAX_N] qubits
            const int MAX_N = 10;

            // Start up quantum simulator
            using (var qsim = new QuantumSimulator())
            {
                // create array for storing the times
                long[] times = new long[MAX_N];

                // run the simulator once to give simulator time to spin up threads on CPU:
                var setup = BV_custom.Run(qsim, 2, new QArray<long>(new long[2]), 0).Result;

                // iterate over all n...
                for (int n=1; n<=MAX_N; n++)
                {
                    // Set a:
                    long a = (long) Math.Pow(2, n)-1;

                    // Set b:
                    int b = 0;

                    // Run the experiment and get average time back
                    times[n-1] = run_bv(qsim, n, ITER, a, b);
                }
                Console.WriteLine("Times: ["+string.Join(", ", times)+"]");
            }
        }

        // Runs BV circuit with a given a and b for f(x) = a*x + b
        // Inputs:
        //      1) qsim: QuantumSimulator to run on
        //      2) n: the number of inputs qubits
        //      3) ITER: number of iterations to average for timing
        //      4) a: a in f(x) = a*x + b
        //      5) b: b in f(x) = a*x + b
        //      Prints the average time for completion and the number of mistakes from qsim
        //      Returns the average time for completion
        static long run_bv(QuantumSimulator qsim, int n, int ITER, long a, int b)
        {
            /////////////////////////////////////////////////////////////////////////////////
            // Make a long array to hold bits of a:
            string s = Convert.ToString(a, 2); //Convert to binary in a string
            var a_list = s.Select(c => long.Parse(c.ToString())) // convert each char to int
                          .ToList(); // Convert IEnumerable from select to Array
            int length = a_list.Count;
            for (int i=0; i < (n - length); i++) {
                a_list.Insert(0, 0);
            }
            long[] a_bits = a_list.ToArray();

            /////////////////////////////////////////////////////////////////////////////////
            // Store the times and mistakes from each run
            long[] tempTimes = new long[ITER];
            int mistakes = 0;

            /////////////////////////////////////////////////////////////////////////////////
            // Perform the runs:
            for (int i=0; i < ITER; i++)
            {
                // start timer:
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // pass in n, a_bits, and b into the BV operation:
                var r = BV_custom.Run(qsim, n, new QArray<long>(a_bits), b).Result;
                watch.Stop();

                // record the timed run:
                tempTimes[i] = watch.ElapsedTicks;

                // measure mistakes from the output (output should match the a we sent in):
                for (int j=0; j<n; j++) {
                    if (r[j] != a_bits[j]) {
                        mistakes += 1;
                        break;
                    }
                }
            }

            /////////////////////////////////////////////////////////////////////////////////
            // Print statistics and return average time:
            long average = (long)tempTimes.Average();
            Console.WriteLine($"clock cycles for n={n}: {average} \t\t correct: {ITER - mistakes} out of {ITER}");

            // return average time spent
            return average;
        }
    }
}