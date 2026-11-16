// See https://aka.ms/new-console-template for more information

using System;

public class TypeClass
{

    static void Main(string[] args)
    {
        Type typeClass = typeof(string);

        Console.WriteLine($"Name      :{typeClass.Name}");
        Console.WriteLine($"FullName  :{typeClass.FullName}");
        Console.WriteLine($"IS Class  :{typeClass.IsClass}");
        Console.WriteLine($"NameSpace :{typeClass.Namespace}");
    }
}