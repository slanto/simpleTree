namespace SimpleTree.Core
{
    using System.Collections.Generic;

    public class Node
    {
        private string data;

        public LinkedList<string> Children { get; private set; }

        private Node parent;

        public Node()
        {
            this.parent = null;
            this.Children = new LinkedList<string>();
        }

        public Node(string data) : this()
        {
            this.data = data;        
        }

        public Node(string data, Node parent) : this(data)
        {            
            this.parent = parent;
        }

        public Node GetParent()
        {
            return this.parent;
        }

        public void SetParent(Node node)
        {
            this.parent = node;
        }

        public string GetData()
        {
            return this.data;
        }

        public void SetData(string d)
        {
            this.data = d;
        }
    }
}