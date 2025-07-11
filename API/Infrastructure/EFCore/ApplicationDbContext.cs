using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.EFCore
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
