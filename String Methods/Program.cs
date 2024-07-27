using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string a = "logunathan";
        string b = "j";
        string c = "BE ECE";

        Console.WriteLine(a.Count());

        Console.WriteLine(a.Contains("logu"));
        Console.WriteLine(a.Count(ch=>ch=='a'));
        Console.WriteLine(a.CompareTo(c));
        foreach(var i in a.Distinct())
        {
            Console.Write(i);
        }

        Console.WriteLine();
        Console.WriteLine(a.Distinct());
        Console.WriteLine(a.ElementAtOrDefault(13).Equals('\0'));

        String str = "";
        StringBuilder sb = new StringBuilder();

        // Using Except to get characters in 'a' that are not in "ansd" and concatenating them
        a.Except("ansd").ToList().ForEach(ch => sb.Append(ch));

        // Converting StringBuilder to string
        str = sb.ToString();

        sb = new StringBuilder();

        Console.WriteLine(a.Insert(3, "ehsf"));

        a.SkipLast(3).ToList().ForEach(e => Console.WriteLine(e));
    }
}