// Copyright (C) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections;
using System.Text;

public class MyList : IEnumerable {
    protected Node head;
    protected Node current = null;

    
    protected class Node {
        public Node next;
       
        private object data;
        
        public Node(object t) {
            next = null;
            data = t;
        }
        public Node Next {
            get { return next; }
            set { next = value; }
        }
        
        public object Data {
            get { return data; }
            set { data = value; }
        }
    }

    public MyList() {
        head = null;
    }

    public void Add(object t) {
        Node n = new Node(t);
        n.Next = head;
        head = n;
    }

    public IEnumerator GetEnumerator() {
        Node curr = head;
        while (curr != null) {
            yield return curr.Data;
            curr = curr.Next;
        }
    }
}

public class SortedList : MyList {
    // A simple, unoptimized sort algorithm that 
    // orders list elements from lowest to highest:
    public void BubbleSort() {
        if (null == head || null == head.Next)
            return;
        bool swapped;
        do {
            Node previous = null;
            Node curr = head;
            swapped = false;
            while (curr.next != null) {
                IComparable comp = curr.Data as IComparable;
                if (comp == null)
                    throw new Exception("data-object must implement ICOmparable");

                if (comp.CompareTo(curr.next.Data) > 0) {
                    Node tmp = curr.next;
                    curr.next = curr.next.next;
                    tmp.next = curr;

                    if (previous == null) {
                        head = tmp;
                    } else {
                        previous.next = tmp;
                    }
                    previous = tmp;
                    swapped = true;
                } else {
                    previous = curr;
                    curr = curr.next;
                }
            }// end while
        } while (swapped);
    }
}

