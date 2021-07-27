using System;
using Microsoft.EntityFrameworkCore;
using TechTest.Models;

namespace TechTest.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<NumberList> NumberLists { get; set; }
    }
}
