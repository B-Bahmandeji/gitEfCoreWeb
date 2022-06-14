using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWebDemo.Models
{
    public class EFCoreWebDemoContext : DbContext
    {
        //public EFCoreWebDemoContext()
        //{
        //}

        public EFCoreWebDemoContext(DbContextOptions<EFCoreWebDemoContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
