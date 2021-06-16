using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie14.Models;

namespace RazorPagesMovie14.Data
{
    public class RazorPagesMovie14Context : DbContext
    {
        public RazorPagesMovie14Context (DbContextOptions<RazorPagesMovie14Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie14.Models.Movie> Movie { get; set; }
    }
}
