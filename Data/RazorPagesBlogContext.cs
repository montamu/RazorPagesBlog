using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesBlog.Models;

namespace RazorPagesBlog.Data
{
    public class RazorPagesBlogContext : DbContext
    {
        public RazorPagesBlogContext (DbContextOptions<RazorPagesBlogContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blog { get; set; } = default!;
    }
}