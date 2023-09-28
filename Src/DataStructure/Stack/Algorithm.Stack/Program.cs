// See https://aka.ms/new-console-template for more information
using Algorithm.Stack;

Console.WriteLine("Hello, World!");

Stack stack = new Stack(10);

for (int i = 0; i <= 10; i++)
{
    if (!stack.IsFull())
    {
        stack.Push(i);
    }
    else
    {
        Console.WriteLine("Unable to add this due to stack size {0}", i);
    }
}

stack.Pop();
stack.Peek();

while (!stack.IsEmpty())
{
    Console.WriteLine(stack.Pop());
}
Console.ReadLine();