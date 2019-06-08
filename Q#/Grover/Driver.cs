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
            const int ITER = 100000;
            const int MAX_N = 10;

            using (var qsim = new QuantumSimulator())
            {
                var setup = Grover_custom.Run(qsim, 2, new QArray<bool>(new bool[2]), 1).Result;
                long[] times = new long[MAX_N];

                for (int n=1; n<=MAX_N; n++)
                {
                    // Make the pattern:
                    long a = (long) Math.Pow(2, n)-1;
                    string s = Convert.ToString(a, 2); //Convert to binary in a string
                    var parsed = s.Select(c => long.Parse(c.ToString())) // convert each char to long
                                  .ToArray(); // Convert IEnumerable from select to Array

                    List<bool> p_list = new List<bool>();
                    for (int i=0; i < parsed.Length; i++) {
                        p_list.Add(parsed[i] > 0);
                    }

                    int length = p_list.Count;
                    for (int i=0; i < (n - length); i++) {
                        p_list.Insert(0, false);
                    }
                    bool[] pattern = p_list.ToArray();
                    //Console.WriteLine("Pattern: " + string.Join(", ", pattern));

                    // Set iterations:
                    //np.pi / (4 * np.arcsin(1 / np.sqrt(n))) - 0.5
                    int iterations = (int) Math.Floor(Math.PI / (4 * Math.Asin(1 / Math.Sqrt(n))));
                    if (iterations == 0) {
                        iterations = 1;
                    }
                    //Console.WriteLine($"iterations: {iterations}");

                    long[] tempTimes = new long[ITER];
                    int correct = 0;
                    for (int i=0; i < ITER; i++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();

                        // pass in n, a_bits, and b into the BV operation:
                        var r = Grover_custom.Run(qsim, n, new QArray<bool>(pattern), iterations).Result;
                        watch.Stop();
                        tempTimes[i] = watch.ElapsedTicks;
                        //Console.WriteLine(string.Join(", ", r));

                        // measure correctness from the qvm:
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
                    times[n-1] = (long)tempTimes.Average();
                    Console.WriteLine($"clock cycles for n={n}: {times[n-1]} --- correct: {correct} out of {ITER}");
                }
                Console.WriteLine("["+string.Join(", ", times)+"]");
            }
        }
    }
}