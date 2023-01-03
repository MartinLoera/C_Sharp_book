// using System.Reflection;

//Unused variables using types 
// System.Data.DataSet ds; 
// HttpClient client;


// Assembly? assembly = Assembly.GetEntryAssembly();
// if (assembly == null) return; 

// foreach (AssemblyName name in assembly.GetReferencedAssemblies())
// {
//     //Load the assembly
//     Assembly a = Assembly.Load(name);
//     //Declare a variable for count the number of methods
//     int methodCount = 0;

//     //Loop through all the types in the assembly
//     foreach (TypeInfo t in a.DefinedTypes)
//     {
//         methodCount += t.GetMethods().Count();
//     }

//     Console.WriteLine(
//     "{0:N0} types with {1:N0} methods in {2} assembly.",
//     arg0: a.DefinedTypes.Count(),
//     arg1: methodCount, arg2: name.Name);
// }


double heightInMetres = 1.88;
Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}");

string filePath = @"C:\televisions\sony\bravia.txt";
Console.WriteLine(filePath);

//Only positive
uint numeroUno = 5;
// integers means negative and postivie whole number or 0 
int numeroDos = -323;
