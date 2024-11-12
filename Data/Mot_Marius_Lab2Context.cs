using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mot_Marius_Lab2.Models;

namespace Mot_Marius_Lab2.Data
{
    public class Mot_Marius_Lab2Context : DbContext
    {
        public Mot_Marius_Lab2Context (DbContextOptions<Mot_Marius_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mot_Marius_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Mot_Marius_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Mot_Marius_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Mot_Marius_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
