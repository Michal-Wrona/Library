using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bibkioteka1
{
    class BookBorrowingsMapping : IEntityTypeConfiguration<BookBorrowings>
    {
        public void Configure(EntityTypeBuilder<BookBorrowings> builder)
        {
            builder.ToTable("BookBorrowings", "dbo");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Book).WithMany();
            builder.HasOne(x => x.People).WithMany();
        }
    }
}
