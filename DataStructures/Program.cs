using DataStructures.LinkedList;

MyLinkedList<int> list = new();
list.Add(0);
list.Add(1);
list.Add(2);
list.Add(3);

Console.WriteLine("Last added item is: " + list.Peek());
list.Print();