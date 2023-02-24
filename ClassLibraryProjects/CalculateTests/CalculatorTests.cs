using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculate;

namespace CalculateTests;

[TestClass]
public class CalculatorTests
{

    [TestMethod]
    public void ProgramWriteLine_WritesToConsole_Pass()
    {
        string testLine = "I'm on the console.";
        Program testPr = new();
        StringWriter output = new();
        Console.SetOut(output);
        string expected = string.Format(testLine + "{0}", Environment.NewLine);
        testPr.WriteLine(testLine);
        string actual = output.ToString();

        Assert.AreEqual<string>(expected, actual);  
    }

    [TestMethod]
    public void ProgramReadLine_ReadsFromConsole_Pass()
    {
        string expected = "I'm on the console.";
        Program testPr = new();
        StringReader input = new(expected);
        Console.SetIn(input);
        string actual = testPr.ReadLine();

        Assert.AreEqual<string>(expected, actual);
    }


    [TestMethod]
    public void CalculatorDictionary_ContainsProprerValues_Pass()
    {
        Calculator testCalculator = new();
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
    public void TryCalculate_ParseCommands_Pass()
    {
        Calculator testCalculator = new();
        int results;
        testCalculator.TryCalculate("30 + 12", out results);
        Assert.AreEqual<int?>(42, results);
        testCalculator.TryCalculate("30 - 12", out results);
        Assert.AreEqual<int?>(18, results);
        testCalculator.TryCalculate("30 * 12", out results);
        Assert.AreEqual<int?>(360, results);
        testCalculator.TryCalculate("30 / 12", out results);
        Assert.AreEqual<int?>(2, results);        
    }

    [TestMethod]
    public void CalculatorFuncs_Result_Pass()
    {
        Calculator testCalculator = new();
        Func<int, int, int> testAdd = Calculator.Add;
        Func<int, int, int> testSub = Calculator.Subtract;
        Func<int, int, int> testMult = Calculator.Multiply;
        Func<int, int, int> testDiv = Calculator.Divide;



        Assert.AreEqual<int?>(testAdd(30, 12), 42);
        Assert.AreEqual<int?>(testSub(30, 12), 18);
        Assert.AreEqual<int?>(testMult(30, 12), 360);
        Assert.AreEqual<int?>(testDiv(30, 12), 2);
    }

    [TestMethod]
    public void TryCalculate_InvalidCommands_Fail()
    {
        Calculator testCalculator = new();
        int results = 0;

        Assert.IsFalse(testCalculator.TryCalculate("30+12", out results));
        Assert.IsFalse(testCalculator.TryCalculate("30.1 + 12", out results));
        Assert.IsFalse(testCalculator.TryCalculate("30 z 12", out results));
    }

}
