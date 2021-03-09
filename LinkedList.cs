using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        private class Node
        {
            //private int value;
            public int value { get; set; }
            public Node next { get; set; }

            public Node(int value)
            {
                this.value = value;
            }
        }


        // Implementing LinkedList
        private Node head;
        private Node tail;

        // Add Last
        public void AddLast(int value)
        {
            Node node = new Node(value);
            if(head == null)
            {
                head = tail = node;
            } 
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        // Print LinkedList
        public string print()
        {
            string list = "";
            Node current = head;
            while (current.next != null)
            {
                list += current.value + " ";
                current = current.next;
            }
            return list;
        }
    }
}
