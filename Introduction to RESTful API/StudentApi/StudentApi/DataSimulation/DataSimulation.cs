using StudentApi.Model;
namespace StudentApi.DataSimulation
{
    public class DataSimulation
    {
        public static readonly List<Student> StudentList = new List<Student>()
        {
            new Student {Id = 1, Name ="Ali Ahmed", Age = 19, Grade = 88},
            new Student {Id = 2, Name ="Saddam Hussein", Age = 28, Grade = 98},
            new Student {Id = 3, Name ="Saleh Ahmed", Age = 40, Grade = 56},
            new Student {Id = 4, Name ="Ammen Aref", Age = 30, Grade = 44}
        };
    }
}
