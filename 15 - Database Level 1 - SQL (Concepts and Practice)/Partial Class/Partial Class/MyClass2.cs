using System;

public partial class MyClass
{
    public void Method2()
    {
        Console.WriteLine("Hi, Method2 of Myclass");
        Method3();
    }
    partial void Method3()
    {
        Console.WriteLine("Hi, Method3 of Myclass");
    }
}
