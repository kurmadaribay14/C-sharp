using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using task5;

namespace task5.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("task5.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CarCompanyId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CarCompanyId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("task5.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("task5.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("task5.RefColorCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("RefCarId");

                    b.Property<int?>("RefColorId");

                    b.HasKey("Id");

                    b.HasIndex("RefCarId");

                    b.HasIndex("RefColorId");

                    b.ToTable("RefColorCar");
                });

            modelBuilder.Entity("task5.Car", b =>
                {
                    b.HasOne("task5.Company", "CarCompany")
                        .WithMany("Cars")
                        .HasForeignKey("CarCompanyId");
                });

            modelBuilder.Entity("task5.RefColorCar", b =>
                {
                    b.HasOne("task5.Car", "RefCar")
                        .WithMany()
                        .HasForeignKey("RefCarId");

                    b.HasOne("task5.Color", "RefColor")
                        .WithMany()
                        .HasForeignKey("RefColorId");
                });
        }
    }
}
