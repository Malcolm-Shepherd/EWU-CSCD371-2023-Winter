

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
            Func<string> read = Console.ReadLine;
            return read;
        }
        init 
        { 
            ReadLine = value;   
        }
    }

    public static void Main(string[] args) 
    {
        
    }
}