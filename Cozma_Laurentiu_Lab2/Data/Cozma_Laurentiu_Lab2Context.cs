using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cozma_Laurentiu_Lab2.Models;

namespace Cozma_Laurentiu_Lab2.Data
{
    public class Cozma_Laurentiu_Lab2Context : DbContext
    {
        public Cozma_Laurentiu_Lab2Context (DbContextOptions<Cozma_Laurentiu_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cozma_Laurentiu_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cozma_Laurentiu_Lab2.Models.Author> Author { get; set; }

        public DbSet<Cozma_Laurentiu_Lab2.Models.Publisher> Publisher { get; set; }

      
    }
}
