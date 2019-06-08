using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Grover
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
                var setup = Grover_custom.Run(qsim, 2, new QArray<bool>(new bool[2]), 1).Result;

                // iterate over all n...
                for (int n=1; n<=MAX_N; n++)
                {
                    // Choose a k value, where f(x == k)=1 and f(x != k)=0 for all x
                    long k = (long) Math.Pow(2, n)-1;
                    
                    // Calculate number of iterations necessary:
                    int grover_repeats = (int) Math.Floor(Math.PI / (4 * Math.Asin(1 / Math.Sqrt(n))));
                    if (grover_repeats == 0) {
                        grover_repeats = 1;
                    }

                    // Run the experiment and get average time back
                    times[n-1] = run_grover(qsim, n, ITER, k, grover_repeats);
                }
                Console.WriteLine("Times: ["+string.Join(", ", times)+"]");
            }
        }

        // Runs Grover circuit with a given k for f( x == k )=1
        // Inputs:
        //      1) qsim: QuantumSimulator to run on
        //      2) n: the number of inputs qubits
        //      3) ITER: number of iterations to average for timing
        //      4) k: where f(x == k)=1 and f(x != k)=0 for all x
        //      5) grover_repeats: number of times we will repeat grover
        //      Prints the average time for completion and the number of mistakes from qsim
        //      Returns the average time for completion
        static long run_grover(QuantumSimulator qsim, int n, int ITER, long k, int grover_repeats)
        {
            /////////////////////////////////////////////////////////////////////////////////
            // Make the bit pattern, using k:
            string s = Convert.ToString(k, 2); //Convert to binary in a string
            var parsed = s.Select(c => long.Parse(c.ToString())) // Convert each char to long
                          .ToArray(); // Convert IEnumerable from select to Array

            List<bool> p_list = new List<bool>();
            for (int i=0; i < parsed.Length; i++) {
                p_list.Add(parsed[i] > 0);
            }

            // Pad with extra zeros if necessary
            int length = p_list.Count;
            for (int i=0; i < (n - length); i++) {
                p_list.Insert(0, false);
            }
            bool[] pattern = p_list.ToArray();

            /////////////////////////////////////////////////////////////////////////////////
            // Store the times and mistakes from each run
            long[] tempTimes = new long[ITER];
            int correct = 0;

            /////////////////////////////////////////////////////////////////////////////////
            // Perform the runs:
            for (int i=0; i < ITER; i++)
            {
                // start timer:
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // pass in n, bit pattern, and grover_repeats into the Grover operation:
                var r = Grover_custom.Run(qsim, n, new QArray<bool>(pattern), grover_repeats).Result;
                watch.Stop();

                // record the timed run:
                tempTimes[i] = watch.ElapsedTicks;
                //Console.WriteLine(string.Join(", ", r));

                // measure correctness from the output (output should match the pattern we sent in):
                bool mistake = false;
                for (int j=0; j<n; j++) {
                    if ((r[j] == 1) != pattern[j]) {
                        mistake = true;
                        break;
                    }
                }
                if (!mistake) {
                    correct += 1;
                }
            }

            /////////////////////////////////////////////////////////////////////////////////
            // Print statistics and return average time:
            long average = (long)tempTimes.Average();
            Console.WriteLine($"clock cycles for n={n}: {average} --- correct: {correct} out of {ITER}");

            // return average time spent
            return average;
        }
    }
}