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
        node1.Append(0);
        node1.Append(314);

        Assert.AreEqual<int>(node1.Next.Value, 314);
        Assert.AreEqual<int>(node1.Next.Next.Value, 0);

    }

    [TestMethod]
    public void Clear_Clears_Pass()
    {
        Node<int> node1 = new(42);
        Node<int> node2 = new(0);
        Node<int> node3 = new(314);
        node1.Append(0);
        node1.Append(314);

        node1.Clear();
        Assert.AreEqual(node1, node1.Next);

    }

    [TestMethod]
    public void Clear_CloseLoops_Pass()
    {
        Node<int> node1 = new(42);
        Node<int> node2 = new(0);
        Node<int> node3 = new(314);
        node1.Append(0);
        node1.Append(314);

        node1.Clear();
        Assert.AreEqual(node2, node2.Next);

        //Preserve Node2 in the case we want to use it in or as another Node

    }


    [TestMethod]
    public void Exists_ChecksValue_Pass()
    {
        Node<int> node1 = new(42);
        Node<int> node2 = new(0);
        Node<int> node3 = new(314);
        node1.Append(0);
        node1.Append(314);


        Assert.IsTrue(node1.Exists(0));
    }
    [TestMethod]
    public void Exists_ChecksOwnValue_Pass()
    {
        Node<int> node1 = new(42);
        Node<int> node2 = new(0);
        Node<int> node3 = new(314);
        node1.Append(0);
        node1.Append(314);

        Assert.IsTrue(node1.Exists(42));
    }

    [TestMethod]
    public void Exists_NonExistingValue_Fail()
    {
        Node<int> node1 = new(42);
        Node<int> node2 = new(0);
        Node<int> node3 = new(314);
        node1.Append(0);
        node1.Append(314);

        Assert.IsFalse(node1.Exists(1337));

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException),
    "Duplicate Value Detected")]
    public void Append_DuplicateValue_Throw()
    {
        Node<int> node1 = new(42);
        Node<int> node2 = new(0);
        Node<int> node3 = new(314);
        Node<int> node_duplicate = new(0);
        node1.Append(0);
        node1.Append(314);
        node1.Append(0);   
    }

}