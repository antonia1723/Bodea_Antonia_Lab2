using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bodea_Antonia_Lab2.Models;

namespace Bodea_Antonia_Lab2.Data
{
    public class Bodea_Antonia_Lab2Context : DbContext
    {
        public Bodea_Antonia_Lab2Context (DbContextOptions<Bodea_Antonia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bodea_Antonia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Bodea_Antonia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Bodea_Antonia_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
