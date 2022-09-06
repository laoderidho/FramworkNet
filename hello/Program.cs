// See https://aka.ms/new-console-template for more information
using System.Reflection;

Assembly? assembly = Assembly.GetEntryAssembly();

if(assembly==null) return;

foreach(AssemblyName name in assembly.GetReferencedAssemblies){
    Assembly a = Assembly.Load(name);
    int methodCount = 0; 
    foreach(TypeInfo t in a.DefinedTypes){
        methodCount += t.GetMethods().Count();
    }
    Console.WriteLine("{0:NO} types with {1:NO} methofd in {2} assembly.", arg0: a.DefinedTypes.Count(), arg1: methodCount, arg2: name.Name);
}