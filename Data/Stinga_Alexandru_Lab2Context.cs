using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stinga_Alexandru_Lab2.Models;

namespace Stinga_Alexandru_Lab2.Data
{
    public class Stinga_Alexandru_Lab2Context : DbContext
    {
        public Stinga_Alexandru_Lab2Context (DbContextOptions<Stinga_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Stinga_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Stinga_Alexandru_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Stinga_Alexandru_Lab2.Models.Authors> Authors { get; set; } = default!;
    }
}
