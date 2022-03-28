#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razor_review.Models;

    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<razor_review.Models.School> School { get; set; }

        public DbSet<razor_review.Models.Student> Student { get; set; }
    }
