namespace SimpleTree.Core
{
    using System.Collections.Generic;

    public class Node<T>
    {
        private T data;

        private LinkedList<Node<T>> children;

        private Node<T> parent;

        public Node()
        {
            this.parent = null;
            this.children = new LinkedList<Node<T>>();
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

        public void SetParent(Node<T> root)
        {
            this.parent = root;
        }

        public T GetData()
        {
            return this.data;
        }

        public void SetData(T value)
        {
            this.data = value;
        }

        public Node<T> AddChild(Node<T> child)
        {
            child.SetParent(this);
            this.children.AddLast(child);
            return child;            
        }

        public Node<T> AddChild(T value)
        {
            var child = new Node<T>(value, this);
            this.children.AddLast(child);
            return child;
        }

        public LinkedList<Node<T>> GetChildren()
        {
            return this.children;
        }
    }
}