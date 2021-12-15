using System;

public class A
{
}

public static class Program
{
    public static void Main(string[] args)
    {
        dynamic x = new A();
        x.foo = "bar";
        Console.WriteLine("x: {0}, x.foo: {1}".Format(x,x.foo));
    }
}
