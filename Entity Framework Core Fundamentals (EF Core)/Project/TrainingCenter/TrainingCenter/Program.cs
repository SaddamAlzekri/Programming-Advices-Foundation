using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TrainingCenter.Data;
using Microsoft.Extensions.Logging;
using TrainingCenter.Entities;

// Build configuration
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

//GetStudent(context);
//GetStudent_First(context);
//GetStudent_FirstOrDefault(context);
//GetStudent_Single(context);
//GetStudent_SingleOrDefault(context);
//GetStudent_Find(context);
//GetStudentWhereSelectOrder(context);
//GetStudentAnyAll(context);
//GetStudentCount(context);
//GetSumOfPrice(context);
//GetMinMaxOfStudent(context);
//GetAverageOfPrice(context);
//GetStudentDistinctGroupby(context);
//GetStudentByInclude(context);
//GetStudentByIncludeThenInclude2(context);
//GetStudentJoin(context);
//GetStudentWithProfileleftjoin(context);
//GetProfileStudentWithStudentRightJoin(context);
//GetStudentWithEnrollmentbySelectMany(context);
SubQueries(context);

static void PrintQueryString(string query)
{
    Console.WriteLine("=========================");
    Console.WriteLine("Query String");
    Console.WriteLine("=========================");
    Console.WriteLine(query);
    Console.WriteLine("=========================");
}

static void GetStudent(AppDbContext context)
{
    var query = context.Students
        .Where(s => s.StudentId <= 5)
        .Select(s => new
        {
            s.StudentId,
            FullName = s.FirstName + " " + s.LastName
        })
        .OrderBy(S => S.FullName)
        .ThenBy(S => S.StudentId);


    PrintQueryString(query.ToQueryString());

    var student = query.ToList();

    foreach(var row in student)
    {
        Console.WriteLine(row.StudentId + " - " + row.FullName);
    }


}

static void GetStudent_First(AppDbContext context)
{
    var query1 = context.Students.Where(s => s.StudentId == 1);

    PrintQueryString(query1.ToQueryString());

    var student = query1.First();

    Console.WriteLine("\nFirst Active Student:");
    Console.WriteLine($"{student.StudentId} - {student.FirstName} {student.LastName}");
}

static void GetStudent_FirstOrDefault(AppDbContext context)
{
    var query1 = context.Students.Where(s => s.StudentId == 1);

    PrintQueryString(query1.ToQueryString());

    var student = query1.FirstOrDefault();

    Console.WriteLine("\nFirst Active Student:");
    Console.WriteLine(student.StudentId +" - "+student.FirstName +" "+student.LastName);
}

static void GetStudent_Single(AppDbContext context)
{
    var query1 = context.Students.Where(s => s.StudentId == 1);

    PrintQueryString(query1.ToQueryString());

    var student = query1.Single();

    Console.WriteLine("\nFirst Active Student:");
    Console.WriteLine(student.StudentId + " - " + student.FirstName + " " + student.LastName);
}

static void GetStudent_SingleOrDefault(AppDbContext context)
{
    var query1 = context.Students.Where(s => s.StudentId == 1);

    PrintQueryString(query1.ToQueryString());

    var student = query1.SingleOrDefault();

    Console.WriteLine("\nFirst Active Student:");
    Console.WriteLine(student.StudentId + " - " + student.FirstName + " " + student.LastName);
}

static void GetStudent_Find(AppDbContext context)
{
    var student = context.Students.Find(1);

    if (student != null)
    {
        Console.WriteLine("Find Active Student:");
        Console.WriteLine(
            student.StudentId + " - " +
            student.FirstName + " " +
            student.LastName);
    }
    else
    {
        Console.WriteLine("Student not found.");
    }
}

static void GetStudentWhereSelectOrder(AppDbContext context)
{
    var Query = context.Students.Where(s => s.Status == "Active")
        .Select(s => new
        {
            s.StudentId,
            FullName = s.FirstName + " " + s.LastName
        })
        .OrderBy(s => s.StudentId)
        .ThenBy(s => s.FullName);

    PrintQueryString(Query.ToQueryString());

    var Student = Query.ToList();
    Console.WriteLine("The Where/Select/Order");
    foreach(var row in Student)
    {
        Console.WriteLine(row.StudentId + " " + row.FullName);
    }
}

static void GetStudentAnyAll(AppDbContext context)
{
    var query = context.Students.Any(s => s.Status == "Active");
    //var query = context.Students.Where(s => s.Status == "Active");

    Console.WriteLine("\nSrting query");

    //PrintQueryString(query.ToQueryString());

   // bool anyActiveStudent = query.Any();

    Console.WriteLine("Any Active Student: " + query);

    Console.WriteLine();
    var query2 = context.Courses.All(s => s.Price >= 0);
    Console.WriteLine("All Active Student: " + query2);

}

static void GetStudentCount(AppDbContext context)
{
    var badWay = context.Students.Where(s => s.Status == "Active");

    var ActiveStudent = badWay.ToList();

    int countOfActiveStudent = ActiveStudent.Count();

    Console.WriteLine("The Count of Active Students : " + countOfActiveStudent);

    Console.WriteLine();

    var GoodWay = context.Students.Where(s => s.Status == "Active");

    int countOfActiveStudent2 = GoodWay.Count();
    Console.WriteLine("The Count of Active Students : " + GoodWay);
}

static void GetSumOfPrice(AppDbContext context)
{
    // Bad Way

    var badWay = context.Courses;
    //PrintQueryString(badWay.ToQueryString());
    var sumOfPrice = badWay.ToList();

    float priceSum = (float)sumOfPrice.Sum(s => s.Price);

    Console.WriteLine("The Sum of price : " + priceSum);
    
    // Good Way

    var goodWay = context.Courses.Where(s => s.Price >= 0);

    float getSumOfPrice = (float)goodWay.Sum(s => s.Price);

    Console.WriteLine("The Sum of price : " + getSumOfPrice);
    // Excelant Way
    float ExcelantWay = (float)context.Courses.Sum(s => s.Price);

    Console.Write(ExcelantWay);
}

static void GetMinMaxOfStudent(AppDbContext context)
{
    // good way
    decimal priceMin = context.Courses.Min(s => s.Price);
    Console.WriteLine("price Min");
    Console.WriteLine(priceMin);

    decimal priceMax = context.Courses.Max(s => s.Price);
    Console.WriteLine("price Max");
    Console.WriteLine(priceMax);
}

static void GetAverageOfPrice(AppDbContext context)
{
    decimal priceAverage = context.Courses.Average(s => s.Price);
    Console.WriteLine("price Average");
    Console.WriteLine(priceAverage);
}   

static void GetStudentDistinctGroupby(AppDbContext context)
{
    // Distinct

    var StudentDistinct = context.Students
        .Select(s => s.Status)
        .Distinct();

    PrintQueryString(StudentDistinct.ToQueryString());

    var Student = StudentDistinct.ToList();

    foreach (var student in StudentDistinct)
    {
        Console.WriteLine($"Student {student}");
    }

    Console.WriteLine();
    // Group by

    var Getgroupby = context.Students
        .GroupBy(s => s.Status)
        .Select
        (s => new 
        {
            status = s.Key,
            Total = s.Count()
        })
        .OrderBy (s => s.status);

    foreach (var group in Getgroupby)
    {
        Console.WriteLine($" {group.status} - {group.Total}");
    }
}

static void GetStudentByHaving(AppDbContext context)
{
    var GetStudentByHaving = context.Students
         .GroupBy(s => s.Status)
         .Where(s => s.Count() > 3)
         .Select(s => new 
         {
             Status = s.Key,
             TotalOfStudent = s.Count()    })
         .ToList();

    foreach (var item in GetStudentByHaving)
    {
        Console.WriteLine($"{item.Status} - {item.TotalOfStudent}.");
    }
}

static void GetStudentByInclude(AppDbContext context)
{
    // Good way
    var query = context.Students
        .Include(s => s.Enrollments);

    var student = query.ToList();

    foreach(var item in student)
    {
        Console.WriteLine($"{item.StudentId} - {item.FirstName} - {item.Enrollments.Count}");
    }

    // Best way
    var query2 = context.Students
        .Select(s => new
        {
            s.FirstName,
            s.LastName,
            Count = s.Enrollments.Count
        });

    var exeQue = query2.ToList();

    foreach(var exe in exeQue)
    {
        Console.WriteLine($"{exe.FirstName} - {exe.LastName} - {exe.Count}");
    }
}

static void GetStudentByIncludeThenInclude(AppDbContext context)
{
    var query = context.Students
        .Include(s => s.Enrollments)
        .ThenInclude(e => e.Course);

    var student = query.ToList();

    foreach(var item in student)
    {
        Console.WriteLine($"{item.StudentId} - {item.FirstName} - {item.Enrollments.Count}");
        foreach(var enroll in item.Enrollments)
        {
            Console.WriteLine($"Course Name: {enroll.Course.Title}");
        }
    }
}

static void GetStudentByIncludeThenInclude2(AppDbContext context)
{
    var query = context.Students
        .Include(s => s.Enrollments)
        .ThenInclude(s => s.Course);

    var student = query.ToList();

    foreach(var item in student)
    {
        Console.WriteLine($"{item.FirstName} - {item.LastName} - {item.Enrollments.Count}");
        foreach(var item2 in item.Enrollments)
        {
            Console.WriteLine($"{item2.Course.Title}");
        }
    }
}

static void GetStudentJoin(AppDbContext context)
{
    // inner join 
    var innerJoin = context.Courses
        .Join
        (
        context.Instructors,
        Course => Course.InstructorId,
        Instructor => Instructor.InstructorId,
        (Course, Instructor) => new
        {
            Course.CourseId,
            Fullname = Instructor.FirstName +" "+ Instructor.LastName,
            Course.Title,
            Course.Code,
        });

    foreach(var item in innerJoin)
    {
        Console.WriteLine($"{item.CourseId} - {item.Fullname} {item.Title} {item.Code} ");
    }

    //Another Way

    var AnotherWay =
        from c in context.Courses
        join i in context.Instructors
        on c.InstructorId equals i.InstructorId
        select new
        {
            c.CourseId,
            Fullname = i.FirstName + " " + i.LastName,
            c.Title,
            c.Code
        };
    var query = AnotherWay.OrderBy(o => o.CourseId);


    foreach(var item in query)
    {
        Console.WriteLine($"{item.CourseId} - {item.Fullname} {item.Title} {item.Code}");
    }


}

static void GetStudentWithProfileleftjoin(AppDbContext context)
{
    var Student =
        from s in context.Students
        join sp in context.StudentProfiles
        on s.StudentId equals sp.StudentId
        into ProfileGroup
        from sp in ProfileGroup.DefaultIfEmpty()
        select new
        {
            s.StudentId,
            studentName = s.FirstName + " " + s.LastName,
            City = sp != null ? sp.City : "No Profile",
            Country = sp != null ? sp.Country : "No Profile",
        };

    var query = Student.OrderBy(o => o.StudentId);
    
    foreach (var item in query)
    {
        Console.WriteLine($"{item.StudentId} - {item.studentName} {item.City} {item.Country}");
    }
}

static void GetProfileStudentWithStudentRightJoin(AppDbContext context)
{
    var rightJoin =
        from s in context.Students
        join e in context.Enrollments
        on s.StudentId equals e.StudentId
        into ProfileGroup
        from e in ProfileGroup.DefaultIfEmpty()
        select new
        {
            s.StudentId,
            fullName = s.FirstName + " " + s.LastName,
            e.ProgressPercent
        };

    var query = rightJoin.OrderBy(s => s.StudentId);

    foreach(var item in query)
    {
        Console.WriteLine($"{item.StudentId} - {item.fullName} {item.ProgressPercent}");
    }
}

static void GetStudentWithEnrollmentbySelectMany(AppDbContext context)
{
    var SelectWithMany = context.Students.SelectMany
        (
        Student => Student.Enrollments,
        (Student, Enrollments) => new
        {
            Student.StudentId,
            FullName = Student.FirstName + " " + Student.LastName,
            Enrollments.ProgressPercent
        }
        );

    foreach (var item in SelectWithMany)
    {
        Console.WriteLine($"{item.StudentId} {item.FullName} {item.ProgressPercent}");
    }

}

static void SubQueries(AppDbContext context)
{
    var query = context.Courses
        .Where(s => s.Price > context.Courses.Average(s => s.Price));
    int avg = (int)context.Courses.Average(s => s.Price);
    Console.WriteLine(avg);
    foreach (var item in query)
    {
        Console.WriteLine(item.CourseId +" " + item.Price);
    }
}