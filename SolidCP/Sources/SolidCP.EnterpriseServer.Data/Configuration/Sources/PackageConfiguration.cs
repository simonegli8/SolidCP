﻿// This file is auto generated, do not edit.
using System;
using System.Collections.Generic;
using SolidCP.EnterpriseServer.Data.Configuration;
using SolidCP.EnterpriseServer.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
#if NetCore
using Microsoft.EntityFrameworkCore;
#endif
#if NetFX
using System.Data.Entity;
#endif

namespace SolidCP.EnterpriseServer.Data.Configuration;

public partial class PackageConfiguration: Extensions.EntityTypeConfiguration<Package>
{

    public PackageConfiguration(): base() { }
    public PackageConfiguration(DbFlavor flavor): base(flavor) { }

#if NetCore || NetFX
    public override void Configure() {
        ToTable(tb => tb.HasTrigger("Update_StatusIDchangeDate"));

        Property(e => e.StatusIdchangeDate).HasDefaultValueSql("(getdate())");

        HasOne(d => d.ParentPackage).WithMany(p => p.InverseParentPackage).HasConstraintName("FK_Packages_Packages");

        HasOne(d => d.Plan).WithMany(p => p.Packages).HasConstraintName("FK_Packages_HostingPlans");

        HasOne(d => d.Server).WithMany(p => p.Packages).HasConstraintName("FK_Packages_Servers");

        HasOne(d => d.User).WithMany(p => p.Packages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Packages_Users");

        HasMany(d => d.Services).WithMany(p => p.Packages)
            .UsingEntity<Dictionary<string, object>>(
                "PackageService",
                r => r.HasOne<Service>().WithMany()
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("FK_PackageServices_Services"),
                l => l.HasOne<Package>().WithMany()
                        .HasForeignKey("PackageId")
                        .HasConstraintName("FK_PackageServices_Packages"),
                j => {
                    j.HasKey("PackageId", "ServiceId");
                    j.ToTable("PackageServices");
                    j.IndexerProperty<int>("PackageId").HasColumnName("PackageID");
                    j.IndexerProperty<int>("ServiceId").HasColumnName("ServiceID");
                });
    }
#endif
}