using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests;

[TestClass]
public class EntityTests
{
    [TestMethod]
    public void Book_Implements_Entity()
    {
        string testName = "BookName";
        Book book = new(testName);

        Assert.AreEqual<string>(testName, book.Name);
    }

    [TestMethod]
    public void Person_Implemenets_Entity()
    {
        FullName testName = new("Dude", "Guy");
        Person testPerson = new(testName);

        Assert.AreEqual(testName.ToString(), testPerson.Name);
    }
}