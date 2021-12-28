using System;

namespace DuplicateRemoveLL
{
    class Program
    {
        Node head;
        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        void removeDuplicates()
        {
            Node current = head;
            Node next_next;
            if (head == null)
            {
                return;
            }
            while (current.next != null)
            {
                if (current.data == current.next.data)
                {
                    next_next = current.next.next;
                    current.next = null;
                    current.next = next_next;
                }
                else // advance if no deletion
                    current = current.next;
            }
        }
        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program list = new Program();
            list.push(20);
            list.push(13);
            list.push(13);
            list.push(11);
            list.push(11);
            list.push(11);

            Console.WriteLine("List before removal of duplicates");
            list.printList();

            list.removeDuplicates();

            Console.WriteLine("List after removal of elements");
            list.printList();
        }
    }
}
