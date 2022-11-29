﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_LinkedList_Batch222
{
    public class LinkedList
    {
        internal Node head;
        internal void AddLast(int data)
        {
            Node newNode = new Node(data);//creating new node and passsing data

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted in to Linked list at last position", newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("Display of Nodes");
            Node temp = this.head;
            int pos = 1;
            if(temp==null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write("position :"+pos+" Data " + temp.data + " \n");              
                    temp = temp.next;
                    pos++;
                }
            }
        }
        public void AddAtFirst(int data)
        {
            Node newNode1 = new Node(data);//creating new node and passsing data
            newNode1.next = head;
            head = newNode1;
            Console.WriteLine("{0} is inserted in to Linked list at first position ", newNode1.data);
        }
        internal void InsertBetween(int previous, int data, int after)
        {
            Node temp = head;
            Node newnode = new Node(data);
            Node store;
            while (temp != null)
            {
                if (temp.data == previous && temp.next.data == after)
                {
                    store = temp.next;
                    temp.next = newnode;
                    newnode.next = store;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }
    }
}
