using System;

/// <summary>
/// This is class used to represent simple operation.
/// </summary>
public class Calculator
{
    /// <Summary>
    /// This is Function for add two numbers and retuns it
    /// </Summary>
    /// <param name="a">The first number to be added </param>
    /// <param name="b">The second number to be added </param>
    /// <returns> Returns sum the result of add two numbers </returns>
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class Program
{
    static void Main()
    {
        Calculator Mycalculator = new Calculator();

        int addResult = Mycalculator.Add(1, 5);

        Console.WriteLine($"The result  of sum opration : {addResult} ");

        Console.ReadKey();
    }
}