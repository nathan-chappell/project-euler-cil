using System;

public class A
{
}

public interface IE
{
    event System.EventHandler ie;
}

public class A1 : System.Attribute
{
}

public class A2 : System.Attribute
{
    public string foo;
    public int x;
    public A2(string foo, int x)
    {
        this.foo = foo;
        this.x = x;
    }
}

[A1]
public static class Program
{
    [A2("meow", 17)]
    public static void Main(string[] args)
    {
        dynamic x = new A();
        x.foo = "bar";
        Console.WriteLine(String.Format("x: {0}, x.foo: {1}",x,x.foo));
    }
}
