using EF__automatic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF__automatic.Context
{
    public class Library_2:DbContext
    {
        protected override void OnConfiguring( DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=WIN-EFS54O4O7OC\\SQLEXPRESS;Initial Catalog=Library_2;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            base.OnConfiguring(builder);
        }

        DbSet<Book>? Books { get; set; }
        DbSet<Author>? Authors { get; set; }
        DbSet<Student>? Students { get; set; }
        DbSet<BookType>? BookTypes { get; set; }
    }
}
