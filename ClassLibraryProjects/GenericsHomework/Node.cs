using System.Data;
using System.Runtime.InteropServices;

namespace GenericsHomework
{
    public class Node<T>
    {
        private Node<T>? _Next;
        public T Value { get; set; }
        
        // I don't know how to unit test for null with the way Next is being used. //
        public Node<T> Next
        {
            get
            {
                return _Next!;
            }
            private set
            { 
                _Next = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public Node(T value) 
        { 
            Value = value;
            Next = this;
        }

        public override string ToString() 
        {
            return this.Value!.ToString()!;
        }

        public void Append(Node<T> nextNode) 
        { 
            if (this.Exists(nextNode.Value))
            {
                throw new ArgumentException("Duplicate Value detected");
            }

            nextNode.Next = this.Next;
            this.Next = nextNode;    
        }

        public void Clear()
        {
            Node<T> cur = this.Next;
            Node<T> temp = cur;
            while (cur != this)
            {
                cur = cur.Next;
                temp.Next = temp;
                temp = cur;
            }
            this.Next = cur;

            // There is no need to collect garbage. C# .Net automatically collects garbage on memory space that is no longer used
        }

        public bool Exists(T value)
        {
            Node<T> cur = this;

            do
            {
                if (value.Equals(cur.Value))
                { return true; }
                cur = cur.Next;
            }
            while (cur != this);

            return false;

        }
    }
}