using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML
{
    public class Program
    {
      [Serializable]
      public class Person
      {
        public string Name { get; set; }
        public int Age { get; set; }
      };
        static void Main(string[] args)
        {
        Person Person = new Person { Name = "Saddam Alzekri", Age = 82 };

        XmlSerializer serializer = new XmlSerializer(typeof(Person));

        using (TextWriter writter = new StreamWriter("Person.txt"))
        {
            serializer.Serialize(writter, Person);
        }

        using (TextReader reader = new StreamReader("Person.txt"))
        {
            Person DeserializerPerson = (Person)serializer.Deserialize(reader);
            Console.WriteLine("Name : " + DeserializerPerson.Name+" Age : " + DeserializerPerson.Age);
        }
        Console.ReadKey();
        }
    }
}
