using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Andriesei_Tudor_Lab2.Models;

namespace Andriesei_Tudor_Lab2.Data
{
    public class Andriesei_Tudor_Lab2Context : DbContext
    {
        public Andriesei_Tudor_Lab2Context (DbContextOptions<Andriesei_Tudor_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Andriesei_Tudor_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Andriesei_Tudor_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Andriesei_Tudor_Lab2.Models.Category> Category { get; set; }
    }
}
