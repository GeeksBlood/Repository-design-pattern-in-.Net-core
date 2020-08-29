using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Database
{
    public partial class MyCompanyContext : DbContext
    {
        public MyCompanyContext()
        {
        }

        public MyCompanyContext(DbContextOptions<MyCompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Temployee> Temployee { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-7OETHJ8\\SQLEXPRESS;Database=MyCompany;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Temployee>(entity =>
            {
                entity.ToTable("temployee");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
