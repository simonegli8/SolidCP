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

public partial class StorageSpaceConfiguration: Extensions.EntityTypeConfiguration<StorageSpace>
{

    public StorageSpaceConfiguration(): base() { }
    public StorageSpaceConfiguration(DbFlavor flavor): base(flavor) { }

#if NetCore || NetFX
    public override void Configure() {
        HasKey(e => e.Id).HasName("PK__StorageS__3214EC07B8B9A6D1");

        HasOne(d => d.Server).WithMany(p => p.StorageSpaces).HasConstraintName("FK_StorageSpaces_ServerId");

        HasOne(d => d.Service).WithMany(p => p.StorageSpaces).HasConstraintName("FK_StorageSpaces_ServiceId");
    }
#endif
}