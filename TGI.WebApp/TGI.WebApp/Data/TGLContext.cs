using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGI.WebApp.Models;

namespace TGI.WebApp.Data
{
    public class TGLContext: DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Computer> Computer { get; set; }

        public TGLContext(DbContextOptions<TGLContext> options): base(options)
        {
            this.Database.EnsureCreated();
        }
    }
}
