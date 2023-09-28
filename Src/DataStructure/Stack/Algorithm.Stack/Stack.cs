using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Stack
{
    public class Stack
    {
        private int MaxSize { get; set; }
        private int[] StackArray { get; set; }
        private int Top { get; set; }

        public Stack(int size)
        {
            this.MaxSize = size;
            this.StackArray = new int[size];
            this.Top = -1;
        }
        public void Push(int value)
        {
            Top++;
            this.StackArray[this.Top] = value;
        }
        public int Pop()
        {
            int _top = Top;
            this.Top--;
            return this.StackArray[_top];
        }
        public int Peek()
        {
            return StackArray[Top];
        }
        public bool IsEmpty()
        {
            return this.Top == 0;
        }
        public bool IsFull()
        {
            return (this.MaxSize - 1) == Top;
        }
    }
}