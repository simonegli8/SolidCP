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

public partial class AccessTokenConfiguration: Extensions.EntityTypeConfiguration<AccessToken>
{

    public AccessTokenConfiguration(): base() { }
    public AccessTokenConfiguration(DbFlavor flavor): base(flavor) { }

#if NetCore || NetFX
    public override void Configure() {
        HasKey(e => e.Id).HasName("PK__AccessTo__3214EC27A32557FE");

        HasOne(d => d.Account).WithMany(p => p.AccessTokens).HasConstraintName("FK_AccessTokens_UserId");
    }
#endif
}