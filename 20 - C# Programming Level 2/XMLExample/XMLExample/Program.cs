using System;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class Person
{
    public string Name { set; get; }
    public int Age { set; get; }
}

class Program
{
    static void Main()
    {
        Person PersonInfo = new Person { Name = "Saddam Hussein Alzekri.", Age = 25 };

        XmlSerializer Serializer = new XmlSerializer(typeof(Person));

        using (TextWriter writter = new StreamWriter("Person.txt"))
        {
            Serializer.Serialize(writter, PersonInfo);
        }

        using (TextReader reader = new StreamReader("Person.txt"))
        {
            Person DeserializerPersonInfo = (Person)Serializer.Deserialize(reader);
            Console.WriteLine($"Name : {DeserializerPersonInfo.Name} Age : {DeserializerPersonInfo.Age}");
        }

        Console.ReadKey();
    }
}