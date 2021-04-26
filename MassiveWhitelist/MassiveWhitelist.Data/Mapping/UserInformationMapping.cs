using System;
using System.Collections.Generic;
using System.Text;
using MassiveWhitelist.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MassiveWhitelist.Data.Mapping
{
    public class UserInformationMapping : IEntityTypeConfiguration<UserInformation>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<UserInformation> builder)
        {
            builder.HasKey(o => o.UserId);
            builder.Property(o => o.UserId).ValueGeneratedOnAdd();

            builder.Property(o => o.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.LastName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.Email).HasMaxLength(50).IsRequired();
        }
    }
}
