
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithm.LinkedList
{
    public class LinkedList
    {
        public Nodes? First { get; set; }
        public bool IsEmpty()
        {
            return First == null;
        }
        public void InsertFirst(int data)
        {
            Nodes nodes = new Nodes();
            nodes.Data = data;
            nodes.Next = First;
            First = nodes;
        }
        public Nodes DeleteFirst()
        {
            Nodes nodes = First;
            First = First.Next;
            return nodes;
        }
        public void DisplayList()
        {
            Nodes currentNode = First;
            while (currentNode != null)
            {
                currentNode.Display();
                currentNode = currentNode.Next;
            }
        }
        public void InsertLast(int data)
        {
            Nodes current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Nodes newNode = new Nodes();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}