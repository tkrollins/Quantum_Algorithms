using System;
using System.Collections;
using System.Linq;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace DJ_BV
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
                    long[] tempTimes = new long[ITER];
                    for (int i=0; i < ITER; i++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        var r = DJ_balanced.Run(qsim, n).Result;
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