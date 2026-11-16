using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class Person
{
    [Conditional("DEBUG")]
    public void DebugMethode(string Msg)
    {
        Console.WriteLine(Msg);
    }

    public void NormalMethode(string Msg)
    {
        Console.WriteLine(Msg);
    }
}

class Program
{
    static void Main()
    {
        Person PersonInfo = new Person();

        PersonInfo.DebugMethode("Hello, Debug Mode");
        PersonInfo.DebugMethode("Hello, Release Mode");

        Console.ReadKey();
    }
}


