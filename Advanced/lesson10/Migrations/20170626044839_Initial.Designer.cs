using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using lesson10;

namespace lesson10.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170626044839_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("lesson10.Group", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("lesson10.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("StudentGroupid");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.HasIndex("StudentGroupid");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("lesson10.Student", b =>
                {
                    b.HasOne("lesson10.Group", "StudentGroup")
                        .WithMany()
                        .HasForeignKey("StudentGroupid");
                });
        }
    }
}
