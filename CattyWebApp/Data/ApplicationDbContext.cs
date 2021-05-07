using CattyWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CattyWebApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
 
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Kitten> Kittens { get; set; }
    }
}
