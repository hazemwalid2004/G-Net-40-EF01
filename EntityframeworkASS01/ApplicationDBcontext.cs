using EntityframeworkASS01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkASS01
{
    internal class ApplicationDBcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost;Database=MyAppDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        #region DBsets
        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }  
        public DbSet<Category> categories { get; set; }
        #endregion
    }
}
