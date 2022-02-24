namespace DataStructures.LinkedList;

public class MyLinkedList<T>
{
    public class Node
    {
        public T Value { get; set; }
        public Node? Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node? _head;
    private int _count = 0;
    public int Count => _count;

    public void Print()
    {
        Node currNode = _head;
        if(currNode != null)
        {
            while (currNode != null)
            {
                Console.Write(currNode.Value.ToString() + " -> ");
                currNode = currNode.Next;
            }
            Console.Write("null");
        } else
        {
            Console.WriteLine("The list is empty...");
        }      
    }

    public T Add(T item)
    {
        Node node = new(item);

        node.Next = _head;
        _head = node;
        _count++;

        return node.Value;
    }

    public T Peek()
    {
        return _head.Value;
    }
}

