using System.Data;
using System.Runtime.InteropServices;

namespace GenericsHomework
{
    public class Node<T>
    {
        private Node<T>? _next;
        public T Value { get; set; }
        
        // I don't know how to unit test for null with the way Next is being used. //
        public Node<T> Next
        {
            get
            {
                return _next!;
            }
            private set
            { 
                _next = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public Node(T value) 
        { 
            Value = value;
            Next = this;
        }

        public override string ToString() 
        {
            if (Value is null) return string.Empty;
            else return Value.ToString() ?? string.Empty;
        }

        public void Append(T value) 
        { 

            if (Exists(value))
            {
                throw new ArgumentException("Duplicate Value detected");
            }
            Node<T> nextNode = new Node<T>(value);
            nextNode.Next = Next;
            Next = nextNode;    
        }

        public void Clear()
        {
            Next = this;

            // There is no need to collect garbage. C# .Net automatically collects garbage on memory space that is no longer used
            // Nothing points to the nodes that are cut off, so they will eventually be collected.
        }

        public bool Exists(T value)
        {
            Node<T> cur = this;

            do
            {
                if (Equals(value, cur.Value))
                { return true; }
                cur = cur.Next;
            }
            while (cur != this);

            return false;

        }
    }
}