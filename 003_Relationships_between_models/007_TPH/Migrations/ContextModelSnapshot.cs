﻿// <auto-generated />
using _007_TPH;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace _007_TPH.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_007_TPH.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("_007_TPH.Employee", b =>
                {
                    b.HasBaseType("_007_TPH.User");

                    b.Property<int>("Salary");

                    b.ToTable("Employee");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("_007_TPH.Manager", b =>
                {
                    b.HasBaseType("_007_TPH.User");

                    b.Property<string>("Departament");

                    b.ToTable("Manager");

                    b.HasDiscriminator().HasValue("Manager");
                });
#pragma warning restore 612, 618
        }
    }
}
