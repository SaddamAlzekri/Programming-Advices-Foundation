using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Net.Http.Json;
//using Newtonsoft.Json;

namespace StudentApiClient
{
    class Program
    {
        static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7211/api/Students/");

            await GetAllStudents();
            await GetPassStudents();
            await GetAverageGradeStudents();
            await GetStudentById(2);
            var student = new Student { Id = 5, Name = "Alooosh", Age = 30, Grade = 66 };
            await AddStudent(student);
            await DeleteStudent(1);
            await GetAllStudents();
            var vupdateStudent = new Student {Name = "Esam", Age = 50, Grade = 50 };
            await UpdateStudent(2,vupdateStudent);
            await GetAllStudents();

        }

        static async Task GetAllStudents()
        {
            try
            {
                Console.WriteLine("\n-------------------------------------");
                Console.WriteLine("\nFetching all student...\n");
                var students = await httpClient.GetFromJsonAsync<List<Student>>("All");
                if(students != null)
                {
                    foreach(var student in students)
                    {
                        Console.WriteLine($"ID {student.Id}, Name {student.Name}, Age {student.Age}, Grade {student.Grade}");
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static async Task GetPassStudents()
        {
            try
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine("\nFetching pass students");
                var students = await httpClient.GetFromJsonAsync<List<Student>>("Pass");

                if (students != null)
                {
                    foreach (var Student in students)
                    {
                        Console.WriteLine($"ID {Student.Id}, Name {Student.Name}, Age {Student.Age}, Grade {Student.Grade}");
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occured {ex.Message}");
            }
        }

        static async Task GetAverageGradeStudents()
        {
            try
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine("\nFetching AverageGrade students");
                var AverageGrade = await httpClient.GetFromJsonAsync<double>("AverageGrade");

                Console.WriteLine($"The Average grade of rate is {AverageGrade}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured {ex.Message}");
            }
        }

        static async Task GetStudentById(int id)
        {
            try
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine($"\nFetching students with {id}");
                var response = await httpClient.GetAsync($"{id}");

                if (response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadFromJsonAsync<Student>();
                    if (student != null)
                    {
                        Console.WriteLine($"ID {student.Id}, Name {student.Name}, Age {student.Age}, Grade {student.Grade}");
                    }
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
            catch(Exception ex)
            {
                Console.WriteLine($"An error occured {ex.Message}");
            }
        }

        static async Task AddStudent(Student NewStudent)
        {
            try
            {
                Console.WriteLine($"\n----------------------------------------");
                Console.WriteLine("\nAdd New Student");
                var response = await httpClient.PostAsJsonAsync("", NewStudent);

                if(response.IsSuccessStatusCode)
                {
                    var addedStudent = await response.Content.ReadFromJsonAsync<Student>();
                    Console.WriteLine($"Id : {addedStudent.Id}, Name : {addedStudent.Name}.");
                }else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"BadRequest: valid student data.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occured {ex.Message}");
            }
        }

        static async Task DeleteStudent(int id)
        {
            try
            {
                Console.WriteLine("\n_____________________________");
                Console.WriteLine($"\nDeleting student with ID {id}...\n");
                var response = await httpClient.DeleteAsync($"{id}");

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Student with ID {id} has been deleted.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"Bad Request: Not accepted ID {id}");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Not Found: Student with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static async Task UpdateStudent(int id, Student UpdateStudent)
        {
            try
            {
                Console.WriteLine($"\n---------------------------------");
                Console.WriteLine($"\nUpadet student with id {id}...\n");
                var response = await httpClient.PutAsJsonAsync($"{id}", UpdateStudent);

                if(response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadFromJsonAsync<Student>();
                    Console.WriteLine($"ID {student.Id}, Name {student.Name}, Age {student.Age}, Grade {student.Grade}");
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
            catch(Exception ex)
            {
                Console.WriteLine($"invalide error occure {ex.Message}");
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