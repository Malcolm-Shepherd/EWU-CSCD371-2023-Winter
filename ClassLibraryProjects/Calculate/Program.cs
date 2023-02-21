

using Calculate;
using System.Runtime.CompilerServices;

public class Program
{
    public Action<string> WriteLine{ 
        get 
        { 
            Action<string> action = Console.WriteLine;
            return action;
        }
        init 
        {
            WriteLine = value;
        }
    }

    public Func<string> ReadLine
    {
        get 
        {
            Func<string> read = Console.ReadLine!;
            return read;
        }
        init 
        { 
            ReadLine = value;   
        }
    }

    public Program() { }

    public static void Main(string[] args) 
    {
        Calculator calculator = new Calculator();
        Program program = new Program();    
        int? result = 0;

        while(result is not null) 
        {
            program.WriteLine("Enter an equation:");
            string equation = program.ReadLine.Invoke();
            result = calculator.TryCalculate(equation);
            if (result is not null)
            {
                program.WriteLine(result.ToString()!);
            }
        }

        program.WriteLine("Good Bye!");
    }
}