
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Net.Http.Json;
//using Newtonsoft.Json;


namespace ApiClientWithPractice
{
    class Program
    {
        static readonly HttpClient httpClient = new HttpClient();
        static async Task Main(string[] args)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7154/api/Students/");

            await GetAllStudents();
            await GetPassStudents();
            await GetAverageStudents();
            await GetStudentById(1);
            await DeleteStudent(1);
            await GetAllStudents();
            var NewStudent = new Student { Id = 5, Name = "Soraka bn Malik", Age = 26, Grade = 67 };
            await AddStudent(NewStudent);
            await GetAllStudents();
            var UpdateStudent = new Student { Id = 5, Name = "Omar bn Al-Khatab", Age = 50, Grade = 99 };
            await UpdateStudents(2, UpdateStudent);
            await GetAllStudents();

        }

        static async Task GetAllStudents()
        {
            try
            {
                Console.WriteLine($"\n-----------------------------------");
                Console.WriteLine($"\nFetching all student data...");
                var Students = await httpClient.GetFromJsonAsync<List<Student>>("All");
                if(Students != null)
                {
                    foreach (var student in Students)
                    {
                        Console.WriteLine($"Id {student.Id}, Name {student.Name}, Age {student.Age}, Grade {student.Grade}");
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"invalide student data {ex.Message}");
            }

        }
        static async Task GetPassStudents()
        {
            try
            {
                Console.WriteLine($"\n--------------------------------");
                Console.WriteLine($"\nfetching Pass student data...");
                var students = await httpClient.GetFromJsonAsync<List<Student>>("Pass");
                if(students != null)
                {
                    foreach(var student in students)
                    {
                        Console.WriteLine($"Id {student.Id}, Name {student.Name}, Age {student.Age}, Grade {student.Grade}");
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"invalide studnt data {ex.Message}");
            }
        }
        static async Task GetAverageStudents()
        {
            try
            {
                Console.WriteLine("\n---------------------------------");
                Console.WriteLine("\nFetching student average data...");
                var Student = await httpClient.GetFromJsonAsync<Student>("GetAverage");

                if(Student != null)
                {
                    Console.WriteLine($"ID, {Student.Id}, Name {Student.Name}, Age {Student.Age}, Grade {Student.Grade}");
                }
            }                                                                                       
            catch(Exception ex)
            {
                Console.WriteLine($"invalide student data {ex.Message}");
            }
        }

        static async Task GetStudentById(int id)
        {
            try
            {
                Console.WriteLine($"\n-----------------------------");
                Console.WriteLine($"Fetching student data by id {id}...");
                var response = await httpClient.GetAsync($"{id}");

                if(response.IsSuccessStatusCode)
                {
                    var Student = await response.Content.ReadFromJsonAsync<Student>();
                    Console.WriteLine($"ID, {Student.Id}, Name {Student.Name}, Age {Student.Age}, Grade {Student.Grade}");

                }else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"NotFound : invalide student data.");
                }
                     
            }
            catch(Exception ex)
            {
                Console.WriteLine($"invalide student data {ex.Message}");
            }
        }

        static async Task DeleteStudent(int id)
        {
            try
            {
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine($"\nDeleting student data by id {id}");
                var response = await httpClient.DeleteAsync($"{id}");
                if(response.IsSuccessStatusCode)
                {
                    var Student = await response.Content.ReadFromJsonAsync<Student>();
                    Console.WriteLine($"ID, {Student.Id}, Name {Student.Name}, Age {Student.Age}, Grade {Student.Grade}");
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"NotFound: invalide student data.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"BadResquast: invalide student data.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"invalide student data {ex.Message}");
            }
        }

        static async Task AddStudent(Student NewStudent)
        {
            try
            {
                Console.WriteLine($"\n------------------------");
                Console.WriteLine($"\nAdd New Student");
                var response = await httpClient.PostAsJsonAsync("AddStudent", NewStudent);
                if(response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadFromJsonAsync<Student>();
                    Console.WriteLine($"ID {student.Id}, Name {student.Name}, Age {student.Age} Grade {student.Grade}");
                }else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine("NotFound : invalide student data");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"invalide student data {ex.Message}");
            }
        }

        static async Task UpdateStudents(int id, Student UpdateStudent)
        {
            try
            {
                Console.WriteLine("\n----------------------------");
                Console.WriteLine($"Update student\n");
                var response = await httpClient.PutAsJsonAsync($"{id}", UpdateStudent);
                if(response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadFromJsonAsync<Student>();
                    Console.WriteLine($"Id {student.Id}, Name {student.Name}, Age {student.Age}, Grade {student.Grade}");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"Bad response: not accept Id {id}");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Not found: not accept Id {id}");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"invalide student data {ex.Message}");
            }
        }
    }
}


public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }
}
