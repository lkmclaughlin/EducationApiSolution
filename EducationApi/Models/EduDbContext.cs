using Microsoft.EntityFrameworkCore;

namespace EducationApi.Models;

public class EduDbContext : DbContext
{
    public DbSet<Major> Majors { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;

    // both DbContext references should match the DbContext class name
    public EduDbContext(DbContextOptions<EduDbContext> options) : base(options) { }
}
