namespace StackandQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stack And Queue");
            Stack obj = new Stack();
            Console.WriteLine("After push the elements are : ");

            obj.push(70);
            obj.push(30);
            obj.push(56);
            Console.WriteLine();

            Console.WriteLine("Top Element of the stack is : " + obj.peek());


        }
    }
}

