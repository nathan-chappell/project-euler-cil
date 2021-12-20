using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello from test-collatz");
        var c = new CollatzSequence();
        ((IValueChanged)c.IsEvenNode).ValueChanged += (object o, int val) => 
        {
            Console.WriteLine($"\t\tIsEven.ValueChanged val={val}");
        };
        c.SequenceVal = 113;
    }
}
