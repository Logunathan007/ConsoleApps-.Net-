public class Builder
{
    private string _property1;
    private int _property2;

    public Builder SetProperty1(string value)
    {
        for (int i = 100; i < 200; i++, Console.WriteLine(i)) ;
        _property1 = value;
        return this; // Return the current instance
    }

    public Builder SetProperty2(int value)
    {
        for (int i = 0; i < 100; i++,Console.WriteLine(i));
        _property2 = value;
        return this; // Return the current instance
    }

    public void Build()
    {
        // Use _property1 and _property2 to create an object or perform an action
        Console.WriteLine($"Property1: {_property1}, Property2: {_property2}");
    }
}

// Usage
class Program
{
    static void Main()
    {
        var builder = new Builder();
        builder.SetProperty1("Hello")
               .SetProperty2(42)
               .Build(); // Chaining methods
    }
}
