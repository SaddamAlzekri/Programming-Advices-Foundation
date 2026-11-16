using System;

public class GenericBox<T>
{
    private T content;

    public GenericBox(T content)
    {
        this.content = content;
    }

    public T Getcontent()
    {
        return content;
    }
    public T Swap<T>(ref T num1, ref T num2)
    {
        T temp = num1;
        num1 = num2;
        num2 = temp;
        return temp;
    }
}

public class content
{
    static void Main()
    {
        GenericBox<int> generic1 = new GenericBox<int>(20);
        Console.WriteLine($"The number is : {generic1.Getcontent()}");

        GenericBox<string> generic2 = new GenericBox<string>("Saddam Alzekri");
        Console.WriteLine($"My name is : {generic2.Getcontent()}");
        int num1 = 10, num2 = 20;

        Console.WriteLine($"\nNumber1 :{num1} and Number2 :{num2}");
        generic2.Swap(ref num1, ref num2);

        Console.WriteLine($"\nAfter swap two numbers\n\nNumber1 :{num1} and Number2 :{num2}");

        Console.ReadKey();
    }
}