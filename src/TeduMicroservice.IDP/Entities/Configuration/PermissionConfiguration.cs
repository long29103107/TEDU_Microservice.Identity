﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduMicroservice.IDP.Common;

namespace TeduMicroservice.IDP.Entities.Configuration;

public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.ToTable("Permissions", SystemConstants.IdentitySchema)
            .HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.HasIndex(c => new { c.RoleId, c.Function, c.Command })
            .IsUnique();
    }
}
