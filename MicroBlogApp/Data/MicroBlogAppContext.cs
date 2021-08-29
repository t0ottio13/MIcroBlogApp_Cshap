using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MicroBlogApp.Models;

    public class MicroBlogAppContext : DbContext
    {
        public MicroBlogAppContext (DbContextOptions<MicroBlogAppContext> options)
            : base(options)
        {
        }

        public DbSet<MicroBlogApp.Models.Person> Person { get; set; }

        public DbSet<MicroBlogApp.Models.Message> Message { get; set; }
    }
