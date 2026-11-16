using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class RangeAttributes : Attribute
{
    public int Max { get; }
    public int Min { get; }

    public string ErrorMessage { set; get; }

    public RangeAttributes(int Min, int Max)
    {
        this.Min = Min;
        this.Max = Max;
    }
}

public class Person
{
   [RangeAttributes(18, 100, ErrorMessage = "Age Must be btween 18 and 100")]
    public int Age { set; get; }

    [RangeAttributes(18, 30, ErrorMessage = "experience Must be btween 18 and 30")]
    public int experience { set; get; }

    public string Name { set; get; }
}

public class ValidationExaple
{
    static void Main()
    {
        Person person = new Person { Age = 20, experience = 17, Name = "Saddam Alzekri" };

        if(validatePerson(person))
        {
            Console.WriteLine("Person is valide.");
        }else
        {
            Console.WriteLine("validation is failede.");
        }
        Console.ReadKey();
    }
    static bool validatePerson(Person person)
    {
        Type type = typeof(Person);

        foreach(var property in type.GetProperties())
        {
            if (Attribute.IsDefined(property, typeof(RangeAttributes)))
            {
                var rangeAttribute = (RangeAttributes)Attribute.GetCustomAttribute(property, typeof(RangeAttributes));
                int value = (int)property.GetValue(person);
                if(value < rangeAttribute.Min || value > rangeAttribute.Max)
                {
                    Console.WriteLine($"Validation failed for property {property.Name} : {rangeAttribute.ErrorMessage}");
                    return false;
                }
            }
        }

        return true;
    }
}