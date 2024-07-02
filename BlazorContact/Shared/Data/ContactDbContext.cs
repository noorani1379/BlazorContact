using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorContact.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorContact.Shared.Data
{
    public class ContactDbContext:DbContext
    {
        
            //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Contact> Contacts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ContactDB;Integrated Security=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
