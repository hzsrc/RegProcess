using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;

namespace RegProcess
{
	public class CsBuilder
	{
		public static MethodInfo GetMethod(RepItem item)
		{
			string text = "_Rep" + item.GetHashCode().ToString().Replace("-", "_");
            string value = @"
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;
using System.Data;
using System.Reflection;
namespace hz {
   public class " + text + @"
   {
        " + item.RepalceToRN() + @"
   }   
}";
            CodeSnippetCompileUnit codeSnippetCompileUnit = new CodeSnippetCompileUnit(value);
			CompilerParameters compilerParameters = new CompilerParameters();
			compilerParameters.ReferencedAssemblies.Add("System.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Data.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Xml.dll");
			compilerParameters.GenerateInMemory = true;
			compilerParameters.GenerateExecutable = false;
			CompilerResults compilerResults = new CSharpCodeProvider().CompileAssemblyFromDom(compilerParameters, codeSnippetCompileUnit);
			if (compilerResults.Errors.HasErrors)
			{
				throw new Exception(compilerResults.Errors[0].Line + "," + compilerResults.Errors[0].Column + ":" + compilerResults.Errors[0].ErrorText);
			}
			Assembly compiledAssembly = compilerResults.CompiledAssembly;
			Type type = compiledAssembly.GetType("hz." + text);
			return type.GetMethod("ReplaceEach", BindingFlags.Static | BindingFlags.Public);
		}
	}
}
