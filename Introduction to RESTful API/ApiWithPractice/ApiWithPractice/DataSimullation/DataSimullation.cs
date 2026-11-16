using ApiWithPractice.Modul;

namespace ApiWithPractice.DataSimullation
{
    public class DataSimullation
    {
        public static readonly List<Student> StudentList = new List<Student>
        {
            new Student{ Id = 1, Name = "Ali Alwan", Age = 50, Grade = 47},
            new Student{ Id = 2, Name = "Saddam Alwan", Age = 18, Grade = 90},
            new Student{ Id = 3, Name = "Nasr Mosa", Age = 40, Grade = 80},
            new Student{ Id = 4, Name = "Taha Saeeed", Age = 29, Grade = 66},
        };
    }
}
