using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyTrainingCenter.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Build configuration 
IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();


string? connectionString = configuration.GetConnectionString("DefaultConnection");

// Validate connection string. 
if (string.IsNullOrWhiteSpace(connectionString))
{
    Console.WriteLine("Connection string not found.");
    return;
}

// Configure EF Core 
var options = new DbContextOptionsBuilder<AppDBContext>()
    .UseSqlServer(connectionString)
    .UseSqlServer(connectionString)
    .LogTo(Console.WriteLine, LogLevel.Information)
    .Options;

// Create context 
using var context = new AppDBContext(options);

// Test 
Console.WriteLine("================================================");
Console.WriteLine(context.Database.CanConnect()
    ? "Connected! You are ready to retrieve Data :-)"
    : "Failed to connect.");
Console.WriteLine("================================================");
