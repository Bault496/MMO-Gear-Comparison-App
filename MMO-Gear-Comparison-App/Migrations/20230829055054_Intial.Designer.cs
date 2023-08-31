﻿// <auto-generated />
using System;
using MMO_Gear_Comparison_App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MMO_Gear_Comparison_App.Migrations
{
    [DbContext(typeof(GearContext))]
    [Migration("20230829055054_Intial")]
    partial class Intial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MMO_Gear_Comparison_App.Gear", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemID"));

                    b.Property<int?>("ArmorScaling")
                        .HasColumnType("int");

                    b.Property<int?>("DamageScaling")
                        .HasColumnType("int");

                    b.Property<int?>("Durability")
                        .HasColumnType("int");

                    b.Property<string>("GearSlot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GearType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemLevel")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryStat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrimaryStatScaling")
                        .HasColumnType("int");

                    b.Property<string>("SecondaryStat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SecondaryStatScaling")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.ToTable("Gears");
                });
#pragma warning restore 612, 618
        }
    }
}