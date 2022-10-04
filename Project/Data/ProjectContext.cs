using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext (DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Project.Models.Author> Author { get; set; } = default!;

        public DbSet<Project.Models.Book> Book { get; set; }

        public DbSet<Project.Models.CheckoutHistory> CheckoutHistory { get; set; }

        public DbSet<Project.Models.Member> Member { get; set; }

        public DbSet<Project.Models.Staff> Staff { get; set; }
    }
}
