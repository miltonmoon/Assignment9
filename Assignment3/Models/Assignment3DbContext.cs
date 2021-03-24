using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Assignment3DbContext : DbContext
    {
        public Assignment3DbContext (DbContextOptions<Assignment3DbContext> options) : base (options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
