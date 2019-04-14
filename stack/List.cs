using System;
using System.Collections.Generic;
//TODO: System.Collections.Generic;
// where T : IComparable

namespace stack
{
    public class List<T> : IList where T : IComparable
    {
        private Node _head;
//        public int ll { get; private set; }

        private void AddElement(Node previous, T value)
        {
            previous.Next = new Node(value);
        }

        public void AddElement(int value) => AddElement(_head, value);
        public bool FindValue(int value) => FindValue(_head, value);
        public void DeleteValue(int value) => DeleteValue(_head, value);
        private bool FindValue(Node first, int value)
        {
            if (first.Value == value)
            {
                return true;
            }

            if (first.Next == null)
            {
                return false;
            }
            return FindValue(first.Next, value);
        }
        private void DeleteValue(Node root, int value)
        {
            if (FindValue(root, value) == false)
            {
                throw new ArgumentException("No such value in this list");
            }

            if (root.Next.Value == value)
            {
                root = root.Next; //TODO: исправить
            }
            else
            {
                DeleteValue(root.Next, value);
            }
        }
        
        private class Node
        {
            public readonly int Value;
            public Node Next;

            public Node(int value)
            {
                this.Value = value;
            }
        }
    }
}