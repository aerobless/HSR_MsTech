// Copyright (C) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections;
using System.Text;

public class MyList<T> : IEnumerable {
    protected Node<T> head;
    protected Node<T> current = null;

    
    protected class Node<T> {
        public Node<T> next;
       
        private T data;
        
        public Node(T t) {
            next = null;
            data = t;
        }
        public Node<T> Next {
            get { return next; }
            set { next = value; }
        }
        
        public T Data {
            get { return data; }
            set { data = value; }
        }
    }

    public MyList() {
        head = null;
    }

    public void Add(T t) {
        Node<T> n = new Node<T>(t);
        n.Next = head;
        head = n;
    }

    public IEnumerator GetEnumerator() {
        Node<T> curr = head;
        while (curr != null) {
            yield return curr.Data;
            curr = curr.Next;
        }
    }
}

public class SortedList<T> : MyList<T> where T: IComparable {
    // A simple, unoptimized sort algorithm that 
    // orders list elements from lowest to highest:
    public void BubbleSort() {
        if (null == head || null == head.Next)
            return;
        bool swapped;
        do {
            Node<T> previous = null;
            Node<T> curr = head;
            swapped = false;
            while (curr.next != null) {
                IComparable comp = curr.Data as IComparable;
                if (comp == null)
                    throw new Exception("data-object must implement ICOmparable");

                if (comp.CompareTo(curr.next.Data) > 0) {
                    Node<T> tmp = curr.next;
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

