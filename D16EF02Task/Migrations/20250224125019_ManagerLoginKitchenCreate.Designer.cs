﻿// <auto-generated />
using D16EF02Task.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace D16EF02Task.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20250224125019_ManagerLoginKitchenCreate")]
    partial class ManagerLoginKitchenCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("D16EF02Task.Entities.ManagerLoginFrontend", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Username");

                    b.ToTable("ManagerLoginFrontend");
                });

            modelBuilder.Entity("D16EF02Task.Entities.ManagerLoginKitchen", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Username");

                    b.ToTable("ManagerLoginKitchen");
                });
#pragma warning restore 612, 618
        }
    }
}
