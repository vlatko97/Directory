using Microsoft.EntityFrameworkCore;
using Directory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Directory.Data
{
    public class DirectoryContext : DbContext
    {
        public DirectoryContext(DbContextOptions<DirectoryContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
