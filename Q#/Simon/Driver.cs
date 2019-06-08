using System;
using System.Linq;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Simon
{
    class Driver
    {
        static void Main(string[] args)
        {
            const int ITER = 100;
            const int MAX_N = 10;

            using (var qsim = new QuantumSimulator())
            {
                // time_simon_bitshift(qsim, MAX_N, ITER);
                // time_simon_multi(qsim, MAX_N, ITER);
                run_simon_bitshift(qsim, 3);
            }
        }
        // Times Simon circuit with Uf based on bitshift
        // Inputs:
        //      1) QuantumSimulator to run on
        //      2) max size of n to run
        //      3) number of iterations to average for timing
        static void time_simon_bitshift(QuantumSimulator qsim, int MAX_N, int ITER)
        {
            Console.WriteLine("Simon Uf=BIT_SHIFT");
            // First call to simulator takes longer for setup
            // This call is to initialize before timing the rest
            var setup = Simon_Bitwise_Shift.Run(qsim, 2).Result;
            long[] times = new long[MAX_N];
            
            
            // Loops through different n-values
            for (int n=1; n<=MAX_N; n++)
            {
                long[] tempTimes = new long[ITER];
                for (int i=0; i < ITER; i++)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    var result = Simon_Bitwise_Shift.Run(qsim, n).Result;
                    // Balanced f must always be false
                    watch.Stop();
                    tempTimes[i] = watch.ElapsedTicks;
                }
                times[n-1] = (long)tempTimes.Average();
                Console.WriteLine($"n={n}");
                
                Console.WriteLine($"clock cycles: {times[n-1]}");
            }
            // Prints all average times for 1...MAX_N
            Console.WriteLine("["+string.Join(", ", times)+"]\n");
        }

        // Times Simon circuit with Uf based on bitshift
        // Inputs:
        //      1) QuantumSimulator to run on
        //      2) max size of n to run
        //      3) number of iterations to average for timing
        static void time_simon_multi(QuantumSimulator qsim, int MAX_N, int ITER)
        {
            Console.WriteLine("Simon Uf=MULTI");
            // First call to simulator takes longer for setup
            // This call is to initialize before timing the rest
            var setup = Simon_Multi.Run(qsim, 2, build_A(2)).Result;
            long[] times = new long[MAX_N];
            
            
            // Loops through different n-values
            for (int n=1; n<=MAX_N; n++)
            {
                var A = build_A(n);
                long[] tempTimes = new long[ITER];
                for (int i=0; i < ITER; i++)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    var result = Simon_Multi.Run(qsim, n, A).Result;
                    // Balanced f must always be false
                    watch.Stop();
                    tempTimes[i] = watch.ElapsedTicks;
                }
                times[n-1] = (long)tempTimes.Average();
                Console.WriteLine($"n={n}");
                
                Console.WriteLine($"clock cycles: {times[n-1]}");
            }
            // Prints all average times for 1...MAX_N
            Console.WriteLine("["+string.Join(", ", times)+"]\n");
        }
        
        // Builds a Int[][] to pass into the Multi-dimensional operator
        // version of Uf
        static QArray<QArray<long>> build_A(int n)
        {
            
            List<QArray<long>> temp_A = new List<QArray<long>>();

            for (int i=0; i<n; i++)
            {
                List<long> A_list = new List<long>();
                for (int j=0; j<n; j++)
                {
                    A_list.Add((long)j%2);
                }
                var A_vector = new QArray<long>(A_list);
                temp_A.Add(A_vector);
            }
            var A = new QArray<QArray<long>>(temp_A);
            
            return A;
        }
        // Runs Simon circuit with Uf based on bitshift
            // Inputs:
            //      1) QuantumSimulator to run on
            //      2) max size of n to run
            //      3) number of iterations to average for timing
            //      Returns boolean array for s
        static void run_simon_bitshift(QuantumSimulator qsim, int N)
        {
            var saver = new List<IQArray<long>>();
            // collects N * 4 y vectors
            for (int i=0; i < N*4; i++)
            {
                var vector = Simon_Bitwise_Shift.Run(qsim, N).Result;
                Console.WriteLine(vector.Length);
                saver.Add(vector);
            }
            // Finds s based off of y vectors
            var matrix = new BooleanMatrix(saver);
            Console.WriteLine(matrix.Height);
            Console.WriteLine(matrix.Width);
            var kernel = matrix.GetKernel();
            
            Console.WriteLine("S: " + string.Join(", ", kernel.GetRange(0, kernel.Count()/2)));
        }
    }
}