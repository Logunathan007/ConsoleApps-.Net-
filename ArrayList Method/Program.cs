using System.Collections;

namespace ArrayList_Method
{
    internal class Program
    {
        static void print(ArrayList al)
        {
            Console.WriteLine(String.Join(' ',al.ToArray()));
        }
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList() { 1,2,3,4 };

            print(al);

            Stack<int> stack = new Stack<int>(); 
            
            Queue<int> queue = new Queue<int>() ;

            queue.Enqueue(1);

            queue.Enqueue(2);

            queue.Enqueue(3);

            queue.Enqueue(4);

            Console.WriteLine(queue.Max());
        }
    }
}
