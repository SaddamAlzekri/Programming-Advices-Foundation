using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Person Person = new Person { Name = "Saddam Alzekri.", Age = 25 };

        DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(Person));

        using (MemoryStream Stream = new MemoryStream())
        {
            Serializer.WriteObject(Stream, Person);
            string stringJson = System.Text.Encoding.UTF8.GetString(Stream.ToArray());

            File.WriteAllText("Person.json", stringJson);
        }
        
        using (FileStream Stream = new FileStream("Person.json", FileMode.Open))
        {
            Person Deserializer = (Person)Serializer.ReadObject(Stream);
            Console.WriteLine($"Name : {Deserializer.Name} Age : {Deserializer.Age}.");
        }

        Console.ReadKey();
    }
}