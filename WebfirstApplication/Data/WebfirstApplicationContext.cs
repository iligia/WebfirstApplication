using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace WebfirstApplication.Models
{
    public class WebfirstApplicationContext : DbContext
    {
        public WebfirstApplicationContext (DbContextOptions<WebfirstApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
