//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v4.2.1.3
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AirTagTracker
{
   /// <inheritdoc/>
   public partial class FindMyModel : DbContext
   {
      #region DbSets
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::AirTagTracker.AirTagData> AirTagDatas { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::AirTagTracker.UploadSession> UploadSessions { get; set; }

      #endregion DbSets

      /// <summary>
      /// Default connection string
      /// </summary>
      public static string ConnectionString { get; set; } = @"Server=tcp:granitetestingground.database.windows.net,1433;Initial Catalog=airtags;Persist Security Info=False;User ID=GraniteAdmin;Password=mBnx$Ddqc$yP9wR;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

      /// <summary>
      ///     <para>
      ///         Initializes a new instance of the <see cref="T:Microsoft.EntityFrameworkCore.DbContext" /> class using the specified options.
      ///         The <see cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" /> method will still be called to allow further
      ///         configuration of the options.
      ///     </para>
      /// </summary>
      /// <param name="options">The options for this context.</param>
      public FindMyModel(DbContextOptions<FindMyModel> options) : base(options)
      {
      }

      partial void CustomInit(DbContextOptionsBuilder optionsBuilder);

      partial void OnModelCreatingImpl(ModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(ModelBuilder modelBuilder);

      /// <summary>
      ///     Override this method to further configure the model that was discovered by convention from the entity types
      ///     exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
      ///     and re-used for subsequent instances of your derived context.
      /// </summary>
      /// <remarks>
      ///     If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
      ///     then this method will not be run.
      /// </remarks>
      /// <param name="modelBuilder">
      ///     The builder being used to construct the model for this context. Databases (and other extensions) typically
      ///     define extension methods on this object that allow you to configure aspects of the model that are specific
      ///     to a given database.
      /// </param>
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");

         modelBuilder.Entity<global::AirTagTracker.AirTagData>()
                     .ToTable("AirTagDatas")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::AirTagTracker.AirTagData>()
                     .Property(t => t.Id)
                     .ValueGeneratedOnAdd()
                     .IsRequired();

         modelBuilder.Entity<global::AirTagTracker.UploadSession>()
                     .ToTable("UploadSessions")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::AirTagTracker.UploadSession>()
                     .Property(t => t.Id)
                     .ValueGeneratedOnAdd()
                     .IsRequired();
         modelBuilder.Entity<global::AirTagTracker.UploadSession>()
                     .Property(t => t.DateTimeDataAccessed)
                     .IsRequired();
         modelBuilder.Entity<global::AirTagTracker.UploadSession>()
                     .Property(t => t.SessionDateTime)
                     .IsRequired();
         modelBuilder.Entity<global::AirTagTracker.UploadSession>()
                     .Property(t => t.DateTimeDataLastModified)
                     .IsRequired();
         modelBuilder.Entity<global::AirTagTracker.UploadSession>()
                     .HasMany<global::AirTagTracker.AirTagData>(p => p.AirTagDatas)
                     .WithOne()
                     .HasForeignKey("UploadSessionAirTagDatasId")
                     .IsRequired();

         OnModelCreatedImpl(modelBuilder);
      }
   }
}
