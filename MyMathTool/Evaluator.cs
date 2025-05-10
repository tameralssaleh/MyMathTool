using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Threading.Tasks;

public class Evaluator
{
    public static async Task<double> EvaluateExpressionAsync(string expression)
    {
        var result = await CSharpScript.EvaluateAsync<double>(
            expression,
            ScriptOptions.Default.WithImports("System", "System.Math")
        );
        return result;
    }
}
