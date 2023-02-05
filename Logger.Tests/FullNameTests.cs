using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;

namespace Logger.Tests;

[TestClass]
public class FullNameTests
{
    [TestMethod]
    public void FullName_Initializes_Pass()
    {
        string first = "Malcolm";
        string middle = "O";
        string last = "Shepherd";
        FullName me = new(first, last, middle);
        
        Assert.AreEqual<string>(first, me.FirstName);
        Assert.AreEqual<string>(last, me.LastName);
        Assert.AreEqual<string>(middle, me.MiddleName!);
    }

    [TestMethod]
    public void FullName_NullCheck_Pass()
    {
        ArgumentNullException firstNull = null;

        try { FullName first = new(null, "a", "b"); }
        catch (ArgumentNullException ex) { firstNull = ex; }
        Assert.IsNotNull(firstNull);


        ArgumentNullException lastNull = null;

        try { FullName last = new("c", null, "d"); }
        catch (ArgumentNullException ex) { lastNull = ex; }
        Assert.IsNotNull(lastNull);


        ArgumentNullException middleNull = null;

        try { FullName middle = new("e", "f", null); }
        catch (ArgumentNullException ex) { middleNull = ex; }
        Assert.IsNull(middleNull);
    }
}

