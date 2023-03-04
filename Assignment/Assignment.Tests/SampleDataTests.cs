using Assignment;
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
                string? line = input.ReadLine();
                Assert.AreNotEqual<string>(line!, testData.CsvRows.First());
                while ((line = input.ReadLine()) != null)
                {
                    Assert.AreEqual<string>(line, testData.CsvRows.ElementAt(lineCount));
                    lineCount++;
                }
            }

            Assert.AreEqual<int>(lineCount, testData.CsvRows.Count());
        }
    }
}

[TestClass]
public class GetUniqueSortedListOfStatesGivenCsvRowsTests
{
/*    [TestInitialize]
    public void AssemblyInitialize()
    {
        //source = csvrows()
    }*/
    [TestMethod]
    public void CsvRowList_ReturnsListOfStates_Pass()
    {
        Assert.IsFalse(true);
    }
    [TestMethod]
    public void CsvRowList_isUnique_Pass()
    {
        SampleData testData = new();
        IEnumerable<string> uniqueStates = testData.GetUniqueSortedListOfStatesGivenCsvRows();
        foreach(string item in uniqueStates) 
        { 
            Assert.AreEqual<int>(1, uniqueStates.Where(state => state == item).Count());
        }  
    }
    [TestMethod]
    public void CsvRowList_isSorted_Pass()
    {
        SampleData testData = new();
        IEnumerable<string> sortedStates = testData.GetUniqueSortedListOfStatesGivenCsvRows();
        string prev = sortedStates.First();
        foreach(string item in sortedStates) 
        {
            if (prev != item) 
            { 
                Assert.IsTrue(prev.CompareTo(item) < 0); 
            }
            prev = item;
        }
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
    /*   [AssemblyInitialize]
       public void AssemblyInitialize()
       {
           //source = getaggregatesortedlistofstatesusingcsvrows()
       }*/
    [TestMethod]
    public void GetAggregate_CommaSeperatedListString_Pass()
    {
        SampleData testData = new();
        string states = testData.GetAggregateSortedListOfStatesUsingCsvRows();
        Assert.AreEqual<string>("hi", states);
    }
}

[TestClass]
public class PeopleTests
{
/*    [AssemblyInitialize]
    public void AssemblyInitialize()
    {
        //source = csvrows()
    }*/
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
/*    [TestInitialize]
    public void AssemblyInitialize()
    {
        //source = people()
    }*/
    [TestMethod]
    public void Filter_ReturnsListThatMatchEmail_Pass()
    {
        Assert.IsFalse(true);
    }
}

[TestClass]
public class GetAggregateListOfStatesGivenPeopleCollectionTests
{
/*    [AssemblyInitialize]
    public void AssemblyInitialize()
    {
        //source = people()
    }*/
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

