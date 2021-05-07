using GymWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){ }
        public DbSet<Gymnast> Gymnasts { get; set; }
        public DbSet<Judges> Judges { get; set; }

        
    }
}
