using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Tests
{
    [TestClass]
    public class SampleDataTests
    {
        string file = "People.csv";
        [TestMethod]
        public void MyTestMethod()
        {
            SampleData testData = new();
            int lineCount = 0;
            using(StreamReader input = new StreamReader(file)) {
                string? line;
                input.ReadLine();
                while((line = input.ReadLine()) != null) {
                    Assert.AreEqual<string>(line, testData.CsvRows.ElementAt(lineCount));
                    lineCount++;
                }
            }

            Assert.AreEqual<int>(lineCount, testData.CsvRows.Count());
        }
    }
}
