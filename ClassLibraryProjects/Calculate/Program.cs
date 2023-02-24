

using Calculate;
using System.Runtime.CompilerServices;

public class Program
{
    public Action<string> WriteLine{ get; init; } = Console.WriteLine;

    public Func<string> ReadLine{ get; init; } = Console.ReadLine!;

    public Program() { }

    public static void Main(string[] args) 
    {
        Calculator calculator = new Calculator();
        Program program = new Program();    
        int result = 0;
        bool valid = true;
        while(valid) 
        {
            program.WriteLine("Enter an equation:");
            string equation = program.ReadLine.Invoke();
            valid = calculator.TryCalculate(equation, out result);
            if (valid)
            {
                program.WriteLine(result.ToString()!);
            }
        }

        program.WriteLine("Good Bye!");
    }
}