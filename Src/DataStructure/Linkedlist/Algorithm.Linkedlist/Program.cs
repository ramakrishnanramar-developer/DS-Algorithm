// See https://aka.ms/new-console-template for more information

using Algorithm.LinkedList;

LinkedList linkedList = new LinkedList();
linkedList.InsertFirst(2);
linkedList.InsertFirst(3);
linkedList.InsertFirst(4);

linkedList.DeleteFirst();
linkedList.DeleteFirst();

linkedList.InsertLast(5);

linkedList.DisplayList();


Console.WriteLine();