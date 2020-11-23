﻿// <auto-generated />
using AppGear.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppGear.API.Migrations
{
    [DbContext(typeof(LorawanContext))]
    [Migration("20201123114151_TableProductionAndTest")]
    partial class TableProductionAndTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppGear.API.Models.LoriotProduction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LoriotId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EUI")
                        .HasColumnName("EUI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ack")
                        .HasColumnName("ack")
                        .HasColumnType("bit");

                    b.Property<int>("bat")
                        .HasColumnName("bat")
                        .HasColumnType("int");

                    b.Property<string>("cmd")
                        .HasColumnName("cmd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("data")
                        .HasColumnName("data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("encdata")
                        .HasColumnName("encdata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fcnt")
                        .HasColumnName("fcnt")
                        .HasColumnType("int");

                    b.Property<int>("port")
                        .HasColumnName("port")
                        .HasColumnType("int");

                    b.Property<long>("ts")
                        .HasColumnName("ts")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("LoriotProduction");
                });

            modelBuilder.Entity("AppGear.API.Models.LoriotTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LoriotId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EUI")
                        .HasColumnName("EUI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ack")
                        .HasColumnName("ack")
                        .HasColumnType("bit");

                    b.Property<int>("bat")
                        .HasColumnName("bat")
                        .HasColumnType("int");

                    b.Property<string>("cmd")
                        .HasColumnName("cmd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("data")
                        .HasColumnName("data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("encdata")
                        .HasColumnName("encdata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fcnt")
                        .HasColumnName("fcnt")
                        .HasColumnType("int");

                    b.Property<int>("port")
                        .HasColumnName("port")
                        .HasColumnType("int");

                    b.Property<long>("ts")
                        .HasColumnName("ts")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("LoriotTest");
                });
#pragma warning restore 612, 618
        }
    }
}
