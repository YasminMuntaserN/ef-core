﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace study_center_ef.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241129144942_SeedDataForClasses")]
    partial class SeedDataForClasses
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("study_center_ef.Entities.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassID"));

                    b.Property<byte>("Capacity")
                        .HasColumnType("TINYINT");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("ClassID");

                    b.ToTable("Classes", (string)null);

                    b.HasData(
                        new
                        {
                            ClassID = 1,
                            Capacity = (byte)30,
                            ClassName = "Math-101",
                            Description = "Intro to Algebra"
                        },
                        new
                        {
                            ClassID = 2,
                            Capacity = (byte)25,
                            ClassName = "Sci-102",
                            Description = "Basic Chemistry"
                        },
                        new
                        {
                            ClassID = 3,
                            Capacity = (byte)20,
                            ClassName = "Eng-201",
                            Description = "Advanced Grammar"
                        },
                        new
                        {
                            ClassID = 4,
                            Capacity = (byte)15,
                            ClassName = "Hist-301",
                            Description = "World History"
                        });
                });

            modelBuilder.Entity("study_center_ef.Entities.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentID"));

                    b.Property<DateTime>("DeletionDate")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("DateTime");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("GroupID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollments", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.GradeLevel", b =>
                {
                    b.Property<int>("GradeLevelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeLevelID"));

                    b.Property<string>("GradeLevelName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("GradeLevelID");

                    b.ToTable("GradeLevels", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.GradeLevelSubject", b =>
                {
                    b.Property<int>("GradeLevelSubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeLevelSubjectID"));

                    b.Property<int>("Fees")
                        .HasColumnType("int");

                    b.Property<int>("GradeLevelID")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("GradeLevelSubjectID");

                    b.HasIndex("GradeLevelID");

                    b.HasIndex("SubjectID");

                    b.ToTable("GradeLevelSubjects", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupID"));

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("DateTime");

                    b.Property<int>("GradeLevelSubjectID")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("GroupStudentCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MeetingTimeID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherSubjectID")
                        .HasColumnType("int");

                    b.HasKey("GroupID");

                    b.HasIndex("ClassID");

                    b.HasIndex("GradeLevelSubjectID");

                    b.HasIndex("TeacherSubjectID");

                    b.ToTable("Groups", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.MeetingTime", b =>
                {
                    b.Property<int>("MeetingTimeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("DateTime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("DateTime2");

                    b.HasKey("MeetingTimeID");

                    b.ToTable(" MeetingTimes", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("DateTime2");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("GroupID");

                    b.HasIndex("StudentID");

                    b.ToTable("Payments", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<byte>("Gender")
                        .HasColumnType("TINYINT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("ThirdName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("PersonID");

                    b.ToTable("People", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<int>("GradeLevelID")
                        .HasColumnType("int");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.HasIndex("GradeLevelID");

                    b.HasIndex("PersonID");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectID"));

                    b.Property<int>("GradeLevelId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("SubjectID");

                    b.HasIndex("GradeLevelId");

                    b.ToTable("Subjects", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"));

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("DateTime2");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal");

                    b.HasKey("TeacherID");

                    b.HasIndex("PersonID");

                    b.ToTable("Teachers", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.TeacherSubject", b =>
                {
                    b.Property<int>("TeacherSubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherSubjectID"));

                    b.Property<int>("GradeLevelSubjectID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("TeacherSubjectID");

                    b.HasIndex("GradeLevelSubjectID");

                    b.HasIndex("TeacherID");

                    b.ToTable("TeacherSubjects", (string)null);
                });

            modelBuilder.Entity("study_center_ef.Entities.Enrollment", b =>
                {
                    b.HasOne("study_center_ef.Entities.Group", "Group")
                        .WithMany("Enrollments")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("study_center_ef.Entities.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("study_center_ef.Entities.GradeLevelSubject", b =>
                {
                    b.HasOne("study_center_ef.Entities.GradeLevel", "GradeLevel")
                        .WithMany("GradeLevelSubjects")
                        .HasForeignKey("GradeLevelID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("study_center_ef.Entities.Subject", "Subject")
                        .WithMany("GradeLevelSubjects")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("GradeLevel");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("study_center_ef.Entities.Group", b =>
                {
                    b.HasOne("study_center_ef.Entities.Class", "Class")
                        .WithMany("Groups")
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("study_center_ef.Entities.GradeLevelSubject", "GradeLevelSubject")
                        .WithMany("Groups")
                        .HasForeignKey("GradeLevelSubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("study_center_ef.Entities.TeacherSubject", "TeacherSubject")
                        .WithMany("Groups")
                        .HasForeignKey("TeacherSubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("GradeLevelSubject");

                    b.Navigation("TeacherSubject");
                });

            modelBuilder.Entity("study_center_ef.Entities.MeetingTime", b =>
                {
                    b.HasOne("study_center_ef.Entities.Group", "Group")
                        .WithOne("MeetingTime")
                        .HasForeignKey("study_center_ef.Entities.MeetingTime", "MeetingTimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("study_center_ef.Entities.Payment", b =>
                {
                    b.HasOne("study_center_ef.Entities.Group", "Group")
                        .WithMany("Payments")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("study_center_ef.Entities.Student", "Student")
                        .WithMany("Payments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("study_center_ef.Entities.Student", b =>
                {
                    b.HasOne("study_center_ef.Entities.GradeLevel", "GradeLevel")
                        .WithMany("Students")
                        .HasForeignKey("GradeLevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("study_center_ef.Entities.Person", "Person")
                        .WithMany("Students")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GradeLevel");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("study_center_ef.Entities.Subject", b =>
                {
                    b.HasOne("study_center_ef.Entities.GradeLevel", "GradeLevel")
                        .WithMany("Subjects")
                        .HasForeignKey("GradeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GradeLevel");
                });

            modelBuilder.Entity("study_center_ef.Entities.Teacher", b =>
                {
                    b.HasOne("study_center_ef.Entities.Person", "Person")
                        .WithMany("Teachers")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("study_center_ef.Entities.TeacherSubject", b =>
                {
                    b.HasOne("study_center_ef.Entities.GradeLevelSubject", "GradeLevelSubject")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("GradeLevelSubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("study_center_ef.Entities.Teacher", "Teacher")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GradeLevelSubject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("study_center_ef.Entities.Class", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("study_center_ef.Entities.GradeLevel", b =>
                {
                    b.Navigation("GradeLevelSubjects");

                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("study_center_ef.Entities.GradeLevelSubject", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("TeacherSubjects");
                });

            modelBuilder.Entity("study_center_ef.Entities.Group", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("MeetingTime")
                        .IsRequired();

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("study_center_ef.Entities.Person", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("study_center_ef.Entities.Student", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("study_center_ef.Entities.Subject", b =>
                {
                    b.Navigation("GradeLevelSubjects");
                });

            modelBuilder.Entity("study_center_ef.Entities.Teacher", b =>
                {
                    b.Navigation("TeacherSubjects");
                });

            modelBuilder.Entity("study_center_ef.Entities.TeacherSubject", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}