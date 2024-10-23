// See https://aka.ms/new-console-template for more information
/*public class Programs
{
    public static void Main(string[] args)
    {
        int n = 0;
        var p = new Programs();
        p.fun(out n);
        Console.WriteLine("after fun "+ n);
    }
    public void fun(out int n)
    {
        n = 1   
        Console.WriteLine("inside fun "+n);
    }
}*/

using System.Runtime.CompilerServices;

namespace SyntaxCheck
{

    public class Errorssss : Exception
    {
        public Errorssss(string msg) : base(msg) { }
    }
    class ReferenceTypeExample
    {

        private int A;
        public int a
        {
            set { A = value; Console.WriteLine("worked"); }
            get { return A; }
        }

        static void Main()
        {
            ReferenceTypeExample var = new ReferenceTypeExample();
            var.a = 10;

            Parallel.For(1, 1000, i =>
            {
                Console.WriteLine($"Processing {i}");
            });

            Parallel.For(1000, 2000, i =>
            {
                Console.WriteLine($"Processing {i}");
            });

            /*try
            {
                try
                {
                    int[] arr = new int[3];
                    Console.WriteLine(arr[10]);  // IndexOutOfRangeException
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Caught an index out-of-range exception."+var.a);
                    throw;  // Re-throws the exception
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in the outer block: " + ex.Message);
            }*/


            Console.WriteLine("out of error");
        }
    }

    class Parent
    {
        public virtual void fun()
        {
            Console.WriteLine("Parent fun");
        }
    }
    class Child : Parent
    {
        public override void fun()
        {
            Console.WriteLine("Child fun");
        }
    }

    public interface ICar
    {
        // Properties defined in the interface (no field, just a contract)
        public string Model { get; set; }
        public int Year { get; set; }

        public void drive();
    }
    public class Car : ICar
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public void drive()
        {
            Console.WriteLine("Drive a car");
        }
    }
    
}

