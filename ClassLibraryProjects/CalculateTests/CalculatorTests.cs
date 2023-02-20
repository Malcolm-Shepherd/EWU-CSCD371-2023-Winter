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

    [TestMethod]
    public void ProgramReadLine_ReadsFromConsole_Pass()
    {
        Program testPr = new Program();

        string testLine = testPr.ReadLine();
    }
}
