using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TrainingCenter.Data;
using Microsoft.Extensions.Logging;
using TrainingCenter.Entities;
using EFCore.BulkExtensions;

// Build configurationn
IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// Read connection string
string? connectionString = configuration.GetConnectionString("DefaultConnection");

// Validate connection string.
if (string.IsNullOrWhiteSpace(connectionString))
{
    Console.WriteLine("Connection string not found.");
    return;
}

// Configure EF Core
var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseSqlServer(connectionString)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .Options;

// Create context
using var context = new AppDbContext(options);

//ShowBadUpdate(context);
//ShowGoodUpdate(context);
//LoadThenUpdateVSControlledUpdateVSFullUpdate(context);
//InsertAt(context);
//DeleteAt(context);
//BadBulkInsert(context);
//GoodBulkInsert(context);

//This function contains ERROR, Do not work. 
//BestBulkInsert(context); 
//AddStudentByUsingDispose(options);
//AddTransactions(context);
LazyLoading(context);

static void ShowBadUpdate(AppDbContext context)
{
    var query = context.Students
        .AsNoTracking()
        .Where(s => s.StudentId == 1);

    PrintQueryString(query.ToQueryString());

    var Student = query.FirstOrDefault();
    
    if (Student == null)
    {
        Console.WriteLine("Student no found");
        return;
    }
    
    Student.FirstName = "Lollo";

    int effectRow = context.SaveChanges();

    Console.WriteLine($"The Count of row that effect is : {effectRow}");
}

static void ShowGoodUpdate(AppDbContext context)
{
    var student = context.Students
        .FirstOrDefault(s => s.StudentId == 1);


    if(student == null)
    {
        Console.WriteLine("Student not found");
    }

    student.FirstName = "Lollo2";
    student.LastName = "Faed";

    int effortRow = context.SaveChanges();

    Console.WriteLine($"The Count of row that effect is : {effortRow}");
}

static void LoadThenUpdateVSControlledUpdateVSFullUpdate(AppDbContext context)
{
    // Load then Update way

    var loadThenUpdate = context.Students
        .FirstOrDefault(s => s.StudentId == 1);

    loadThenUpdate.FirstName = "Lollo1";

    if(loadThenUpdate == null)
    {
        Console.WriteLine("There are not any data.");
        return;
    }

    int effectRow = context.SaveChanges();

    Console.WriteLine($"The rows that effect is {effectRow}");

    // Controlled attach way

    var ControlledAttach = new Student
    {
        StudentId = 2,
        FirstName = "Lollo7",
        //LastName = "Faed",
        //Email = "Lolo@gmail.com",
        //DateOfBirth = new DateOnly(2000, 5, 14),
        //RegisteredAt = new DateTime(2024, 1, 15, 11, 0, 0),
        //Status = "Active",
        //PhoneNumber = "767712126932"
    };
    


    context.Attach(ControlledAttach);

    context.Entry(ControlledAttach)
        .Property(s => s.FirstName)
        .IsModified = true;

    int effectRow2 = context.SaveChanges();

    Console.WriteLine($"The rows that effect is {effectRow2}");

    // Full Update way

    var FullUpadate = new Student
    {
        StudentId = 3,
        FirstName = "Lollo6",
        LastName = "Faed",
        Email = "Lolo343@gmail.com",
        DateOfBirth = new DateOnly(2000, 5, 14),
        RegisteredAt = new DateTime(2024, 1, 15, 11, 0, 0),
        Status = "Active",
        PhoneNumber = "767712126932"
    };

    context.Students.Update(FullUpadate);

    int effectRow3 = context.SaveChanges();

    Console.WriteLine($"The rows that effect is {effectRow3}");

}

static void InsertAt(AppDbContext context)
{
    var AddStudent = new Student
    {
        FirstName = "Saddam",
        LastName = "Alzekri",
        Email = "saddamalzekri33@gmail.com",
        DateOfBirth = new DateOnly(2000, 11, 19),
        RegisteredAt = new DateTime(2026, 5, 10, 3, 0, 0),
        Status = "Active",
        PhoneNumber = "+967 712126932"
    };

    context.Students.Add(AddStudent);

    int effectRow = context.SaveChanges();

    Console.WriteLine($"The rows that effect : {effectRow}");
}

 static void DeleteAt(AppDbContext context)
{
    //int StudentIDLast = context.Students
    //            .Select(s => s.StudentId)
    //            .Max();
    for (int i = 0; i<= 10; i++)
    {
int lastStudentID = context.Students
        .OrderByDescending(s => s.StudentId)
        .Select(s => s.StudentId)
        .FirstOrDefault();

    var query = context.Students
        .Where(s => s.StudentId == lastStudentID);

    var removeStudent = query.FirstOrDefault();

    if (removeStudent == null)
    {
        Console.WriteLine($"There are not any data.");
        return;
    }

    context.Students.Remove(removeStudent);

    int effectRow2 = context.SaveChanges();
    }
    
   // Console.WriteLine($"The effect row is {effectRow2}");
}

static void BadBulkInsert(AppDbContext context)
{
    Console.WriteLine($"Bad Bulk Insert.");

    for(int i = 0; i <= 10; i++)
    {
        var BulkInsert = new Student
        {
            FirstName = "Bad",
            LastName = $"Student{i}",
            Email = $"bad{i}@gmail.com",
            Status = "Active",
            RegisteredAt = DateTime.Now
        };

        context.Students.Add(BulkInsert);
        int effectRow = context.SaveChanges();
        Console.WriteLine($"The row that effect : {effectRow}");
    }
}

static void GoodBulkInsert(AppDbContext context)
{
    Console.WriteLine($"Good Bulk Insert.");

    var StdList = new List<Student>();

    for(int i = 0; i<= 10; i++)
    {
        StdList.Add
            (new Student
            {
                FirstName = "Bad",
                LastName = $"Student{i}",
                Email = $"bad{i}@gmail.com",
                Status = "Active",
                RegisteredAt = DateTime.Now
            });
    }

    context.Students.AddRange(StdList);

    int effectRow = context.SaveChanges();

    Console.WriteLine($"The row that effect is : {effectRow}");
}

static void BestBulkInsert(AppDbContext context)
{
    Console.WriteLine("The best bulk insert.");

    var stdList = new List<Student>();

    for (int i = 0; i <= 10; i++)
    {
        stdList.Add(new Student
        {
            FirstName = "Bad",
            LastName = $"Student{i}",
            Email = $"bad{i}@gmail.com",
            Status = "Active",
            RegisteredAt = DateTime.Now
        });
    }

    context.BulkInsert(stdList);
}

static void PrintQueryString(string query)
{
    Console.WriteLine("=========================");
    Console.WriteLine("Query String");
    Console.WriteLine("=========================");
    Console.WriteLine(query);
    Console.WriteLine("=========================");
}

static void AddStudentByUsingDispose(DbContextOptions<AppDbContext> options)
{
    using (var context = new AppDbContext(options))
    {
        var student = new Student
        {
            FirstName = "Saddam5",
            LastName = "Alzekri",
            Email = "saddamalzekri333@gmail.com",
            DateOfBirth = new DateOnly(2000, 11, 19),
            RegisteredAt = new DateTime(2026, 5, 10, 3, 0, 0),
            Status = "Active",
            PhoneNumber = "+967 712126932"
        };
        context.Students.Add(student);
        int effectsRow = context.SaveChanges();
        Console.WriteLine($"The row that effect is {effectsRow}");
    }
}

static void AddTransactions(AppDbContext context)
{
    var TransAction = context.Database.BeginTransaction();

    try
    {

        var course1 = context.Courses.Where(s => s.CourseId == 145).First();

        var course2 = context.Courses.Where(s => s.CourseId == 2).First();

        course1.Price -= 5;
        
        course2.Price += 5;

        context.SaveChanges();

        TransAction.Commit();
        Console.WriteLine($"Transfer completed successfully.");
    }
    catch
    {
        TransAction.Rollback();
        Console.WriteLine($"Transfer failed, No money moved");
    }
}

static void LazyLoading (AppDbContext context)
{
    var query = context.Students.Find(1);

    int numberOfstudents = query.Enrollments.Count();
    Console.WriteLine($"The count of students of enrollment{numberOfstudents}");

}

static void ExplicitLoading(AppDbContext context)
{
    var query = context.Students.FirstOrDefault(s => s.StudentId == 1);

    context.Entry(query).Collection(s => s.Enrollments).Load();

}



