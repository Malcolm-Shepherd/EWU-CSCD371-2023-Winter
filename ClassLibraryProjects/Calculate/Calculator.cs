using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate;

public class Calculator
{
    
    public System.Collections.Generic.IReadOnlyDictionary<char, Func<string, string, int>> MatematicalOperations { get; }
}
