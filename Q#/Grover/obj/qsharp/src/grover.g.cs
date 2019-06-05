#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"Oracle_AllOnes_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"queryRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":68}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"Oracle_AllOnes_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"Oracle_AllOnes_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Grover.Oracle_AllOnes_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"Oracle_AlternatingBits_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"queryRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":58}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":70},\"Item2\":{\"Line\":1,\"Column\":76}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"Oracle_AlternatingBits_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"Oracle_AlternatingBits_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Grover.Oracle_AlternatingBits_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"FlipOddPositionBits_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"FlipOddPositionBits_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"FlipOddPositionBits_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Grover.FlipOddPositionBits_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"Oracle_ArbitraryPattern_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"queryRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":77}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pattern\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":87},\"Item2\":{\"Line\":1,\"Column\":94}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"Oracle_ArbitraryPattern_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"Oracle_ArbitraryPattern_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Grover.Oracle_ArbitraryPattern_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"OracleConverterImpl_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markingOracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":93},\"Item2\":{\"Line\":1,\"Column\":101}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"OracleConverterImpl_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"OracleConverterImpl_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Grover.OracleConverterImpl_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"OracleConverter_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":77,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markingOracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"OracleConverter_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":77,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"HadamardTransform_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"HadamardTransform_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"HadamardTransform_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Grover.HadamardTransform_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"ConditionalPhaseFlip_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":101,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"ConditionalPhaseFlip_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":103,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"ConditionalPhaseFlip_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":112,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"PhaseFlip_ControlledZ\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"PhaseFlip_ControlledZ\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":118,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"PhaseFlip_ControlledZ\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":125,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"GroverIteration_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":64}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"GroverIteration_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"GroverIteration_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Grover.GroverIteration_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"GroversSearch_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":145,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":62}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"iterations\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":100},\"Item2\":{\"Line\":1,\"Column\":110}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"GroversSearch_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":145,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"GroversSearch_Reference\"},\"SourceFile\":\"/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q%23/Grover/grover.qs\",\"Position\":{\"Item1\":145,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Grover.GroversSearch_Reference\"]}")]
#line hidden
namespace Grover
{
    public partial class Oracle_AllOnes_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_AllOnes_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_AllOnes_Reference";
        String ICallable.FullName => "Grover.Oracle_AllOnes_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (queryRegister,target) = __in__;
#line 25 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((queryRegister, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (queryRegister,target) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((queryRegister, target));
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> queryRegister, Qubit target)
        {
            return __m__.Run<Oracle_AllOnes_Reference, (IQArray<Qubit>,Qubit), QVoid>((queryRegister, target));
        }
    }

    public partial class Oracle_AlternatingBits_Reference : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_AlternatingBits_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_AlternatingBits_Reference";
        String ICallable.FullName => "Grover.Oracle_AlternatingBits_Reference";
        protected IAdjointable<IQArray<Qubit>> FlipOddPositionBits_Reference
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
            var (queryRegister,target) = __in__;
#line 35 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            FlipOddPositionBits_Reference.Apply(queryRegister);
#line 36 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((queryRegister, target));
#line 37 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            FlipOddPositionBits_Reference.Adjoint.Apply(queryRegister);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (queryRegister,target) = __in__;
#line hidden
            FlipOddPositionBits_Reference.Adjoint.Adjoint.Apply(queryRegister);
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((queryRegister, target));
#line hidden
            FlipOddPositionBits_Reference.Adjoint.Apply(queryRegister);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.FlipOddPositionBits_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(FlipOddPositionBits_Reference));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> queryRegister, Qubit target)
        {
            return __m__.Run<Oracle_AlternatingBits_Reference, (IQArray<Qubit>,Qubit), QVoid>((queryRegister, target));
        }
    }

    public partial class FlipOddPositionBits_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public FlipOddPositionBits_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "FlipOddPositionBits_Reference";
        String ICallable.FullName => "Grover.FlipOddPositionBits_Reference";
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var register = __in__;
#line 45 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            foreach (var i in new Range(1L, 2L, (register.Length - 1L)))
#line hidden
            {
#line 46 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
                MicrosoftQuantumIntrinsicX.Apply(register[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var register = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, 2L, (register.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(register[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register)
        {
            return __m__.Run<FlipOddPositionBits_Reference, IQArray<Qubit>, QVoid>(register);
        }
    }

    public partial class Oracle_ArbitraryPattern_Reference : Adjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)>, ICallable
    {
        public Oracle_ArbitraryPattern_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_ArbitraryPattern_Reference";
        String ICallable.FullName => "Grover.Oracle_ArbitraryPattern_Reference";
        protected ICallable MicrosoftQuantumCanonControlledOnBitString
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,IQArray<Boolean>), QVoid> Body => (__in__) =>
        {
            var (queryRegister,target,pattern) = __in__;
#line 54 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((pattern, MicrosoftQuantumIntrinsicX)).Apply((queryRegister, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit,IQArray<Boolean>), QVoid> AdjointBody => (__in__) =>
        {
            var (queryRegister,target,pattern) = __in__;
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((pattern, MicrosoftQuantumIntrinsicX)).Adjoint.Apply((queryRegister, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> queryRegister, Qubit target, IQArray<Boolean> pattern)
        {
            return __m__.Run<Oracle_ArbitraryPattern_Reference, (IQArray<Qubit>,Qubit,IQArray<Boolean>), QVoid>((queryRegister, target, pattern));
        }
    }

    public partial class OracleConverterImpl_Reference : Adjointable<(IAdjointable,IQArray<Qubit>)>, ICallable
    {
        public OracleConverterImpl_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,IQArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "OracleConverterImpl_Reference";
        String ICallable.FullName => "Grover.OracleConverterImpl_Reference";
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

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IAdjointable,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markingOracle,register) = __in__;
#line hidden
            {
#line 62 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
                var target = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 64 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
                    MicrosoftQuantumIntrinsicX.Apply(target);
#line 65 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
                    MicrosoftQuantumIntrinsicH.Apply(target);
#line 69 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
                    markingOracle.Apply((register, target));
#line 72 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
                    MicrosoftQuantumIntrinsicH.Apply(target);
#line 73 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
                    MicrosoftQuantumIntrinsicX.Apply(target);
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
                    Release.Apply(target);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markingOracle,register) = __in__;
#line hidden
            {
#line hidden
                var target = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(target);
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Apply(target);
#line hidden
                    markingOracle.Adjoint.Apply((register, target));
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Apply(target);
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(target);
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
                    Release.Apply(target);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IAdjointable,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable markingOracle, IQArray<Qubit> register)
        {
            return __m__.Run<OracleConverterImpl_Reference, (IAdjointable,IQArray<Qubit>), QVoid>((markingOracle, register));
        }
    }

    public partial class OracleConverter_Reference : Function<IAdjointable, IAdjointable>, ICallable
    {
        public OracleConverter_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "OracleConverter_Reference";
        String ICallable.FullName => "Grover.OracleConverter_Reference";
        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> OracleConverterImpl_Reference
        {
            get;
            set;
        }

        public override Func<IAdjointable, IAdjointable> Body => (__in__) =>
        {
            var markingOracle = __in__;
#line 79 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            return OracleConverterImpl_Reference.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg1__) => (markingOracle, __arg1__)));
        }

        ;
        public override void Init()
        {
            this.OracleConverterImpl_Reference = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(OracleConverterImpl_Reference));
        }

        public override IApplyData __dataIn(IAdjointable data) => new QTuple<IAdjointable>(data);
        public override IApplyData __dataOut(IAdjointable data) => new QTuple<IAdjointable>(data);
        public static System.Threading.Tasks.Task<IAdjointable> Run(IOperationFactory __m__, IAdjointable markingOracle)
        {
            return __m__.Run<OracleConverter_Reference, IAdjointable, IAdjointable>(markingOracle);
        }
    }

    public partial class HadamardTransform_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public HadamardTransform_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HadamardTransform_Reference";
        String ICallable.FullName => "Grover.HadamardTransform_Reference";
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
            var register = __in__;
#line 91 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicH, register));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var register = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, register));
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register)
        {
            return __m__.Run<HadamardTransform_Reference, IQArray<Qubit>, QVoid>(register);
        }
    }

    public partial class ConditionalPhaseFlip_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public ConditionalPhaseFlip_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ConditionalPhaseFlip_Reference";
        String ICallable.FullName => "Grover.ConditionalPhaseFlip_Reference";
        protected ICallable<IAdjointable, IAdjointable> OracleConverter_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)> Oracle_ArbitraryPattern_Reference
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var register = __in__;
#line 106 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            var allZerosOracle = Oracle_ArbitraryPattern_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Boolean>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, QArray<Boolean>.Create(register.Length))));
#line 109 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            var flipOracle = OracleConverter_Reference.Apply(allZerosOracle);
#line 110 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            flipOracle.Apply(register);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.OracleConverter_Reference = this.Factory.Get<ICallable<IAdjointable, IAdjointable>>(typeof(OracleConverter_Reference));
            this.Oracle_ArbitraryPattern_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)>>(typeof(Oracle_ArbitraryPattern_Reference));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register)
        {
            return __m__.Run<ConditionalPhaseFlip_Reference, IQArray<Qubit>, QVoid>(register);
        }
    }

    public partial class PhaseFlip_ControlledZ : Adjointable<IQArray<Qubit>>, ICallable
    {
        public PhaseFlip_ControlledZ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PhaseFlip_ControlledZ";
        String ICallable.FullName => "Grover.PhaseFlip_ControlledZ";
        protected ICallable MicrosoftQuantumArraysMost
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysTail
        {
            get;
            set;
        }

        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var register = __in__;
#line 121 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicX, register));
#line 122 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(register), MicrosoftQuantumArraysTail.Apply<Qubit>(register)));
#line 123 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicX, register));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumArraysMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Most<>));
            this.MicrosoftQuantumArraysTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Tail<>));
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register)
        {
            return __m__.Run<PhaseFlip_ControlledZ, IQArray<Qubit>, QVoid>(register);
        }
    }

    public partial class GroverIteration_Reference : Adjointable<(IQArray<Qubit>,IAdjointable)>, ICallable
    {
        public GroverIteration_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IAdjointable)>, IApplyData
        {
            public In((IQArray<Qubit>,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "GroverIteration_Reference";
        String ICallable.FullName => "Grover.GroverIteration_Reference";
        protected IAdjointable<IQArray<Qubit>> ConditionalPhaseFlip_Reference
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> HadamardTransform_Reference
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (register,oracle) = __in__;
#line 134 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            oracle.Apply(register);
#line 135 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            HadamardTransform_Reference.Apply(register);
#line 136 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            ConditionalPhaseFlip_Reference.Apply(register);
#line 137 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            HadamardTransform_Reference.Apply(register);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IAdjointable), QVoid> AdjointBody => (__in__) =>
        {
            var (register,oracle) = __in__;
#line hidden
            HadamardTransform_Reference.Adjoint.Apply(register);
#line hidden
            ConditionalPhaseFlip_Reference.Adjoint.Apply(register);
#line hidden
            HadamardTransform_Reference.Adjoint.Apply(register);
#line hidden
            oracle.Adjoint.Apply(register);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ConditionalPhaseFlip_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(ConditionalPhaseFlip_Reference));
            this.HadamardTransform_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(HadamardTransform_Reference));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, IAdjointable oracle)
        {
            return __m__.Run<GroverIteration_Reference, (IQArray<Qubit>,IAdjointable), QVoid>((register, oracle));
        }
    }

    public partial class GroversSearch_Reference : Adjointable<(IQArray<Qubit>,IAdjointable,Int64)>, ICallable
    {
        public GroversSearch_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IAdjointable,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,IAdjointable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "GroversSearch_Reference";
        String ICallable.FullName => "Grover.GroversSearch_Reference";
        protected IAdjointable<(IQArray<Qubit>,IAdjointable)> GroverIteration_Reference
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> HadamardTransform_Reference
        {
            get;
            set;
        }

        protected ICallable<IAdjointable, IAdjointable> OracleConverter_Reference
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IAdjointable,Int64), QVoid> Body => (__in__) =>
        {
            var (register,oracle,iterations) = __in__;
#line 149 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            var phaseOracle = OracleConverter_Reference.Apply(oracle);
#line 150 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            HadamardTransform_Reference.Apply(register);
#line 152 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
            foreach (var i in new Range(1L, iterations))
#line hidden
            {
#line 153 "/Users/tkrollins/OneDrive/Courses/CS239/team_penguin/Q#/Grover/grover.qs"
                GroverIteration_Reference.Apply((register, phaseOracle));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IAdjointable,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (register,oracle,iterations) = __in__;
#line hidden
            var phaseOracle = OracleConverter_Reference.Apply(oracle);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, iterations)))
#line hidden
            {
#line hidden
                GroverIteration_Reference.Adjoint.Apply((register, phaseOracle));
            }

#line hidden
            HadamardTransform_Reference.Adjoint.Apply(register);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GroverIteration_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IAdjointable)>>(typeof(GroverIteration_Reference));
            this.HadamardTransform_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(HadamardTransform_Reference));
            this.OracleConverter_Reference = this.Factory.Get<ICallable<IAdjointable, IAdjointable>>(typeof(OracleConverter_Reference));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IAdjointable,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, IAdjointable oracle, Int64 iterations)
        {
            return __m__.Run<GroversSearch_Reference, (IQArray<Qubit>,IAdjointable,Int64), QVoid>((register, oracle, iterations));
        }
    }
}