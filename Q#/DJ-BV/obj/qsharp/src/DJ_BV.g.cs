#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_Zero_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_Zero_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_Zero_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for DJ_BV.Oracle_Zero_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_One_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_One_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_One_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for DJ_BV.Oracle_One_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_Kth_Qubit_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":64}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_Kth_Qubit_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_Kth_Qubit_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for DJ_BV.Oracle_Kth_Qubit_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_OddNumberOfOnes_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_OddNumberOfOnes_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_OddNumberOfOnes_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for DJ_BV.Oracle_OddNumberOfOnes_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_ProductFunction_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"r\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":70}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_ProductFunction_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_ProductFunction_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for DJ_BV.Oracle_ProductFunction_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_ProductWithNegationFunction_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":55}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":58}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":70},\"Item2\":{\"Line\":1,\"Column\":71}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"r\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":82}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_ProductWithNegationFunction_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":55}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_ProductWithNegationFunction_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for DJ_BV.Oracle_ProductWithNegationFunction_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_HammingWithPrefix_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"prefix\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":77}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_HammingWithPrefix_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_HammingWithPrefix_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for DJ_BV.Oracle_HammingWithPrefix_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_MajorityFunction_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":162,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_MajorityFunction_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":162,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Oracle_MajorityFunction_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":162,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for DJ_BV.Oracle_MajorityFunction_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"BV_StatePrep_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":188,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"query\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"answer\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"BV_StatePrep_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":188,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"BV_StatePrep_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":188,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for DJ_BV.BV_StatePrep_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"BV_Algorithm_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":210,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"BV_Algorithm_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":210,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"DJ_Algorithm_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":262,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"DJ_Algorithm_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":262,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"DJ\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":282,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":13}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":16}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"DJ\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":282,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":13}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Noname_Algorithm_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":302,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DJ_BV\",\"Name\":\"Noname_Algorithm_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/DJ-BV/DJ_BV.qs\",\"Position\":{\"Item1\":302,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
#line hidden
namespace DJ_BV
{
    public partial class Oracle_Zero_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_Zero_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_Zero_Reference";
        String ICallable.FullName => "DJ_BV.Oracle_Zero_Reference";
        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_Zero_Reference, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public partial class Oracle_One_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_One_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_One_Reference";
        String ICallable.FullName => "DJ_BV.Oracle_One_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 35 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumIntrinsicX.Apply(y);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(y);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_One_Reference, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public partial class Oracle_Kth_Qubit_Reference : Adjointable<(IQArray<Qubit>,Qubit,Int64)>, ICallable
    {
        public Oracle_Kth_Qubit_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_Kth_Qubit_Reference";
        String ICallable.FullName => "DJ_BV.Oracle_Kth_Qubit_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (x,y,k) = __in__;
#line 47 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((((0L <= k) && (k < x.Length)), true, "k should be between 0 and N-1, inclusive"));
#line 48 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((x[k], y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,k) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((((0L <= k) && (k < x.Length)), true, "k should be between 0 and N-1, inclusive"));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[k], y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, Int64 k)
        {
            return __m__.Run<Oracle_Kth_Qubit_Reference, (IQArray<Qubit>,Qubit,Int64), QVoid>((x, y, k));
        }
    }

    public partial class Oracle_OddNumberOfOnes_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_OddNumberOfOnes_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_OddNumberOfOnes_Reference";
        String ICallable.FullName => "DJ_BV.Oracle_OddNumberOfOnes_Reference";
        protected ICallable Length
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
#line 60 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            foreach (var q in x)
#line hidden
            {
#line 61 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((q, y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            foreach (var q in x?.Slice(new Range((x.Length - 1L), -1L, 0L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((q, y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_OddNumberOfOnes_Reference, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public partial class Oracle_ProductFunction_Reference : Adjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, ICallable
    {
        public Oracle_ProductFunction_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_ProductFunction_Reference";
        String ICallable.FullName => "DJ_BV.Oracle_ProductFunction_Reference";
        protected ICallable MicrosoftQuantumArraysIndexRange
        {
            get;
            set;
        }

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

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
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
            var (x,y,r) = __in__;
#line 80 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((x.Length, r.Length, "Arrays should have the same length"));
#line 82 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            foreach (var i in MicrosoftQuantumArraysIndexRange.Apply<Range>(x))
#line hidden
            {
#line 83 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                if ((r[i] == 1L))
                {
#line 84 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,r) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((x.Length, r.Length, "Arrays should have the same length"));
#line hidden
            foreach (var i in RangeReverse.Apply(MicrosoftQuantumArraysIndexRange.Apply<Range>(x)))
#line hidden
            {
#line hidden
                if ((r[i] == 1L))
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
            this.MicrosoftQuantumArraysIndexRange = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.IndexRange<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, IQArray<Int64> r)
        {
            return __m__.Run<Oracle_ProductFunction_Reference, (IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>((x, y, r));
        }
    }

    public partial class Oracle_ProductWithNegationFunction_Reference : Adjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, ICallable
    {
        public Oracle_ProductWithNegationFunction_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_ProductWithNegationFunction_Reference";
        String ICallable.FullName => "DJ_BV.Oracle_ProductWithNegationFunction_Reference";
        protected ICallable MicrosoftQuantumArraysIndexRange
        {
            get;
            set;
        }

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

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (x,y,r) = __in__;
#line 101 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((x.Length, r.Length, "Arrays should have the same length"));
#line 103 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            foreach (var i in MicrosoftQuantumArraysIndexRange.Apply<Range>(x))
#line hidden
            {
#line 104 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                if ((r[i] == 1L))
                {
#line 105 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y));
                }
                else
                {
#line 108 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicX.Apply(x[i]);
#line 109 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y));
#line 110 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicX.Apply(x[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,r) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((x.Length, r.Length, "Arrays should have the same length"));
#line hidden
            foreach (var i in RangeReverse.Apply(MicrosoftQuantumArraysIndexRange.Apply<Range>(x)))
#line hidden
            {
#line hidden
                if ((r[i] == 1L))
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[i], y));
                }
                else
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(x[i]);
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[i], y));
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(x[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysIndexRange = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.IndexRange<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, IQArray<Int64> r)
        {
            return __m__.Run<Oracle_ProductWithNegationFunction_Reference, (IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>((x, y, r));
        }
    }

    public partial class Oracle_HammingWithPrefix_Reference : Adjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, ICallable
    {
        public Oracle_HammingWithPrefix_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_HammingWithPrefix_Reference";
        String ICallable.FullName => "DJ_BV.Oracle_HammingWithPrefix_Reference";
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

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (x,y,prefix) = __in__;
#line 129 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            var P = prefix.Length;
#line 130 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((((1L <= P) && (P <= x.Length)), true, "P should be between 1 and N, inclusive"));
#line 133 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            foreach (var q in x)
#line hidden
            {
#line 134 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((q, y));
            }

#line 139 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            foreach (var i in new Range(0L, (P - 1L)))
#line hidden
            {
#line 141 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                if ((prefix[i] == 0L))
                {
#line 142 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicX.Apply(x[i]);
                }
            }

#line 146 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((x?.Slice(new Range(0L, (P - 1L))), y));
#line 149 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            foreach (var i in new Range(0L, (P - 1L)))
#line hidden
            {
#line 151 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                if ((prefix[i] == 0L))
                {
#line 152 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicX.Apply(x[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,prefix) = __in__;
#line hidden
            var P = prefix.Length;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((((1L <= P) && (P <= x.Length)), true, "P should be between 1 and N, inclusive"));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (P - 1L))))
#line hidden
            {
#line hidden
                if ((prefix[i] == 0L))
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(x[i]);
                }
            }

#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((x?.Slice(new Range(0L, (P - 1L))), y));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (P - 1L))))
#line hidden
            {
#line hidden
                if ((prefix[i] == 0L))
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(x[i]);
                }
            }

#line hidden
            foreach (var q in x?.Slice(new Range((x.Length - 1L), -1L, 0L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((q, y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, IQArray<Int64> prefix)
        {
            return __m__.Run<Oracle_HammingWithPrefix_Reference, (IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>((x, y, prefix));
        }
    }

    public partial class Oracle_MajorityFunction_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_MajorityFunction_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_MajorityFunction_Reference";
        String ICallable.FullName => "DJ_BV.Oracle_MajorityFunction_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumIntrinsicCCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 167 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply(((3L == x.Length), true, "x should have exactly 3 qubits"));
#line 171 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumIntrinsicCCNOT.Apply((x[0L], x[1L], y));
#line 172 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumIntrinsicCCNOT.Apply((x[0L], x[2L], y));
#line 173 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumIntrinsicCCNOT.Apply((x[1L], x[2L], y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply(((3L == x.Length), true, "x should have exactly 3 qubits"));
#line hidden
            MicrosoftQuantumIntrinsicCCNOT.Adjoint.Apply((x[1L], x[2L], y));
#line hidden
            MicrosoftQuantumIntrinsicCCNOT.Adjoint.Apply((x[0L], x[2L], y));
#line hidden
            MicrosoftQuantumIntrinsicCCNOT.Adjoint.Apply((x[0L], x[1L], y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.MicrosoftQuantumIntrinsicCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CCNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_MajorityFunction_Reference, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public partial class BV_StatePrep_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public BV_StatePrep_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BV_StatePrep_Reference";
        String ICallable.FullName => "DJ_BV.BV_StatePrep_Reference";
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (query,answer) = __in__;
#line 191 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicH, query));
#line 192 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumIntrinsicX.Apply(answer);
#line 193 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            MicrosoftQuantumIntrinsicH.Apply(answer);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (query,answer) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(answer);
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(answer);
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
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> query, Qubit answer)
        {
            return __m__.Run<BV_StatePrep_Reference, (IQArray<Qubit>,Qubit), QVoid>((query, answer));
        }
    }

    public partial class BV_Algorithm_Reference : Operation<(Int64,ICallable), IQArray<Int64>>, ICallable
    {
        public BV_Algorithm_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "BV_Algorithm_Reference";
        String ICallable.FullName => "DJ_BV.BV_Algorithm_Reference";
        protected IAdjointable<(IQArray<Qubit>,Qubit)> BV_StatePrep_Reference
        {
            get;
            set;
        }

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

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), IQArray<Int64>> Body => (__in__) =>
        {
            var (N,Uf) = __in__;
#line hidden
            {
#line 214 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                var (x,y) = (Allocate.Apply(N), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 217 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    BV_StatePrep_Reference.Apply((x, y));
#line 220 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    Uf.Apply((x, y));
#line 223 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicH, x));
#line 227 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    var r = QArray<Int64>.Create(N);
#line 228 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                    {
#line 229 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(x[i]) != Result.Zero))
                        {
#line 230 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                            r.Modify(i, 1L);
                        }
                    }

#line 235 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(x);
#line 236 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(y);
#line 237 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    return r;
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
            this.BV_StatePrep_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(BV_StatePrep_Reference));
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<BV_Algorithm_Reference, (Int64,ICallable), IQArray<Int64>>((N, Uf));
        }
    }

    public partial class DJ_Algorithm_Reference : Operation<(Int64,ICallable), Boolean>, ICallable
    {
        public DJ_Algorithm_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "DJ_Algorithm_Reference";
        String ICallable.FullName => "DJ_BV.DJ_Algorithm_Reference";
        protected ICallable<(Int64,ICallable), IQArray<Int64>> BV_Algorithm_Reference
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), Boolean> Body => (__in__) =>
        {
            var (N,Uf) = __in__;
#line 267 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            var isConstantFunction = true;
#line 274 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            var r = (IQArray<Int64>)BV_Algorithm_Reference.Apply((N, Uf));
#line 276 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 277 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                isConstantFunction = (isConstantFunction && (r[i] == 0L));
            }

#line 280 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            return isConstantFunction;
        }

        ;
        public override void Init()
        {
            this.BV_Algorithm_Reference = this.Factory.Get<ICallable<(Int64,ICallable), IQArray<Int64>>>(typeof(BV_Algorithm_Reference));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<DJ_Algorithm_Reference, (Int64,ICallable), Boolean>((N, Uf));
        }
    }

    public partial class DJ : Operation<Int64, Boolean>, ICallable
    {
        public DJ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DJ";
        String ICallable.FullName => "DJ_BV.DJ";
        protected ICallable<(Int64,ICallable), Boolean> DJ_Algorithm_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_OddNumberOfOnes_Reference
        {
            get;
            set;
        }

        public override Func<Int64, Boolean> Body => (__in__) =>
        {
            var N = __in__;
#line 285 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
            return DJ_Algorithm_Reference.Apply((N, Oracle_OddNumberOfOnes_Reference));
        }

        ;
        public override void Init()
        {
            this.DJ_Algorithm_Reference = this.Factory.Get<ICallable<(Int64,ICallable), Boolean>>(typeof(DJ_Algorithm_Reference));
            this.Oracle_OddNumberOfOnes_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_OddNumberOfOnes_Reference));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 N)
        {
            return __m__.Run<DJ, Int64, Boolean>(N);
        }
    }

    public partial class Noname_Algorithm_Reference : Operation<(Int64,ICallable), IQArray<Int64>>, ICallable
    {
        public Noname_Algorithm_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "Noname_Algorithm_Reference";
        String ICallable.FullName => "DJ_BV.Noname_Algorithm_Reference";
        protected Allocate Allocate
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

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), IQArray<Int64>> Body => (__in__) =>
        {
            var (N,Uf) = __in__;
#line hidden
            {
#line 305 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                var (x,y) = (Allocate.Apply(N), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 307 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    Uf.Apply((x, y));
#line 311 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    if (((N % 2L) == 1L))
                    {
#line 312 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                        MicrosoftQuantumIntrinsicX.Apply(y);
                    }

#line 319 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    var r = QArray<Int64>.Create(N);
#line 322 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    var m = MicrosoftQuantumIntrinsicM.Apply(y);
#line 323 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    if ((m == Result.One))
                    {
#line 325 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                        r.Modify(0L, 1L);
                    }

#line 329 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(x);
#line 330 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(y);
#line 331 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/DJ-BV/DJ_BV.qs"
                    return r;
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
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<Noname_Algorithm_Reference, (Int64,ICallable), IQArray<Int64>>((N, Uf));
        }
    }
}