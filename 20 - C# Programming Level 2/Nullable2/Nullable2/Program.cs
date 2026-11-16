// See https://aka.ms/new-console-template for more information

Nullable<int> hotDegree1 = null;

int? hotDegree2 = null;
hotDegree1 = 10;
if (hotDegree1.HasValue)
{
    Console.WriteLine("HotDegree1 has not a value.");
}
else
{
    Console.WriteLine("HotDegree1 has a value : " + hotDegree1);
}

int result = hotDegree2 ?? 10;
Console.WriteLine("The result is : " + result);

string str = hotDegree2?.ToString();
Console.WriteLine("The result is : " + str);
Console.ReadKey();