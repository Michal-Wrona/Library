using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bibkioteka1
{
    class Books1Mapping : IEntityTypeConfiguration<Books1>
    {
        public void Configure(EntityTypeBuilder<Books1> builder)
        {
            builder.ToTable("Books", "dbo");
            builder.HasKey(x => x.Id);
        }
    }
}
