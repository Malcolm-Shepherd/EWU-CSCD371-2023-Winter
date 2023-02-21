using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculate;

namespace CalculateTests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void OnConstruction_CalculatorProperties_Pass()
    {
        Calculator testCalculator = new Calculator();
    }

    [TestMethod]
    public void ProgramWriteLine_WritesToConsole_Pass()
    {
        string testLine = "I'm on the console.";/*
        Action<string> write = (string text) => { Console.WriteLine(text); };*/
        Program testPr = new Program();
        testPr.WriteLine(testLine);
    }

    //Waits for input from console, but never prompts a console.
    /*    [TestMethod]
        public void ProgramReadLine_ReadsFromConsole_Pass()
        {
            Program testPr = new Program();

            string? testLine = testPr.ReadLine();
        }*/

    [TestMethod]
    public void CalculatorDictionary_ContainsProprerValues_Pass()
    {
        Calculator testCalculator = new Calculator();
        Func<int, int, int> testAdd = Calculator.Add;
        Func<int, int, int> testSub = Calculator.Subtract;
        Func<int, int, int> testMult = Calculator.Multiply;
        Func<int, int, int> testDiv = Calculator.Divide;

        Assert.IsTrue(testCalculator.MathematicalOperations.TryGetValue('+', out testAdd!));
        Assert.IsTrue(testCalculator.MathematicalOperations.TryGetValue('-', out testSub!));
        Assert.IsTrue(testCalculator.MathematicalOperations.TryGetValue('*', out testMult!));
        Assert.IsTrue(testCalculator.MathematicalOperations.TryGetValue('/', out testDiv!));


    }


    [TestMethod]
    public void TryCalculate_ParseCommands_pass()
    {
        Calculator testCalculator = new Calculator();
        Func<int, int, int> testAdd = Calculator.Add;
        Func<int, int, int> testSub = Calculator.Subtract;
        Func<int, int, int> testMult = Calculator.Multiply;
        Func<int, int, int> testDiv = Calculator.Divide;



        Assert.AreEqual(testAdd(30, 12), testCalculator.TryCalculate("30 + 12"));
        Assert.AreEqual(testSub(30, 12), testCalculator.TryCalculate("30 - 12"));
        Assert.AreEqual(testMult(30, 12), testCalculator.TryCalculate("30 * 12"));
        Assert.AreEqual(testDiv(30, 12), testCalculator.TryCalculate("30 / 12"));        
    }
}
