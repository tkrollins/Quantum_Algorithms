// // Copyright (c) Microsoft Corporation. All rights reserved.
// // Licensed under the MIT license.

// //////////////////////////////////////////////////////////////////////
// // This file contains parts of the testing harness. 
// // You should not modify anything in this file.
// // The tasks themselves can be found in Tasks.qs file.
// //////////////////////////////////////////////////////////////////////

// namespace Q22
// {
//     using System;
//     using System.Collections.Generic;
//     using System.IO;
//     using System.Linq;

//     using Microsoft.Quantum.Simulation.Core;

//     using Quantum.Kata.SimonsAlgorithm;

//     using Newtonsoft.Json;

//     using Xunit;
//     using Xunit.Abstractions;

//     public class Simons_Algorithm
//     {
//         public class Instance : IXunitSerializable
//         {
//             public List<List<long>> transformation { get; set; }

//             public List<long> kernel { get; set; }

//             public int instance { get; set; }

//             public Instance()
//             {
//             }

//             public Instance(List<List<long>> transformation, List<long> kernel, int instance)
//             {
//                 this.transformation = transformation;
//                 this.kernel = kernel;
//                 this.instance = instance;
//             }

//             public BooleanVector Kernel => new BooleanVector(kernel);

//             public IQArray<IQArray<long>> Transformation => new QArray<IQArray<long>>(
//                 transformation.Select(
//                     vector => new QArray<long>(vector)));

//             public IQArray<IQArray<long>> ExtendedTransformation
//             {
//                 get
//                 {
//                     var array = (IQArray<IQArray<long>>)new QArray<IQArray<long>>(
//                         transformation.Select(vector => new QArray<long>(vector))
//                     );
//                     array = QArray<IQArray<long>>.Add (array, new QArray<IQArray<long>>(new QArray<long>(transformation.Last())));
//                     return array;
//                 }
//             }

//             public void Deserialize(IXunitSerializationInfo info)
//             {
//                 kernel = JsonConvert.DeserializeObject<List<long>>(info.GetValue<string>("kernel"));
//                 transformation = JsonConvert.DeserializeObject<List<List<long>>>(info.GetValue<string>("transformation"));
//             }

//             public void Serialize(IXunitSerializationInfo info)
//             {
//                 info.AddValue("kernel", JsonConvert.SerializeObject(kernel), typeof(string));
//                 info.AddValue("transformation", JsonConvert.SerializeObject(transformation), typeof(string));
//             }
            
//             public override string ToString()
//             {
//                 return instance.ToString("D2");
//             }
//         }

//         private readonly ITestOutputHelper output;

//         public Simons_Algorithm(ITestOutputHelper output)
//         {
//             this.output = output;
//         }

//         public static IEnumerable<object[]> GetInstances()
//         {
//             var assembly = System.Reflection.Assembly.GetExecutingAssembly();
//             string resourceName = @"Quantum.Kata.SimonsAlgorithm.Instances.json";
//             using (var stream = assembly.GetManifestResourceStream(resourceName)) {
//                 if (stream == null) {
//                     var res = String.Join(", ", assembly.GetManifestResourceNames());
//                     throw new Exception($"Resource {resourceName} not found in {assembly.FullName}. Valid resources are: {res}.");
//                 }
//                 using (var reader = new StreamReader(stream)) {
//                     foreach (var instance in JsonSerializer.Create().Deserialize<List<Instance>>(new JsonTextReader(reader)))
//                     {
//                         yield return new object[] { instance };
//                     }
//                 }
//             }
//         }

//         [Theory]
//         [MemberData(nameof(GetInstances))]
//         public void Test(Instance instance)
//         {
//             var sim = new OracleCounterSimulator();
            
//             var len = instance.Kernel.Count;
//             var saver = new List<IQArray<long>>();

//             for (int i = 0; i < len * 4; ++i)
//             {
//                 var (vector, uf) = cs_helper.Run(sim, len, instance.ExtendedTransformation).Result;
//                 Assert.Equal(1, sim.GetOperationCount(uf));
//                 saver.Add(vector);
//             }

//             var matrix = new BooleanMatrix(saver);
//             var kernel = matrix.GetKernel();

//             Assert.Equal(instance.Kernel.Contains(true) ? 2 : 1, kernel.Count);
//             Assert.Contains(instance.Kernel, kernel);
//         }
//     }

//     public class BooleanVector : IEnumerable<bool>, IComparable<BooleanVector>, IEquatable<BooleanVector>
//     {
//         private readonly List<bool> values;

//         public BooleanVector(int size)
//         {
//             values = new List<bool>(size);
//         }
        
//         public BooleanVector(IEnumerable<bool> array)
//         {
//             values = new List<bool>();
//             values.AddRange(array);
//         }

//         public BooleanVector(IEnumerable<long> array)
//             : this(array.Select(v => v != 0))
//         {
//         }

//         public bool this[int index]
//         {
//             get => values[index];
//             set => values[index] = value;
//         }

//         public static BooleanVector operator +(BooleanVector vector1, BooleanVector vector2)
//         {
//             if (vector1.Count != vector2.Count)
//             {
//                 throw new ArgumentException($"Vectors have different sizes [{vector1.Count} != {vector2.Count}]");
//             }

//             return new BooleanVector(vector1.Zip(vector2, (val1, val2) => val1 ^ val2));
//         }

//         public static BooleanVector operator -(BooleanVector vector1, BooleanVector vector2)
//         {
//             return vector1 + vector2;
//         }

//         public IEnumerator<bool> GetEnumerator()
//         {
//             return values.GetEnumerator();
//         }

//         IEnumerator IEnumerable.GetEnumerator()
//         {
//             return values.GetEnumerator();
//         }

//         public int CompareTo(BooleanVector other)
//         {
//             int length = Math.Min(Count, other.Count);
//             for (int i = 0; i < length; i++)
//             {
//                 var comp = this[i].CompareTo(other[i]);
//                 if (comp != 0) return comp;
//             }

//             return Count.CompareTo(other.Count);
//         }

//         public int Count => values.Count;

//         public bool Equals(BooleanVector other)
//         {
//             return CompareTo(other) == 0;
//         }

//         #region Overrides of Object

//         public override string ToString()
//         {
//             return string.Join(", ", this);
//         }

//         #endregion
//     }

//     public class BooleanMatrix
//     {
//         private readonly List<BooleanVector> matrix = new List<BooleanVector>();

//         public int Height { get; }

//         public int? Width { get; }

//         public BooleanMatrix(BooleanMatrix matrix)
//         {
//             foreach (var vector in matrix.matrix)
//             {
//                 this.matrix.Add(new BooleanVector(vector));
//             }

//             Height = matrix.Height;
//             Width = matrix.Width;
//         }

//         public BooleanMatrix(IEnumerable<BooleanVector> rows)
//         {
//             foreach (var row in rows)
//             {
//                 matrix.Add(row);
//                 if (Width == row.Count || Width == null)
//                 {
//                     Width = row.Count;
//                 }
//                 else
//                 {
//                     throw new ArgumentException("Not every row has the same size");
//                 }
//             }

//             Height = matrix.Count;
//         }

//         public BooleanMatrix(IEnumerable<IEnumerable<long>> source)
//         {
//             foreach (var row in source)
//             {
//                 matrix.Add(new BooleanVector(row.Select(x => x != 0)));
//                 Width = matrix.Last().Count;
//             }

//             Height = matrix.Count;
//         }

//         public BooleanMatrix(IEnumerable<IEnumerable<bool>> rows)
//             : this(rows.Select(row => new BooleanVector(row)))
//         {
//         }

//         public BooleanVector this[int index]
//         {
//             get => matrix[index];
//             set => matrix[index] = value;
//         }

//         public List<BooleanVector> GetKernel()
//         {
//             if (Width == null)
//             {
//                 throw new ArgumentNullException(nameof(Width));
//             }

//             return GetKernel(Width.Value - 1);
//         }

//         public List<BooleanVector> GetKernel(int minimalRank)
//         {
//             return GaussianElimination.GetKernel(this, minimalRank);
//         }
//     }
// }