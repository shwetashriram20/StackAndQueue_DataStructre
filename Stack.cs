using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    public class Stack
    {
        public Node head;
        public Node tail;
        public int count;
        public MyQueue()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;

        }
        public void enqueue(int value) 
        {
            Node node = new Node(value); 
            if (head == null)
            {
                head = node; 
            }
            else
            {
                tail.next = node;
            }
            Console.WriteLine("The Data is : " + node.data);
            this.count++;
            this.tail = node;
        }

        public int dequeue() 
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
                return 0;
            }

            var temp = head;
            head = head.next;
            this.count--;
            if (head == null)
            {
                tail = null; 
            }

            return temp.data;
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
