namespace SimpleTree.Core
{
    using System.Collections.Generic;

    public interface INode<T>
    {
        Node<T> GetParent();

        void SetParent(Node<T> root);

        T GetData();

        void SetData(T value);

        Node<T> AddChild(Node<T> child);

        Node<T> AddChild(T value);

        LinkedList<Node<T>> GetChildren();
        
        Node<T> GetChild(int index);
    }
}