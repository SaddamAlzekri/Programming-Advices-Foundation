using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyTrainingCenter.Data;
using TrainingCenter.Entities;



namespace MyTrainingCenter.Data
{
    public partial class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentProfile> StudentProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseId);
                entity.HasIndex(e => e.InstructorId, "IX_Courses_InstructorId");
                entity.HasIndex(e => e.Status, "IX_Courses_Status");
                entity.HasIndex(e => e.Code, "UQ_Courses_Code").IsUnique();
                entity.Property(e => e.Code).HasMaxLength(30);
                entity.Property(e => e.Title).HasMaxLength(150);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.Price).HasColumnType("DECIMAL(10,2)");
                entity.Property(e => e.Level).HasMaxLength(30);
                entity.Property(e => e.DurationHours).HasColumnType("int");
                entity.Property(e => e.CreatedAt).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.PublishedAt).HasColumnType("DATETIME");
                entity.Property(e => e.Status).HasMaxLength(20);
                entity.Property(e => e.InstructorId).HasColumnType("int");



                entity.HasOne(e => e.Instructor)
                      .WithMany(e => e.Courses)
                      .HasForeignKey(e => e.InstructorId)
                      .HasConstraintName("FK_Courses_Instructors");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(e => e.InstructorId);
                entity.HasIndex(e => e.ManagerId, "IX_Instructors_ManagerId");
                entity.HasIndex(e => e.Email, "UQ_Instructors_Email").IsUnique();

                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.Email).HasMaxLength(150);
                entity.Property(e => e.HireDate).HasColumnType("DATE");
                entity.Property(e => e.Salary).HasColumnType("DECIMAL(10, 2)");
                entity.Property(e => e.ManagerId).HasColumnType("int");
                entity.Property(e => e.IsActive).HasDefaultValue(true);

                entity.HasOne(e => e.Manager)
                      .WithMany(e => e.InverseManager)
                      .HasForeignKey(e => e.ManagerId)
                      .HasConstraintName("FK_Instructors_Manager");

            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => e.EnrollmentId);
                entity.HasIndex(e => e.Status, "IX_Enrollments_Status");

                entity.HasIndex(e => e.StudentId, "IX_Enrollments_StudentId");
                entity.HasIndex(e => e.CourseId, "IX_Enrollments_CourseId");

                entity.HasIndex(e =>new { e.StudentId, e.CourseId }, "UQ_Enrollments_StudentId_CourseId UNIQUE").IsUnique();

                entity.Property(e => e.StudentId).HasColumnType("int");
                entity.Property(e => e.CourseId).HasColumnType("int");
                entity.Property(e => e.EnrollmentDate).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.CompletionDate).HasColumnType("DATETIME");
                entity.Property(e => e.ProgressPercent).HasColumnType("DECIMAL(5,2)").HasDefaultValue(0);
                entity.Property(e => e.FinalGrade).HasColumnType("DECIMAL(5,2)");
                entity.Property(e => e.Status).HasMaxLength(20);

                entity.HasOne(e => e.Course)
                      .WithMany(e => e.Enrollments)
                      .HasForeignKey(e => e.CourseId)
                      .HasConstraintName("FK_Enrollments_Courses");

                entity.HasOne(e => e.Student)
                      .WithMany(e => e.Enrollments)
                      .HasForeignKey(e => e.StudentId)
                      .HasConstraintName("FK_Enrollments_Students");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentId);
                entity.HasIndex(e => e.Status, "IX_Students_Status");
                
                entity.HasIndex(e => e.Email, "UQ_Students_Email").IsUnique();
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.Email).HasMaxLength(150);
                entity.Property(e => e.DateOfBirth).HasColumnType("DATE");
                entity.Property(e => e.RegisteredAt).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.Status).HasMaxLength(20);
                entity.Property(e => e.PhoneNumber).HasMaxLength(30);

            });

            modelBuilder.Entity<StudentProfile>(entity =>
            {
                entity.HasKey(e => e.StudentId);
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.City).HasMaxLength(100);
                entity.Property(e => e.Country).HasMaxLength(100);
                entity.Property(e => e.Bio).HasMaxLength(500);
                entity.Property(e => e.LinkedInUrl).HasMaxLength(200);

                entity.HasOne(e => e.Student)
                      .WithOne(e => e.StudentProfile)
                      .HasForeignKey<StudentProfile>(d => d.StudentId)
                      .HasConstraintName("FK_StudentProfiles_Students");
            });
        }
    }
}
