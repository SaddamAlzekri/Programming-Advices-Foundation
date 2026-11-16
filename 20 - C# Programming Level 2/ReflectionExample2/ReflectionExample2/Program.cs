using System;
using System.Reflection;

namespace MyNameSpace
{
    public class MyClass
    {
        public int Property1 { set; get; }

        public void Methode1()
        {
            Console.WriteLine($"\t\tMethode is execute.");
        }

        public void Methode2(int value1, string value2)
        {
            Console.WriteLine($"Methode is execute with parameters: {value1} {value2}");
        }
    }

    public class Program
    {
        static string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameters => $"{parameters.ParameterType} {parameters.Name}"));
        }

        static void Main()
        {
            Type StringType = typeof(MyClass);

            Console.WriteLine($"PropertyName : {StringType.Name} \nPropertyFullName {StringType.FullName}");

            foreach(var property in StringType.GetProperties())
            {
                Console.WriteLine($"Property Name : {property.Name} Type {property.PropertyType}");
            }

            foreach(var Methode in StringType.GetMethods())
            {
                Console.WriteLine($" {Methode.ReturnType} {Methode.Name} ({GetParameterList(Methode.GetParameters())})");
            }
            
            object MyClassInstance = Activator.CreateInstance(StringType);

            StringType.GetProperty("Property1").SetValue(MyClassInstance, 25);
            int Property = (int)StringType.GetProperty("Property1").GetValue(MyClassInstance);

            Console.WriteLine($"Property is {Property}");

            StringType.GetMethod("Methode1").Invoke(MyClassInstance, null);
            object[] parameters = {100, "Saddam alzekri"};
            StringType.GetMethod("Methode2").Invoke(MyClassInstance, parameters);

            Console.ReadKey();
        }
    }
}