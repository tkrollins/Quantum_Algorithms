using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace DJ_BV
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                var temp = DJ_balanced.Run(qsim, 2).Result;
                for (int i=1; i<10; i++)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    var r = DJ_balanced.Run(qsim, i).Result;
                    watch.Stop();
                    long time = watch.ElapsedTicks;
                    Console.WriteLine($"Elapsed: {time}");
                }
            }
        }
    }
}