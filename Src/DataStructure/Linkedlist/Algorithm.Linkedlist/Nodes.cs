using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.LinkedList
{
    public class Nodes
    {
        public int Data { get; set; }
        public Nodes? Next { get; set; }
        public void Display()
        {
            Console.WriteLine(Data);
        }
    }
}