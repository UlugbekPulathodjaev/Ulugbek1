using adonetGet.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityEntry.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}