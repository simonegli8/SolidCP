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

public partial class ServerConfiguration: Extensions.EntityTypeConfiguration<Server>
{

    public ServerConfiguration(): base() { }
    public ServerConfiguration(DbFlavor flavor): base(flavor) { }

#if NetCore || NetFX
    public override void Configure() {
        Property(e => e.Adenabled).HasDefaultValue(false);
        Property(e => e.ServerUrl).HasDefaultValue("");

        HasOne(d => d.PrimaryGroup).WithMany(p => p.Servers).HasConstraintName("FK_Servers_ResourceGroups");
    }
#endif
}