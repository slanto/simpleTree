namespace SimpleTree.Core
{
    using System.Collections.Generic;

    public class Node<T>
    {
        private T data;

        public LinkedList<Node<T>> Children { get; private set; }

        private Node<T> parent;

        public Node()
        {
            this.parent = null;
            this.Children = new LinkedList<Node<T>>();
        }

        public Node(T data) : this()
        {
            this.data = data;        
        }

        public Node(T data, Node<T> parent) : this(data)
        {            
            this.parent = parent;
        }

        public Node<T> GetParent()
        {
            return this.parent;
        }

        public void SetParent(Node<T> node)
        {
            this.parent = node;
        }

        public T GetData()
        {
            return this.data;
        }

        public void SetData(T d)
        {
            this.data = d;
        }

        public Node<T> AddChild(Node<T> child)
        {
            child.SetParent(this);
            this.Children.AddLast(child);
            return child;            
        }

        public Node<T> AddChild(T value)
        {
            var child = new Node<T>(value, this);
            this.Children.AddLast(child);
            return child;
        }
    }
}