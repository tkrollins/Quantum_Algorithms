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
            const int ITER = 1000;
            const int MAX_N = 10;

            using (var qsim = new QuantumSimulator())
            {
                var setup = DJ_balanced.Run(qsim, 2).Result;
                long[] times = new long[MAX_N];

                for (int n=1; n<=MAX_N; n++)
                {
                    // Make a long array to hold bits of a:
                    long a = (long)Math.Pow(2, n-1)-1;
                    string s = Convert.ToString(a, 2); //Convert to binary in a string
                    var a_list = s.Select(c => long.Parse(c.ToString())) // convert each char to int
                                  .ToList(); // Convert IEnumerable from select to Array
                    int length = a_list.Count;
                    for (int i=0; i < (n - length); i++) {
                        a_list.Insert(0, 0);
                    }
                    long[] a_bits = a_list.ToArray();
                    // let a_bits = IntAsBoolArray(a, n);

                    // Make a long to hold value of b:
                    const int b = 1;

                    long[] tempTimes = new long[ITER];
                    int mistakes = 0;
                    for (int i=0; i < ITER; i++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();

                        // pass in n, a_bits, and b into the BV operation:
                        var r = BV_custom.Run(qsim, n, new QArray<long>(a_bits), b).Result;
                        watch.Stop();
                        tempTimes[i] = watch.ElapsedTicks;

                        // measure mistakes from the qvm:
                        for (int j=0; j<n; j++) {
                            if (r[j] != a_bits[j]) {
                                mistakes += 1;
                                break;
                            }
                        }
                    }
                    times[n-1] = (long)tempTimes.Average();
                    Console.WriteLine($"clock cycles for n={n}: {times[n-1]} --- mistakes: {mistakes} out of {ITER}");
                }
                Console.WriteLine("["+string.Join(", ", times)+"]");
            }
        }
    }
}