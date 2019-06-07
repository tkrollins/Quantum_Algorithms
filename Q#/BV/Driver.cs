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
            const int ITER = 100;
            const int MAX_N = 10;

            using (var qsim = new QuantumSimulator())
            {
                var setup = DJ_balanced.Run(qsim, 2).Result;
                long[] times = new long[MAX_N];

                for (int n=1; n<=MAX_N; n++)
                {
                    // Make a and b for this n:
                    const int a = 5;
                    string s = Convert.ToString(a, 2); //Convert to binary in a string
                    int[] a_bits = s.PadLeft(n, '0') // Add 0's from left
                                    .Select(c => int.Parse(c.ToString())) // convert each char to int
                                    .ToArray(); // Convert IEnumerable from select to Array
                    Console.WriteLine($"a bits: {a_bits}");
                    const int b = 1;

                    int[] vars = new int[1 + n + 1];
                    vars[0] = n;
                    for (int z = 0; z < n; z++) {
                        vars[z+1] = a_bits[z];
                    }
                    vars[n+1] = b;

                    long[] tempTimes = new long[ITER];
                    for (int i=0; i < ITER; i++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();

                        var r = BV_custom.Run(qsim, vars).Result;
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