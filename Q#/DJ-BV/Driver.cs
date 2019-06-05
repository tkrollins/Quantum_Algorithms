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
                var r = DJ.Run(qsim, 3).Result;
                Console.WriteLine($"Measured: {r}");
            }
        }
    }
}