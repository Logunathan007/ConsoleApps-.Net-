using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Channels;
using System.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
namespace DelegatesCheck{

    public class MainClass
    {
        public delegate int numberFunction(int n);
        public delegate int numbers();

        public int number(int n)
        {
            return n;
        }

        public int one()
        {
            Console.WriteLine("one");
            return 1;
        }
        public int two()
        {
            Console.WriteLine("two");
            return 2;
        }
        public int three()
        {
            Console.WriteLine("three");
            return 3;
        }

        public numbers instanceMethod(int n)
        {
            numbers? nf;
            if (n == 1)
            {
                nf = new numbers(one);
            }
            else if (n == 2)
            {
                nf = new numbers(two);
            }
            else if (n == 3)
            {
                nf = new numbers(three);
            }
            else
            {
                nf = new numbers(one);
                nf += two;
                nf += three;
                nf -= two;
            }
            return nf;
        }
        public static void Main(string[] args)
        {
            /*List<int> numbers = new List<int> { 5, 3, 32, 4, 23, 2, 32, 234, 323 };

            // Sorts 6 elements starting from index 2
            numbers.Sort(2, 6, null);

            var num = numbers.GetEnumerator();
            int i = 0;

            while (num.MoveNext())
            {
                Console.WriteLine(num.Current);
                i++;

                // Restart enumeration after printing 3 numbers
                if (i == 3)
                {
                    // Restart by creating a new enumerator
                    num = numbers.GetEnumerator();
                    i = 0; // Reset the counter
                }
            }*/
            Dictionary<IList<int>,int> dict = new Dictionary<IList<int>,int>(StructuralComparisons.StructuralEqualityComparer);
            var one = new List<int>{ 0, 0 };
            var two = new List<int>{1, 2 };
            var three = new List<int>{3, 4 };
            var four = new List<int>{5, 6 };
            var five = new List<int>{6, 7};
            var six = new List<int>{7, 8};
            var seven = new List<int>{8, 9};

            dict.Add(one, 1);
            dict.Add(two, 2);
            dict.Add(three, 3);
            dict.Add(four, 4);
            dict.Add(five, 5);
            dict.Add(seven, 6);
            dict.Add(six, 7);
            int check = 0;
            /*foreach(var val in dict.Keys)
            {
                Console.WriteLine(string.Join(", ",val) +" " + dict[val]);
            }*/

            Console.WriteLine(dict.ContainsKey(new List<int> { 1,2}));
        }
    }
}