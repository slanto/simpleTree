namespace SimpleTree.Core
{
    using System.Collections.Generic;

    public class Node
    {
        public string Data  { get; private set; }

        public LinkedList<string> Children { get; private set; }

        private Node parent;

        public Node(string data)
        {
            this.Data = data;
            this.Children = new LinkedList<string>();
            // without parent
            this.parent = null;
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
    }
}