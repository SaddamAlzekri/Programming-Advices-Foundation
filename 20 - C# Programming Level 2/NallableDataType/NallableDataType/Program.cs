static void Procedure1(string Name,int? Age)
{
    Console.WriteLine($"My Name is {Name}");

    if(Age.HasValue)
    {
        Console.WriteLine($"My age is {Age.ToString()}");
    }else
    {
        Console.WriteLine("Age is null");
    }
}

Procedure1("Saddam Alzekri", null);

Console.ReadKey();
