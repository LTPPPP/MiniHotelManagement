using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Assignment02.Models;

public partial class FuminiHotelManagementContext : DbContext
{
    public FuminiHotelManagementContext()
    {
    }

    public FuminiHotelManagementContext(DbContextOptions<FuminiHotelManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookingDetail> BookingDetails { get; set; }

    public virtual DbSet<BookingReservation> BookingReservations { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<RoomInformation> RoomInformations { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(GetConnectionString());
	}
	private string? GetConnectionString()
	{
		IConfiguration configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", true, true).Build();
		return configuration["ConnectionStrings:DBDefault"];
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookingDetail>(entity =>
        {
            entity.HasKey(e => new { e.BookingReservationId, e.RoomId }).HasName("PK__BookingD__219A5D2EFFCD07A7");

            entity.ToTable("BookingDetail");

            entity.Property(e => e.BookingReservationId).HasColumnName("BookingReservationID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.ActualPrice).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.BookingReservation).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.BookingReservationId)
                .HasConstraintName("FK__BookingDe__Booki__4222D4EF");

            entity.HasOne(d => d.Room).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK__BookingDe__RoomI__4316F928");
        });

        modelBuilder.Entity<BookingReservation>(entity =>
        {
            entity.HasKey(e => e.BookingReservationId).HasName("PK__BookingR__A2B23EBFEB9A5418");

            entity.ToTable("BookingReservation");

            entity.Property(e => e.BookingReservationId).HasColumnName("BookingReservationID");
            entity.Property(e => e.BookingStatus).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Customer).WithMany(p => p.BookingReservations)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__BookingRe__Custo__3F466844");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B8559AEC05");

            entity.ToTable("Customer");

            entity.HasIndex(e => e.EmailAddress, "UQ__Customer__49A1474083E73F91").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerFullName).HasMaxLength(100);
            entity.Property(e => e.CustomerStatus).HasMaxLength(50);
            entity.Property(e => e.EmailAddress).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Telephone).HasMaxLength(20);
        });

        modelBuilder.Entity<RoomInformation>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__RoomInfo__32863919765AA8BF");

            entity.ToTable("RoomInformation");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomDetailDescription).HasMaxLength(255);
            entity.Property(e => e.RoomNumber).HasMaxLength(10);
            entity.Property(e => e.RoomPricePerDay).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RoomStatus).HasMaxLength(50);
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");

            entity.HasOne(d => d.RoomType).WithMany(p => p.RoomInformations)
                .HasForeignKey(d => d.RoomTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__RoomInfor__RoomT__3C69FB99");
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.HasKey(e => e.RoomTypeId).HasName("PK__RoomType__BCC8961180CE99EA");

            entity.ToTable("RoomType");

            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");
            entity.Property(e => e.RoomTypeName).HasMaxLength(50);
            entity.Property(e => e.TypeDescription).HasMaxLength(255);
            entity.Property(e => e.TypeNote).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
