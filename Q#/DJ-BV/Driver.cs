using System;
using System.Collections;
using System.Linq;
using System.Diagnostics;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace DJ_BV
{
    class Driver
    {
        static void Main(string[] args)
        {
            const int ITER = 10000;
            const int MAX_N = 10;
            
            using (var qsim = new QuantumSimulator())
            {
                // Runs of DJ circuits
                DJ_bal_odd(qsim, MAX_N, ITER);
                DJ_bal_Kth_ref(qsim, MAX_N, ITER);
                DJ_const_zero(qsim, MAX_N, ITER);
                DJ_const_one(qsim, MAX_N, ITER);
            }
        }
        // Runs DJ circuit with balanced Uf based on odd number of ones in input
        // Inputs:
        //      1) QuantumSimulator to run on
        //      2) max size of n to run
        //      3) number of iterations to average for timing
        static void DJ_bal_odd(QuantumSimulator qsim, int MAX_N, int ITER)
        {
            Console.WriteLine("DJ Balanced Uf=ODD_ONES");
            // First call to simulator takes longer for setup
            // This call is to initialize before timing the rest
            var setup = DJ_balanced_odd.Run(qsim, 2).Result;
            long[] times = new long[MAX_N];
            
            // Loops through different n-values
            for (int n=1; n<=MAX_N; n++)
            {
                bool result = true;
                long[] tempTimes = new long[ITER];
                for (int i=0; i < ITER; i++)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    result = DJ_balanced_odd.Run(qsim, n).Result;
                    // Balanced f must always be false
                    Debug.Assert(!result);
                    watch.Stop();
                    tempTimes[i] = watch.ElapsedTicks;
                }
                times[n-1] = (long)tempTimes.Average();
                Console.WriteLine($"n={n}");
                Console.WriteLine($"Result: {result}");
                Console.WriteLine($"clock cycles: {times[n-1]}");
            }
            // Prints all average times for 1...MAX_N
            Console.WriteLine("["+string.Join(", ", times)+"]\n");
        }
        // Runs DJ circuit with balanced Uf on a reference bit, k
        // Inputs:
        //      1) QuantumSimulator to run on
        //      2) max size of n to run
        //      3) number of iterations to average for timing
        static void DJ_bal_Kth_ref(QuantumSimulator qsim, int MAX_N, int ITER)
        {
            Console.WriteLine("DJ Balanced Uf=Kth_REF");
            // First call to simulator takes longer for setup
            // This call is to initialize before timing the rest
            var setup = DJ_balanced_Kth_ref.Run(qsim, 2).Result;
            long[] times = new long[MAX_N];

            for (int n=1; n<=MAX_N; n++)
            {
                bool result = true;
                long[] tempTimes = new long[ITER];
                for (int i=0; i < ITER; i++)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    result = DJ_balanced_Kth_ref.Run(qsim, n).Result;
                    // Balanced f must always be false
                    Debug.Assert(!result);
                    watch.Stop();
                    tempTimes[i] = watch.ElapsedTicks;
                }
                times[n-1] = (long)tempTimes.Average();
                Console.WriteLine($"n={n}");
                Console.WriteLine($"Result: {result}");
                Console.WriteLine($"clock cycles: {times[n-1]}");
            }
            // Prints all average times for 1...MAX_N
            Console.WriteLine("["+string.Join(", ", times)+"]\n");
        }
        // Runs DJ circuit with constant Uf based f(x) = 0
        // Inputs:
        //      1) QuantumSimulator to run on
        //      2) max size of n to run
        //      3) number of iterations to average for timing
        static void DJ_const_zero(QuantumSimulator qsim, int MAX_N, int ITER)
        {
            Console.WriteLine("DJ Constant Uf=ZERO");
            // First call to simulator takes longer for setup
            // This call is to initialize before timing the rest
            var setup = DJ_constant_zero.Run(qsim, 2).Result;
            long[] times = new long[MAX_N];

            for (int n=1; n<=MAX_N; n++)
            {
                bool result = false;
                long[] tempTimes = new long[ITER];
                for (int i=0; i < ITER; i++)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    result = DJ_constant_zero.Run(qsim, n).Result;
                    // Constant f must always be true
                    Debug.Assert(result);
                    watch.Stop();
                    tempTimes[i] = watch.ElapsedTicks;
                }
                times[n-1] = (long)tempTimes.Average();
                Console.WriteLine($"n={n}");
                Console.WriteLine($"Result: {result}");
                Console.WriteLine($"clock cycles: {times[n-1]}");
            }
            // Prints all average times for 1...MAX_N
            Console.WriteLine("["+string.Join(", ", times)+"]\n");
        }
        // Runs DJ circuit with constant Uf based f(x) = 1
        // Inputs:
        //      1) QuantumSimulator to run on
        //      2) max size of n to run
        //      3) number of iterations to average for timing
        static void DJ_const_one(QuantumSimulator qsim, int MAX_N, int ITER)
        {
            Console.WriteLine("DJ Constant Uf=ZERO");
            // First call to simulator takes longer for setup
            // This call is to initialize before timing the rest
            var setup = DJ_constant_one.Run(qsim, 2).Result;
            long[] times = new long[MAX_N];

            for (int n=1; n<=MAX_N; n++)
            {
                bool result = false;
                long[] tempTimes = new long[ITER];
                for (int i=0; i < ITER; i++)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    result = DJ_constant_one.Run(qsim, n).Result;
                    // Constant f must always be true
                    Debug.Assert(result);
                    watch.Stop();
                    tempTimes[i] = watch.ElapsedTicks;
                }
                times[n-1] = (long)tempTimes.Average();
                Console.WriteLine($"n={n}");
                Console.WriteLine($"Result: {result}");
                Console.WriteLine($"clock cycles: {times[n-1]}");
            }
            // Prints all average times for 1...MAX_N
            Console.WriteLine("["+string.Join(", ", times)+"]\n");
        }
    }
}