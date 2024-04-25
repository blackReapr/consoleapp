using Academy.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Academy.Data;

public class AcademyDbContext: DbContext
{
    public DbSet<Group> Groups { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-C20TBEU;Database=Academy;Trusted_Connection=Yes;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
}
