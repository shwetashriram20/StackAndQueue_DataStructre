using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    public class Stack
    {
        Node head;
        public void push(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                node.next = temp;
            }
            Console.WriteLine("Item pushed into stack -> " + data);

        }

        public int pop()
        {
            int popped;
            if (head == null)
            {
                Console.WriteLine("Stack is Empty");
                return 0;
            }
            else
            {
                popped = head.data;
                head = head.next;
                return popped;
            }
        }

        public int peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                return head.data;
            }
        }
    }
}




