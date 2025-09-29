public class LinkedList
{
    public Node Head { get; set; }

    public LinkedList(string value)
    {
        Node Head = new Node(value);
        Head = node;
    }

    public override string ToString()
    {
        string list = Head.Data;

        string list = Head.Data;
        Node lastnode = Head;

        while (lastnode.Next != null)
        {
            list += lastnode.Data;
            lastnode = lastnode.Next;
        }

        return list;

    }

 }