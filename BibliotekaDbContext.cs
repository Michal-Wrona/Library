using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Bibkioteka1
{
    class BibliotekaDbContext : DbContext
    {
        private readonly string _connectionString;

        public BibliotekaDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Books1> Books1s { get; set; }

        public DbSet<People> Peoples { get; set; }
        
        public DbSet<BookBorrowings> BookBorrowings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
