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
    public System.Collections.Generic.IReadOnlyDictionary<char, Func<int, int, int>> MatematicalOperations 
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
}
