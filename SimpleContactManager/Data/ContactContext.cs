using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleContactManager.Models;
using Microsoft.EntityFrameworkCore;

namespace SimpleContactManager.Data
{
    public class ContactContext:DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
        }


        public DbSet<Contacts> contacts { get; set; }
        public DbSet<EmailAddress> EmailAddresses{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacts>().ToTable("Contacts");
            modelBuilder.Entity<EmailAddress>().ToTable("EmailAddress");
          
        }
    }
}
