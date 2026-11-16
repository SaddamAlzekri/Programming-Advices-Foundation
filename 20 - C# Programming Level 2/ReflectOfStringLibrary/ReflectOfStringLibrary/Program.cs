using System;
using System.Reflection;

public class Program
{
    static string GetParameterList(ParameterInfo[] parameters)
    {
        return string.Join(", ", parameters.Select(parameters => $"{parameters.ParameterType} {parameters.Name}"));
    }

    static void Main()
    {
        Assembly MsCorlib = typeof(String).Assembly;

        Type StringType = MsCorlib.GetType("System.String");

        if(StringType != null)
        {
            var StringMethode = StringType.GetMethods(BindingFlags.Public | BindingFlags.Instance).OrderBy(methode => methode.Name);

            foreach (var methode in StringMethode)
            {
                Console.WriteLine($"{methode.ReturnType} {methode.Name} {GetParameterList(methode.GetParameters())}");
            }
        }else
        {
            Console.WriteLine($"This StringType is Null");
        }
        Console.ReadKey();
    }
}
