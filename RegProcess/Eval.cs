using System;
using System.Collections.Generic;
using System.Text;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.CSharp;

namespace hz
{
    public class Eval
    {
        public static object Get(string value)
        {
            string codeSnippet =
    @"using System;   
namespace hz {
   public class _Eval
   {
        public object GetValue()
        {
            return " + value + @";
        }
   }   
}";

            CodeSnippetCompileUnit unit = new CodeSnippetCompileUnit(codeSnippet);
            CompilerParameters para = new CompilerParameters();
            para.ReferencedAssemblies.Add("System.dll");
            para.GenerateInMemory = true;
            para.GenerateExecutable = false;
            //para.OutputAssembly = "Eval.dll";
            Assembly asm = new CSharpCodeProvider().CompileAssemblyFromDom(para, unit).CompiledAssembly;

            Type type = asm.GetType("hz._Eval");
            MethodInfo mi = type.GetMethod("GetValue", BindingFlags.Public | BindingFlags.Instance);
            object obj = Activator.CreateInstance(type);
            return mi.Invoke(obj, null);
        }

    }
}