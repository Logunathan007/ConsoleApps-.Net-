
using System.Diagnostics;

namespace MultiThreadingCheck
{
    public class Program
    {
        static void Fun1()
        {
            Console.WriteLine("Fun1 " + Thread.GetCurrentProcessorId());
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("This is fun1");
                Thread.Sleep(1);
            }
        }
        static void Fun2()
        {
            Console.WriteLine("Fun2 "+Thread.GetCurrentProcessorId());
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("This is fun2");
                Thread.Sleep(1);
            }
        }
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Fun1);
            Thread t2 = new Thread(Fun2);
            Stopwatch s1 = new Stopwatch();
            Console.WriteLine("Main " + Thread.GetCurrentProcessorId());
            
            s1.Start();
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            s1.Stop();

            Console.WriteLine("Main End " + Thread.GetCurrentProcessorId());
            Console.WriteLine(s1.ElapsedMilliseconds);

        }
    }



















}