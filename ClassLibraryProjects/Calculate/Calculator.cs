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

    public int TryCalculate(string calculation)
    {

        String[] calcvars = calculation.Split(' ');

        if (calcvars.Length != 3)
            return false;


        int operand1 = Int32.Parse(calcvars[0]);
        int operand2 = Int32.Parse(calcvars[2]);

        switch (calcvars[1])
        {
            case "+":
                return Calculator.Add(operand1, operand2);
                break; 
        }
    }
}
