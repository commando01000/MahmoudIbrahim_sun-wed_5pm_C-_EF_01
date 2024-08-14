﻿// <auto-generated />
using System;
using MahmoudIbrahim_sun_wed_5pm_C__EF_01.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_01.Migrations
{
    [DbContext(typeof(StudentDBClass))]
    [Migration("20240814233350_instructor_department")]
    partial class instructor_department
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("TopicId")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Instructor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("Bonus")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<int>("HourRate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int?>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("departmentId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("departmentId");

                    b.ToTable("instructors");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Topic", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Course", b =>
                {
                    b.HasOne("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Topic", "Topic")
                        .WithOne("Course")
                        .HasForeignKey("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Course", "TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Instructor", b =>
                {
                    b.HasOne("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Student", b =>
                {
                    b.HasOne("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.StudentCourse", b =>
                {
                    b.HasOne("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Course", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Instructor", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities.Topic", b =>
                {
                    b.Navigation("Course")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
