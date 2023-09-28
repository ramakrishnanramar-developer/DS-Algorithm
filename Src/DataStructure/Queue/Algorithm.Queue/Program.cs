// See https://aka.ms/new-console-template for more information
using Alogorithm.Queue;

Console.WriteLine("Hello, World!");


Queue queue = new Queue(10);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Enqueue(6);

Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());

Console.WriteLine(queue.Peek());

Console.ReadLine();