using Microsoft.EntityFrameworkCore;

namespace StudentManager.Models;

/// <summary>
/// Student database context class
/// </summary>
public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    {
        
    }
    public DbSet<Student> Students { get; set; }
}