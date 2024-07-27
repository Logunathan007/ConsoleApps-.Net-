

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 48,32, 1,2,3,4,32,55 };

        foreach (var item in arr)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
        Console.WriteLine(arr.ToString());
        Console.WriteLine(arr.Length);
        Console.WriteLine(arr.Rank);
        int[] temp = (int[])arr.Clone();
        foreach (var item in temp)
        {
            Console.Write(item + " ");
        }
        Array.Clear(temp, 0, temp.Length-1);
        foreach (var item in temp)
        {
            Console.Write(item + " ");
        }
        Array.Fill(temp, -1);
        Console.WriteLine();
        int i = 0;
        foreach (var item in arr)
        {
            temp[i] = arr[i];
            i++;
        }
        Console.WriteLine( Array.Equals(temp, arr));
        Console.WriteLine(arr.Equals(temp));
        Console.WriteLine(Array.IndexOf(temp, 35));
        Console.WriteLine(Array.LastIndexOf(arr, 32));
        Array.Reverse(arr);
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Array.Sort(arr);
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        int[] ints = Array.FindAll<int>(arr,e => e == 32 );
        foreach (var item in ints)
        {
            Console.Write(item + " ");
        }
        
        Console.WriteLine();
        Console.WriteLine(Array.FindIndex(arr, e => e == 12));
        Console.WriteLine(arr.Any(e => e==32));
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        Console.WriteLine(arr.AsEnumerable());

        List<int> l = arr.ToList();
        foreach (var item in l)
        {
            Console.Write(item + " ");
        }
        int []rand = { 2, 1, 2, 323, 22, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine();
        double val = arr.Average();
        Console.WriteLine(val.ToString());
        Console.WriteLine(arr.Last());
        Console.WriteLine(arr.LastOrDefault());
        Console.WriteLine(arr.Min());
        foreach (var j in rand.Order())
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
        foreach (var j in rand.OrderBy(n=>n))
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
        foreach (var j in rand.OrderByDescending(n=>n))
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
        foreach (var j in rand.OrderDescending())
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
        Console.WriteLine(arr.Sum());
        foreach (var j in rand.Distinct())
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
        foreach (var j in rand.DistinctBy(n=>n))
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
        //foreach (var j in rand.GroupBy(n => n))
       // {
      //      Console.Write(j + " ");
      //  }
        Console.WriteLine();
        foreach (var j in rand.Take(3))
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
        foreach (var j in rand.TakeLast(3))
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}