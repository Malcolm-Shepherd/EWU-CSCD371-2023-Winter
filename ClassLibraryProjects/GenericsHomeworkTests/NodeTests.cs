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

    [TestMethod]
    public void Append_Appends_Pass()
    {
        Node<int> node1 = new(42);
        Node<int> node2 = new(0);
        Node<int> node3 = new(314);
        node1.Append(node2);
        node2.Append(node3);

        Assert.AreEqual<Node<int>>(node1.Next, node2);
        Assert.AreEqual<Node<int>>(node2.Next, node3);
        Assert.AreEqual<Node<int>>(node3.Next, node1);

    }
}