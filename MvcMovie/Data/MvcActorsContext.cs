using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcActorsContext : DbContext
    {
        public MvcActorsContext(DbContextOptions<MvcActorsContext> options)
            : base(options)
        {
        }

        public DbSet<Actors> Actors { get; set; }
    }
}
