using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsHomeworkTests;

[TestClass]
public class NodeTests
{
    [TestMethod]
    public void Node_TypeString_Pass()
    {
        string testValue = "Test Value";
        Node<string> test = new(testValue);

        Assert.AreEqual<string>(testValue, test.Value);
    }

    [TestMethod]
    public void Node_TypeInt_Pass()
    {
        int testValue = 42;
        Node<int> test = new(testValue);

        Assert.AreEqual<int>(testValue, test.Value);
    }

    [TestMethod]
    public void ToString_ValueToString_Pass()
    {
        int testValue = 42;
        Node<int> test = new(testValue);

        Assert.AreEqual<string>(testValue.ToString(), test.ToString());
    }
}