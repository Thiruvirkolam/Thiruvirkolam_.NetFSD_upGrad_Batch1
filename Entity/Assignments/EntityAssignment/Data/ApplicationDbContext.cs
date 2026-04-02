using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using EntityAssignment.Models;

namespace EntityAssignment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Account> Accounts {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Thiru\\SQLEXPRESS;Initial Catalog=EntityAssignmentDB;Integrated Security=True; TrustServerCertificate=True;");
        }
    }
}