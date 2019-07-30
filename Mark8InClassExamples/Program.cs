using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the Node class
            Node n1 = new Node(10);
            Node n2 = new Node(15);
            Node n3 = new Node(20);
            Node n4 = new Node(25);
            Node n5 = new Node(30);

            // Linking them all together to form a doubly-linked list
            // (A singly-linked list is all that's being used for the
            // SumLinkedList method below)
            n1.Next = n2;
            n2.Previous = n1;
            n2.Next = n3;
            n3.Previous = n2;
            n3.Next = n4;
            n4.Previous = n3;
            n4.Next = n5;
            n5.Previous = n4;

            Console.WriteLine(SumLinkedList(n1));
        }

        static int SumLinkedList(Node headNode)
        {
            // Using a ternary operator and recursion
            return headNode.Value + (headNode.Next == null ? 0 : SumLinkedList(headNode.Next));

            // Recursive solution:
            // if (headNode.Next == null)
            // {
            //     return headNode.Value;
            // }

            // return headNode.Value + SumLinkedList(headNode.Next);


            // Iterative solution:
            // Node currentNode = headNode;
            // int sum = currentNode.Value;
            // while (currentNode.Next != null)
            // {
            //     currentNode = currentNode.Next;
            //     sum += currentNode.Value;
            // }

            // return sum;
        }
    }

    class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
        // has next and previous, so can be used for a doubly-linked list
    }
}
