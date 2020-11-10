using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using CaApp.Models.ConData;

namespace CaApp.Data
{
  public partial class ConDataContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public ConDataContext(DbContextOptions<ConDataContext> options):base(options)
    {
    }

    public ConDataContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<CaApp.Models.ConData.Student>()
              .HasOne(i => i.Gender)
              .WithMany(i => i.Students)
              .HasForeignKey(i => i.GenderID)
              .HasPrincipalKey(i => i.GenderID);
        builder.Entity<CaApp.Models.ConData.Student>()
              .HasOne(i => i.Country)
              .WithMany(i => i.Students)
              .HasForeignKey(i => i.NationalityID)
              .HasPrincipalKey(i => i.CountryID);
        builder.Entity<CaApp.Models.ConData.Student>()
              .HasOne(i => i.Country1)
              .WithMany(i => i.Students1)
              .HasForeignKey(i => i.FatherNationalityID)
              .HasPrincipalKey(i => i.CountryID);
        builder.Entity<CaApp.Models.ConData.Student>()
              .HasOne(i => i.Country2)
              .WithMany(i => i.Students2)
              .HasForeignKey(i => i.MotherNationalityID)
              .HasPrincipalKey(i => i.CountryID);
        builder.Entity<CaApp.Models.ConData.Student>()
              .HasOne(i => i.Country3)
              .WithMany(i => i.Students3)
              .HasForeignKey(i => i.GuardianNationalityID)
              .HasPrincipalKey(i => i.CountryID);


        builder.Entity<CaApp.Models.ConData.DeviceCode>()
              .Property(p => p.CreationTime)
              .HasColumnType("datetime2");

        builder.Entity<CaApp.Models.ConData.DeviceCode>()
              .Property(p => p.Expiration)
              .HasColumnType("datetime2");

        builder.Entity<CaApp.Models.ConData.PersistedGrant>()
              .Property(p => p.CreationTime)
              .HasColumnType("datetime2");

        builder.Entity<CaApp.Models.ConData.PersistedGrant>()
              .Property(p => p.Expiration)
              .HasColumnType("datetime2");

        this.OnModelBuilding(builder);
    }


    public DbSet<CaApp.Models.ConData.Country> Countries
    {
      get;
      set;
    }

    public DbSet<CaApp.Models.ConData.DeviceCode> DeviceCodes
    {
      get;
      set;
    }

    public DbSet<CaApp.Models.ConData.Gender> Genders
    {
      get;
      set;
    }

    public DbSet<CaApp.Models.ConData.PersistedGrant> PersistedGrants
    {
      get;
      set;
    }

    public DbSet<CaApp.Models.ConData.Student> Students
    {
      get;
      set;
    }
  }
}
