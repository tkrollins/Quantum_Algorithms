using System;
using System.Collections;
using System.Linq;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Grover
{
    class Driver
    {
        static void Main(string[] args)
        {
            const int ITER = 1000;
            const int MAX_N = 10;

            using (var qsim = new QuantumSimulator())
            {
                var setup = GroversSearch_Reference.Run(qsim).Result;
                long[] times = new long[MAX_N];

                for (int n=1; n<=MAX_N; n++)
                {
                    long[] tempTimes = new long[ITER];
                    for (int i=0; i < ITER; i++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();

                        // pass in n, a_bits, and b into the BV operation:
                        var r = GroversSearch_Reference.Run(qsim).Result;
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