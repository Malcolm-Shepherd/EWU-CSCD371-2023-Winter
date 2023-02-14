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
            nextNode.Next = this.Next;
            this.Next = nextNode;    
        }
    }
}