using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.LinkedList
{
    public class LinkedList
    {
        public Node? head;
        public int Length { get; set; }

        public LinkedList()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddToHead(int newValue)
        {
            Node node = new Node(newValue);
            if (IsEmpty()) {
                head = node;
                Length++;
            }
            else
            {
                node.Next = head;
                head = node;
                Length++;
            }
        }

        public void AddToTial(int value)
        {
            var node = new Node(value);
            if (IsEmpty()) head = node;
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                        current = current.Next;
                }
                current.Next = node;
            }
            Length++;
        }
        public int RemoveHead()
        {
            if (IsEmpty()) Console.WriteLine("The List is Empty");

            Node node = head;
            head = node.Next;
            node.Next = null;
            return node.Value;
           
        }

        public void Remove(int delValue)
        {
            if (IsEmpty()) Console.WriteLine("The List is Empty");
            if (head.Value == delValue)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            Node? prev = null;
            while (current != null && current.Value != delValue)
            {
                prev = current;
                current = current.Next;
            }

            if(current == null) Console.WriteLine("The value is not found in the list");
            
            prev.Next = current.Next;
        }

        public bool Includes(int value) 
        {
           Node cureent = head;

        if (IsEmpty()) return false;
        
        if (value == cureent.Value) return true;

        while(cureent != null)
            {
                if(cureent.Value == value)  return true;
                cureent = cureent.Next;
            }
        return false;   
        }

        public void PrintList()
        {
            if (IsEmpty()) Console.WriteLine("The lis is Empty");
            else
            {
                Node current = head;
                Console.Write("Head --> ");
                while (current != null)
                {
                    Console.Write($"{current.Value} --> ");
                    current = current.Next;
                }
                Console.WriteLine("Null");
            }
        }
        public void RemoveDuplicate()
        {
            var current = head;

            while (current != null)
            {
                Node? tracker = current.Next;

                while (tracker != null)
                {
                    if (current.Value == tracker.Value)
                    {
                        Remove(tracker.Value);
                        break;
                    }
                    tracker = tracker.Next;
                }
                current = current.Next;
            }
        }

        public Node MergeLists(LinkedList list1, LinkedList list2)
        {
            if (list1.IsEmpty() && list2.IsEmpty())
            {
                Console.WriteLine("Both lists are empty.");
                return null;
            }
            else if (list1.IsEmpty())
            {
                Console.WriteLine("The first list is empty.");
                return list2.head;
            }
            else if (list2.IsEmpty())
            {
                Console.WriteLine("The second list is empty.");
                return list1.head;
            }

            Node current1 = list1.head;
            while (current1.Next != null)
            {
                current1 = current1.Next;
            }
            current1.Next = list2.head;

            return list1.head;
        }

        public void SortedList()
        {
          Node current = head, travers = null;
            

            while (current != null)
            {
                travers = current.Next;

                while (travers != null)
                {
                    if(current.Value.CompareTo(travers.Value) > 0) 
                    {
                        var temp = current.Value;
                        current.Value = travers.Value;  
                        travers.Value = temp;
                    }
                    travers = travers.Next;
                }
                current = current.Next; 
            }
        }
    }
}
