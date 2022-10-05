using Microsoft.EntityFrameworkCore;

namespace StudentManager.Models;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    {
        
    }

    public DbSet<Student> Students { get; set; }

    public DbSet<Subject> Subjects { get; set; }
}