﻿using System;
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
            const int ITER = 100;
            const int MAX_N = 10;

            using (var qsim = new QuantumSimulator())
            {
                var setup = DJ_balanced.Run(qsim, 2).Result;
                long[] times = new long[MAX_N];

                for (int n=1; n<=MAX_N; n++)
                {
                    // Make a and b for this n:
                    long a = (long)Math.Pow(2, n-1)-1;
                    Console.WriteLine(a);
                    string s = Convert.ToString(a, 2); //Convert to binary in a string
                    var a_list = s.Select(c => long.Parse(c.ToString())) // convert each char to int
                                  .ToList(); // Convert IEnumerable from select to Array
                    int length = a_list.Count;
                    for (int i=0; i < (n - length); i++) {
                        a_list.Insert(0, 0);
                    }
                    long[] a_bits = a_list.ToArray();
                    Console.WriteLine(string.Join(",", a_bits));
                    const int b = 1;

                    long[] tempTimes = new long[ITER];
                    for (int i=0; i < ITER; i++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();

                        var r = BV_custom.Run(qsim, n, new QArray<long>(a_bits), b).Result;
                        watch.Stop();
                        tempTimes[i] = watch.ElapsedTicks;
                    }
                    times[n-1] = (long)tempTimes.Average();
                    Console.WriteLine($"clock cycles for n={n}: {times[n-1]}");
                }
                Console.WriteLine("["+string.Join(", ", times)+"]");
            }
        }
    }
}