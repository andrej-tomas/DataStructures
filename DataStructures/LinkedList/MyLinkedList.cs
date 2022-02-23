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
    public Node? First => _head;
    public Node? Next => _head.Next;


    public void Print()
    {
        Node currNode = _head;

        while (currNode != null)
        {
            Console.Write(currNode.Value.ToString() + " -> ");
            currNode = currNode.Next;            
        }
        Console.Write("null");
    }

    public T Add(T item)
    {
        Node node = new(item);

        if (_head == null)
        {
            _head = node;
        }
        else
        {
            Node last = _head;

            while (last.Next != null)
            {
                last = last.Next;
            }

            last.Next = node;
        }

        return node.Value;
    }

    public T Peek()
    {
        Node node = _head;

        while(node.Next != null)
        {
            node = node.Next;   
        }

        return node.Value;
    }
}

