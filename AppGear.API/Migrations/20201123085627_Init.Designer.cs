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
    [Migration("20201123085627_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppGear.API.Models.Loriot", b =>
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

                    b.Property<string>("rx")
                        .HasColumnName("cmd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ts")
                        .HasColumnName("ts")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Loriot");
                });
#pragma warning restore 612, 618
        }
    }
}
