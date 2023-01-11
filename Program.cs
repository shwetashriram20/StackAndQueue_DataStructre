namespace StackandQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyQueue obj = new MyQueue();
            Console.WriteLine("After push the elements are : ");

            obj.enqueue(56);
            obj.enqueue(30);
            obj.enqueue(70);
            Console.WriteLine();
            Console.WriteLine("Item popped from Queue = " + obj.dequeue());


            Console.WriteLine("Top Element of the Queue is : " + obj.peek());


        }
    }
}

