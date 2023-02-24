using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate;

public class Calculator
{
    public static Func<int, int, int> Add => (x, y) => x + y;
    public static Func<int, int, int> Subtract => (x, y) => x - y;
    public static Func<int, int, int> Multiply => (x, y) => x * y;
    public static Func<int, int, int> Divide => (x, y) => x / y;

    //Read only as there is not way to set it.
    public System.Collections.Generic.IReadOnlyDictionary<char, Func<int, int, int>> MathematicalOperations 
    { get 
        {
            Dictionary<char, Func<int, int, int>> operators = new();
            operators.Add('+', Add);
            operators.Add('-', Subtract);
            operators.Add('*', Multiply);
            operators.Add('/', Divide);

            return operators;
        } 
    }

    public bool TryCalculate(string calculation, out int result)
    {
        result = 0;
        string[] calcvars = calculation.Split(' ');
        int operand1;
        int operand2;

        if (calcvars.Length != 3)
            return false;

        try
        {
            operand1 = Int32.Parse(calcvars[0]);
            operand2 = Int32.Parse(calcvars[2]);
        }
        catch
        {
            return false;
        }

        Func<int, int, int> operation;
        try
        {
            operation = MathematicalOperations[calcvars[1][0]];
        }
        catch (System.Collections.Generic.KeyNotFoundException) 
        {
            return false;
        }
        result = operation(operand1, operand2);
        return true;

    }
}
