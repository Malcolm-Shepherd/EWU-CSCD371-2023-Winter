using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Tests
{
    [TestClass]
    public class CsvRowsTests
    {
        string file = "People.csv";
        [TestMethod]
        public void MyTestMethod()
        {
            SampleData testData = new();
            int lineCount = 0;
            using (StreamReader input = new StreamReader(file))
            {
                string? line;
                input.ReadLine();
                while ((line = input.ReadLine()) != null)
                {
                    Assert.AreEqual<string>(line, testData.CsvRows.ElementAt(lineCount));
                    lineCount++;
                }
            }

            Assert.AreEqual<int>(lineCount, testData.CsvRows.Count());
        }
    }

    [TestClass]
    public class GetUniqueSortedListOfStatesGivenCsvRowsTests
    {
        [AssemblyInitialize]
        public void AssemblyInitialize()
        {
            //source = csvrows()
        }
        [TestMethod]
        public void CsvRowList_ReturnsListOfStates_Pass()
        {
            Assert.IsFalse(true);
        }
        [TestMethod]
        public void CsvRowList_isUnique_Pass()
        {
            Assert.IsFalse(true);
        }
        [TestMethod]
        public void CsvRowList_isSorted_Pass()
        {
            Assert.IsFalse(true);
        }
        [TestMethod]
        public void CsvRowList_AccuratetoAddresses_Hardcoded_Pass()
        {
            Assert.IsFalse(true);
        }
        [TestMethod]
        public void CsvRowList_AccuratetoAddresses_LINQ_Pass()
        {
            Assert.IsFalse(true);
        }
        
    }



    [TestClass]
    public class GetAggregateSortedListOfStatesUsingCsvRowsTests
    {
        [AssemblyInitialize]
        public void AssemblyInitialize()
        {
            //source = getaggregatesortedlistofstatesusingcsvrows()
        }
        [TestMethod]
        public void GetAggregate_CommaSeperatedListString_Pass()
        {
            Assert.IsFalse(true);
        }
    }

    [TestClass]
    public class PeopleTests
    {
        [AssemblyInitialize]
        public void AssemblyInitialize()
        {
            //source = csvrows()
        }
        [TestMethod]
        public void People_ReturnsMultiplePersons_Pass()
        {
            Assert.IsFalse(true);
        }
        [TestMethod]
        public void People_Sorted_Pass()
        {
            Assert.IsFalse(true);
        }
        [TestMethod]
        public void People_AddressesPopulated_Pass()
        {
            Assert.IsFalse(true);
        }
        
    }

    [TestClass]
    public class FilterByEmailAddressTests
    {
        [AssemblyInitialize]
        public void AssemblyInitialize()
        {
            //source = people()
        }
        [TestMethod]
        public void Filter_ReturnsListThatMatchEmail_Pass()
        {
            Assert.IsFalse(true);
        }
    }

    [TestClass]
    public class GetAggregateListOfStatesGivenPeopleCollectionTests
    {
        [AssemblyInitialize]
        public void AssemblyInitialize()
        {
            //source = people()
        }
        [TestMethod]
        public void Test()
        {
            Assert.IsFalse(true);
        }
    }

    [TestClass]
    public class NodeEnumerableTests
    {
        [TestMethod]
        public void IEnumerable_ReturnsAllItemsInCircle_Pass()
        {
            Assert.IsFalse(true);
        }
    }

}
