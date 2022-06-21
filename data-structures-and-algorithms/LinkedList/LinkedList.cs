using System;
namespace data_structures_and_algorithms
{

    public class LinkedList
    {
        public Node Head;
        public Node Tail;

        public Node Current { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        // To add in the last of the linked list
        public void Append(int value)
        {
            Node item = new Node(value);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }

        // To display linked list
        public string Tostring()
        {
            string format = "";
            Node current = Head;
            while (current != null)
            {
                format += $"[ {current.Data} ] -> ";
                current = current.Next;
            }

            format += "NULL";
            return format;


        }

        public void AddFirst(int value)
        {
            Node item = new Node(value);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                item.Next = Head;
                Head = item;
            }
        }

        public bool Search(int value)
        {
            Node current = new Node(value);
            current = Head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    Console.WriteLine("Found it");
                    return true;
                }
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine("Not found");
            }
            return false;
        }
        public void InsertBefore(int data, int x)
        {
            Node temp;

            // if list is empty
            if (Head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // if x is the first node the new node will be inserted before the first node
            if (x == Head.Data)
            {
                temp = new Node(data);
                temp.Next = Head;
                Head = temp;
                return;

            }
            Node p = Head;
            while (p.Next != null)
            {
                if (p.Next.Data == x)
                    break;
                p = p.Next;
            }

            if (p.Next == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                temp = new Node(data);
                temp.Next = p.Next;
                p.Next = temp;
            }


        }

        public void InsertAfter(int data, int x)
        {
            Node p = Head;
            while (p != null)
            {
                if (p.Data == x)
                    break;
                p = p.Next;
            }

            if (p == null)
                Console.WriteLine(x + " not present  the list");
            else
            {
                Node temp = new Node(data);
                temp.Next = p.Next;
                p.Next = temp;
            }
        }
        public int FromEnd(int value)
        {
            LinkedList liste = new LinkedList();

            if (value < 0)
            {
                Console.WriteLine("Invalid k value");
                return -1;
            }


            int counter = 0;

            Node Current = Head;
            while (Current.Next != null)
            {
                counter++;
                Current = Current.Next;
            }

            if (value > counter)
            {
                Console.WriteLine("Out of range");
                return -1;
            }
            else
            {

                Current = Head;

                while (counter > value)
                {
                    Current = Current.Next;
                    counter--;
                }
                Console.WriteLine(Current.Data);
                return Current.Data;
            }

        }
        public LinkedList ZipLists(LinkedList list1, LinkedList list2)
        {
            LinkedList MyList = new LinkedList();
            Node current1 = list1.Head;
            Node current2 = list2.Head;
            int value;
            while (current1 != null || current2 != null)
            {
                if (current1 != null)
                {
                    value = current1.Data;
                    Append(value);
                    current1 = current1.Next;
                }
                if (current2 != null)
                {
                    value = current2.Data;
                    Append(value);
                    current2 = current2.Next;
                }

            }
            return MyList;

        }
        public LinkedList ReverseList(LinkedList liste)
        {

            Node prev = null, current = Head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Head = prev;

            liste.Head = Tail;

            return liste;
        }
        public void print()
        {
            Node cur = Head;
            while (cur != null)
            {
                Console.WriteLine(cur.value);
                cur = cur.Next;
            }
        }
    }
}









    //public class LinkedList
    //{
    //    int length;
    //    public Node head { get; set; }
    //    public Node tail { get; set; }
    //    public LinkedList()
    //    {
    //        head = tail = null;
    //        length = 0;
    //    }

    //    public void insertAtPos(int pos, int value)
    //    {
    //        if (pos < 0 || pos > length)
    //        {
    //            Console.WriteLine("Out of Range");
    //        }
    //        Node newnode = new Node();
    //        if (pos == 0)
    //        {
    //            insertfirst(value);
    //        }
    //        else if (pos == length)
    //        {
    //            insertLast(value);
    //        }
    //        else
    //        {
    //            Node Cur = new Node();
    //            for (int i = 1; i < pos; i++)
    //            {
    //                Cur = Cur.next;
    //            }
    //            newnode.next = Cur.next;
    //            Cur.next = newnode;
    //            length++;
    //        }
    //    }

    //    public void Insert(int value)
    //    {
    //        Node data = new Node(value);
    //        data.next = head;
    //        head = data;
    //    }

    //    public bool Include(int value)
    //    {
    //        Node current = head;
    //        while (current != null)
    //        {
    //            if (value.Equals(current.value))
    //            {
    //                return true;
    //            }
    //            current = current.next;
    //        }
    //        return false;
    //    }

    //    public string Tostring()
    //    {
    //        string stri = "";
    //        Node current = head;
    //        while (current != null)
    //        {
    //            stri += $"[ {current.value} ] -> ";
    //            current = current.next;
    //        }

    //        stri += "NULL";
    //        return stri;
    //    }
    //    public void print()
    //    {
    //        Node cur = head;
    //        while(cur != null)
    //        {
    //            Console.WriteLine(cur.value);
    //            cur = cur.next;
    //        }
    //    }
    //    public void Append(int newValue)
    //    {
    //        Node current = head;
    //        Node temp = new Node(newValue);

    //        while (current.next != null)
    //        {
    //            current = current.next;
    //        }
    //        current.next = temp;
    //    }
    //    public bool IsEmpty()
    //    {
    //        return length == 0;
    //    }
    //    public void insertfirst(int element)
    //    {
    //        Node newNode = new Node();
    //        newNode.value = element;
    //        if (IsEmpty())
    //        {
    //            head = newNode;
    //            newNode.next = null;
    //        }
    //        else
    //        {
    //            newNode.next = head;
    //            head = newNode;
    //        }
    //        length++;
    //    }
    //    public void insertLast(int element)
    //    {
    //        Node newNode = new Node();
    //        newNode.value = element;
    //        if (IsEmpty())
    //        {
    //            head = tail = newNode;
    //            newNode.next = null;
    //        }
    //        else
    //        {
    //            tail.next = newNode;
    //            newNode.next = null;
    //            tail = newNode;
    //        }
    //        length++;
    //    }

    //    public int kthFromEnd(int n)
    //    {
    //        int len = 0;
    //        Node temp = head;

    //        // 1) count the number of nodes in Linked List
    //        while (temp != null)
    //        {
    //            temp = temp.next;
    //            len++;
    //        }

    //        // check if value of n is not more than length of
    //        // the linked list
    //        if (len < n)
    //            return 1;
    //        temp = head;

    //        // 2) get the (len-n+1)th node from the beginning
    //        for (int i = 1; i < len - n + 1; i++)
    //            temp = temp.next;
    //        Console.WriteLine(temp.value);
    //        return temp.value;
    //    }
    //    public static LinkedList ZipLists(LinkedList list1, LinkedList list2)
    //    {
    //        Node current1 = list1.head;
    //        Node current2 = list2.head;

    //        while (current2 != null)
    //        {
    //            if (current1 == null)
    //            {
    //                list1.Append(current2.value);
    //                current2 = current2.next;
    //            }
    //            else
    //            {
    //                current1 = current1.next;
    //            }
    //        }
    //        return list1;
    //    }
    //}





//        public void inserthead(int element)
//        {
//            Node newNode = new Node();
//            newNode.item = element;
//            if (IsEmpty())
//            {
//                head = last = newNode;
//                newNode.next = null;
//            }
//            else
//            {
//              newNode.next = head;
//                head = newNode;
//            }
//            length++;
//                    }
//        public void insertLast(int element)
//        {
//            Node newNode = new Node();
//            newNode.item = element;
//            if (IsEmpty())
//            {
//                head = last = newNode;
//                newNode.next = null;
//            }
//            else
//            {
//                last.next = newNode;
//                newNode.next = null;
//                last = newNode;
//            }
//            length++;
//        }
//    }

//}


