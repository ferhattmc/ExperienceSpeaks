using ExperienceSpeaks.Models;
using Microsoft.EntityFrameworkCore;

namespace ExperienceSpeaks.Data
{
    public class ExperienceSpeaksContext : DbContext
    {
        public ExperienceSpeaksContext(DbContextOptions<ExperienceSpeaksContext> opt) : base(opt)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}