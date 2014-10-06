using System;
using System.Collections.Generic;

// Achtung: Vorgabe kompiliert nicht 
namespace IteratorVorgabe
{
    public class RecList<T>
    {
        public class Node
        {
            public Node next;
            public T val;
            public Node(T val) { this.val = val; this.next = null; }
        }

        private Node root = null, tail = null;

        public RecList()
        {
            root = new Node(default(T));
            tail = root;
        }
        public void Append(T val)
        { // Füge Element am Ende der Liste an
            tail.next = new Node(val);
            tail = tail.next;
        }
    }
}