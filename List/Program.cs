using System.Collections;

namespace List
{
    internal class Program
    {
        static void print(IEnumerable<int> list) => Console.WriteLine(String.Join(" ", list));
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 11,3, 1, 11, 3, 5, 55, 33, 33, 1, 22 ,3,2,121,212,3};

            HashSet<int> set = new HashSet<int>() { 1, 11, 3, 5, 55, 33,33, 1, 22 };

            SortedSet<int> sset = new SortedSet<int>() { 1, 11, 3, 5, 55, 33, 33, 1, 22 };

            print(set.Order());

            //Dictionary<int, int> dict = new Dictionary<int, int>();

            //dict.Add(1, 11);

            //dict.Add(2, 22);
            //dict.Add(3, 33);
            //dict.Add(4, 44);

            ////print(dict.Keys);

            /* SortedDictionary<int, int> dict = new SortedDictionary<int, int>();

             dict.Add(1, 11);
             dict.Add(4, 44);
             dict.Add(2, 22);
             dict.Add(3, 33);

             print(dict.Keys);
             Console.WriteLine(dict.Max()); // Not working*/

            SortedList dict = new SortedList();

            dict.Add(1, 11);
            dict.Add(4, 44);
            dict.Add(2, 22);
            dict.Add(3, 33);

            var enumr = dict.GetEnumerator();

            while (enumr.MoveNext())
            {
                Console.WriteLine(enumr.Key+" = "+enumr.Value);
            }   

            Console.WriteLine();
        }
    }
}
