using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Models
{
    public class BookDbContext: DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options): base(options)
        {

        }
        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        // {
        //     string conStr="User ID=sa; password=examlyMssql@123;MultipleActiveResultSets=true;server=localhost;Database=BookDb;trusted_connection=false;Persist Security Info=False;Encrypt=False";
        //     options.UseSqlServer(conStr);
        // }
        public DbSet<Book> Books{get;set;}
        public DbSet<Librarycard> Librarycards{get;set;}
    }
}