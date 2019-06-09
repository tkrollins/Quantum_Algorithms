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
                // Times Simon
                time_simon_bitshift(qsim, MAX_N, ITER);
                time_simon_multi(qsim, MAX_N, ITER);

                // Returns result for s
                run_simon_bitshift(qsim, 2);
                run_simon_bitshift(qsim, 3);

                // Tests qubit reset
                try {
                    var test = Test_Qubit_Reset.Run(qsim).Result;
                }
                catch {
                    Console.WriteLine("Qubits not returned to Zero state automatically");
                } 
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
                saver.Add(vector);
            }
            // Finds s based off of y vectors
            var matrix = new BooleanMatrix(saver);
            var kernel = matrix.GetKernel();
            
            Console.WriteLine("S: " + string.Join(", ", kernel.GetRange(0, kernel.Count()/2)));
        }
        // Builds a random Int[][] to pass into the Multi-dimensional operator
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
        // Builds a Int[][] to pass into the Multi-dimensional operator
        // version of Uf.  Takes a List<list<long>> and turns it into a 
        // Int[][] to be passed to quantum operation.
        static QArray<QArray<long>> build_A(List<List<long>> array_A)
        {
            List<QArray<long>> temp_A = new List<QArray<long>>();

            foreach (List<long> row in array_A)
            {
                var A_vector = new QArray<long>(row);
                temp_A.Add(A_vector);
            }
            var A = new QArray<QArray<long>>(temp_A);
            
            return A;
        }
    }

    /////////////////////////////////////////////////////
    // BooleanMatrix from Kata code
    /////////////////////////////////////////////////////

    public class BooleanVector : IEnumerable<bool>, IComparable<BooleanVector>, IEquatable<BooleanVector>
    {
        private readonly List<bool> values;

        public BooleanVector(int size)
        {
            values = new List<bool>(size);
        }
        
        public BooleanVector(IEnumerable<bool> array)
        {
            values = new List<bool>();
            values.AddRange(array);
        }

        public BooleanVector(IEnumerable<long> array)
            : this(array.Select(v => v != 0))
        {
        }

        public bool this[int index]
        {
            get => values[index];
            set => values[index] = value;
        }

        public static BooleanVector operator +(BooleanVector vector1, BooleanVector vector2)
        {
            if (vector1.Count != vector2.Count)
            {
                throw new ArgumentException($"Vectors have different sizes [{vector1.Count} != {vector2.Count}]");
            }

            return new BooleanVector(vector1.Zip(vector2, (val1, val2) => val1 ^ val2));
        }

        public static BooleanVector operator -(BooleanVector vector1, BooleanVector vector2)
        {
            return vector1 + vector2;
        }

        public IEnumerator<bool> GetEnumerator()
        {
            return values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return values.GetEnumerator();
        }

        public int CompareTo(BooleanVector other)
        {
            int length = Math.Min(Count, other.Count);
            for (int i = 0; i < length; i++)
            {
                var comp = this[i].CompareTo(other[i]);
                if (comp != 0) return comp;
            }

            return Count.CompareTo(other.Count);
        }

        public int Count => values.Count;

        public bool Equals(BooleanVector other)
        {
            return CompareTo(other) == 0;
        }

        #region Overrides of Object

        public override string ToString()
        {
            return string.Join(", ", this);
        }

        #endregion
    }

    public class BooleanMatrix
    {
        private readonly List<BooleanVector> matrix = new List<BooleanVector>();

        public int Height { get; }

        public int? Width { get; }

        public BooleanMatrix(BooleanMatrix matrix)
        {
            foreach (var vector in matrix.matrix)
            {
                this.matrix.Add(new BooleanVector(vector));
            }

            Height = matrix.Height;
            Width = matrix.Width;
        }

        public BooleanMatrix(IEnumerable<BooleanVector> rows)
        {
            foreach (var row in rows)
            {
                matrix.Add(row);
                if (Width == row.Count || Width == null)
                {
                    Width = row.Count;
                }
                else
                {
                    throw new ArgumentException("Not every row has the same size");
                }
            }

            Height = matrix.Count;
        }

        public BooleanMatrix(IEnumerable<IEnumerable<long>> source)
        {
            foreach (var row in source)
            {
                matrix.Add(new BooleanVector(row.Select(x => x != 0)));
                Width = matrix.Last().Count;
            }

            Height = matrix.Count;
        }

        public BooleanMatrix(IEnumerable<IEnumerable<bool>> rows)
            : this(rows.Select(row => new BooleanVector(row)))
        {
        }

        public BooleanVector this[int index]
        {
            get => matrix[index];
            set => matrix[index] = value;
        }

        public List<BooleanVector> GetKernel()
        {
            if (Width == null)
            {
                throw new ArgumentNullException(nameof(Width));
            }

            return GetKernel(Width.Value - 1);
        }

        public List<BooleanVector> GetKernel(int minimalRank)
        {
            return GaussianElimination.GetKernel(this, minimalRank);
        }
    }

    /////////////////////////////////////////////////////
    // Gaussian Elimination from Kata code
    /////////////////////////////////////////////////////

    public class GaussianElimination
    {
        /// <summary>
        /// Finds all vectors v for which vM = 0, where M is an argument matrix.
        /// If rank of matrix is less then minimalRank exception is raised to protect from too big kernel.
        /// </summary>
        /// <param name="matrix">linear transformation</param>
        /// <param name="minimalRank">required minimal rank</param>
        /// <returns></returns>
        public static List<BooleanVector> GetKernel(BooleanMatrix matrix, int minimalRank)
        {
            matrix = new BooleanMatrix(matrix);

            var columnPivot = new List<int?>();
            var row = 0;

            for (var column = 0; column < matrix.Width; column++)
            {
                var foundPivot = FindPivotAndSwapRows(matrix, row, column);
                if (foundPivot)
                {
                    ReduceRows(matrix, row, column);
                    columnPivot.Add(row);
                    row++;
                }
                else
                {
                    columnPivot.Add(null);
                }
            }

            if (row < minimalRank)
                throw new InvalidOperationException("Matrix doesn't have sufficient rank");

            return FindSolution(matrix, columnPivot, 0).Select(list => new BooleanVector(Enumerable.Reverse(list))).ToList();
        }

        /// <summary>
        /// Finds first row (with index greater or equal to <paramref name="row"/>) for which value in <paramref name="column"/> is
        /// positive and swaps it with <paramref name="row"/>-th row.
        /// </summary>
        /// <param name="matrix">processed matrix</param>
        /// <param name="row">index of first row</param>
        /// <param name="column">index of column in which pivot is looked for</param>
        /// <returns></returns>
        private static bool FindPivotAndSwapRows(BooleanMatrix matrix, int row, int column)
        {
            for (var i = row; i < matrix.Height; i++)
            {
                if (!matrix[i][column]) continue;
                SwapRows(matrix, i, row);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Reduce rows with index greater then <paramref name="row"/> to ensure that value in <paramref name="column"/> is equal
        /// to zero.
        /// </summary>
        /// <param name="matrix">processed matrix</param>
        /// <param name="row">index of first row</param>
        /// <param name="column">index of column to be cleared</param>
        private static void ReduceRows(BooleanMatrix matrix, int row, int column)
        {
            for (var i = row + 1; i < matrix.Height; i++)
            {
                if (matrix[i][column])
                {
                    matrix[i] -= matrix[row];
                }
            }
        }

        /// <summary>
        /// Finds partial solutions for columns with index greater or equal to <paramref name="column"/>.
        /// </summary>
        /// <param name="upperTriangleMatrix">matrix in upper triangle form to be processed</param>
        /// <param name="columnPivot">indexes of rows containing pivots for every column</param>
        /// <param name="column">index of first column in partial solution</param>
        /// <returns></returns>
        private static IEnumerable<List<bool>> FindSolution(BooleanMatrix upperTriangleMatrix, IReadOnlyList<int?> columnPivot, int column)
        {
            if (column >= upperTriangleMatrix.Width)
            {
                return new List<List<bool>>
                {
                    new List<bool>()
                };
            }

            return FindSolution(upperTriangleMatrix, columnPivot, column + 1)
                .SelectMany(solutionVector => ExtendSolutionVector(solutionVector, upperTriangleMatrix, column, columnPivot[column]))
                .ToList();
        }

        /// <summary>
        /// Extend partial solution to column with given index.
        /// </summary>
        /// <param name="solutionVector">partial solution to be extended</param>
        /// <param name="upperTriangleMatrix">matrix in upper triangle form to be processed</param>
        /// <param name="column">index of column to be extended</param>
        /// <param name="row">index of row containing pivot for column, null if there is no pivot</param>
        /// <returns></returns>
        private static IEnumerable<List<bool>> ExtendSolutionVector(
            IReadOnlyList<bool> solutionVector,
            BooleanMatrix upperTriangleMatrix,
            int column,
            int? row)
        {
            if (row.HasValue)
            {
                var sum = false;
                for (var i = 1; column + i < upperTriangleMatrix.Width; i++)
                {
                    sum ^= upperTriangleMatrix[row.Value][upperTriangleMatrix.Width.Value - i] & solutionVector[i - 1];
                }

                return new List<List<bool>>
                {
                    new List<bool>(solutionVector)
                    {
                        sum
                    }
                };
            }

            return new List<List<bool>>
            {
                new List<bool>(solutionVector)
                {
                    true
                },
                new List<bool>(solutionVector)
                {
                    false
                }
            };
        }

        /// <summary>
        /// Swaps two rows of matrix.
        /// </summary>
        /// <param name="matrix">matrix to be processed</param>
        /// <param name="firstRow">index of first row</param>
        /// <param name="secondRow">index of second row</param>
        private static void SwapRows(BooleanMatrix matrix, int firstRow, int secondRow)
        {
            var row1 = matrix[firstRow];
            var row2 = matrix[secondRow];
            matrix[secondRow] = row1;
            matrix[firstRow] = row2;
        }
    }
}