#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_CountBits_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":53}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_CountBits_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_CountBits_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Simon.Oracle_CountBits_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_BitwiseRightShift_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":61}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_BitwiseRightShift_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_BitwiseRightShift_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Simon.Oracle_BitwiseRightShift_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_OperatorOutput_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":58}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"A\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_OperatorOutput_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_OperatorOutput_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Simon.Oracle_OperatorOutput_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_MultidimensionalOperatorOutput_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":58}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":74}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"A\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":87}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_MultidimensionalOperatorOutput_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":58}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"Oracle_MultidimensionalOperatorOutput_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Simon.Oracle_MultidimensionalOperatorOutput_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Simon\",\"Name\":\"SA_StatePrep_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":80,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"query\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"SA_StatePrep_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":80,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"SA_StatePrep_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":80,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Simon.SA_StatePrep_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Simon\",\"Name\":\"Simon_Algorithm_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Simon\",\"Name\":\"Simon_Algorithm_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Simon/simon.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
#line hidden
namespace Simon
{
    public partial class Oracle_CountBits_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_CountBits_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_CountBits_Reference";
        String ICallable.FullName => "Simon.Oracle_CountBits_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 25 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
            var N = x.Length;
#line 27 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 28 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            var N = x.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[i], y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_CountBits_Reference, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public partial class Oracle_BitwiseRightShift_Reference : Adjointable<(IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public Oracle_BitwiseRightShift_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_BitwiseRightShift_Reference";
        String ICallable.FullName => "Simon.Oracle_BitwiseRightShift_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 37 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
            var N = x.Length;
#line 39 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
            foreach (var i in new Range(1L, (N - 1L)))
#line hidden
            {
#line 40 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((x[(i - 1L)], y[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            var N = x.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, (N - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[(i - 1L)], y[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, IQArray<Qubit> y)
        {
            return __m__.Run<Oracle_BitwiseRightShift_Reference, (IQArray<Qubit>,IQArray<Qubit>), QVoid>((x, y));
        }
    }

    public partial class Oracle_OperatorOutput_Reference : Adjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, ICallable
    {
        public Oracle_OperatorOutput_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_OperatorOutput_Reference";
        String ICallable.FullName => "Simon.Oracle_OperatorOutput_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (x,y,A) = __in__;
#line 49 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
            var N = x.Length;
#line 51 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 52 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                if ((A[i] == 1L))
                {
#line 53 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,A) = __in__;
#line hidden
            var N = x.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                if ((A[i] == 1L))
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[i], y));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, IQArray<Int64> A)
        {
            return __m__.Run<Oracle_OperatorOutput_Reference, (IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>((x, y, A));
        }
    }

    public partial class Oracle_MultidimensionalOperatorOutput_Reference : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>, ICallable
    {
        public Oracle_MultidimensionalOperatorOutput_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_MultidimensionalOperatorOutput_Reference";
        String ICallable.FullName => "Simon.Oracle_MultidimensionalOperatorOutput_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>), QVoid> Body => (__in__) =>
        {
            var (x,y,A) = __in__;
#line 63 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
            var N1 = y.Length;
#line 64 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
            var N2 = x.Length;
#line 66 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
            foreach (var i in new Range(0L, (N1 - 1L)))
#line hidden
            {
#line 67 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                foreach (var j in new Range(0L, (N2 - 1L)))
#line hidden
                {
#line 68 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                    if ((A[i][j] == 1L))
                    {
#line 69 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((x[j], y[i]));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,A) = __in__;
#line hidden
            var N1 = y.Length;
#line hidden
            var N2 = x.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N1 - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, (N2 - 1L))))
#line hidden
                {
#line hidden
                    if ((A[i][j] == 1L))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[j], y[i]));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, IQArray<Qubit> y, IQArray<IQArray<Int64>> A)
        {
            return __m__.Run<Oracle_MultidimensionalOperatorOutput_Reference, (IQArray<Qubit>,IQArray<Qubit>,IQArray<IQArray<Int64>>), QVoid>((x, y, A));
        }
    }

    public partial class SA_StatePrep_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public SA_StatePrep_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SA_StatePrep_Reference";
        String ICallable.FullName => "Simon.SA_StatePrep_Reference";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var query = __in__;
#line 83 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicH, query));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var query = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, query));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> query)
        {
            return __m__.Run<SA_StatePrep_Reference, IQArray<Qubit>, QVoid>(query);
        }
    }

    public partial class Simon_Algorithm_Reference : Operation<(Int64,ICallable), IQArray<Int64>>, ICallable
    {
        public Simon_Algorithm_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "Simon_Algorithm_Reference";
        String ICallable.FullName => "Simon.Simon_Algorithm_Reference";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> SA_StatePrep_Reference
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), IQArray<Int64>> Body => (__in__) =>
        {
            var (N,Uf) = __in__;
#line hidden
            {
#line 91 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                var (x,y) = (Allocate.Apply(N), Allocate.Apply(N));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 93 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                    SA_StatePrep_Reference.Apply(x);
#line 96 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                    Uf.Apply((x, y));
#line 99 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicH, x));
#line 103 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                    var j = QArray<Int64>.Create(N);
#line 104 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                    foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                    {
#line 105 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(x[i]) == Result.One))
                        {
#line 106 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                            j.Modify(i, 1L);
                        }
                    }

#line 111 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(x);
#line 112 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(y);
#line 113 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Simon/simon.qs"
                    return j;
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(x);
#line hidden
                    Release.Apply(y);
                }
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.SA_StatePrep_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(SA_StatePrep_Reference));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<Simon_Algorithm_Reference, (Int64,ICallable), IQArray<Int64>>((N, Uf));
        }
    }
}