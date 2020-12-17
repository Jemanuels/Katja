﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Katja.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20201217140258_AddedDeletedPropertyToStudent")]
    partial class AddedDeletedPropertyToStudent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Entities.Evaluation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EvaluationId");

                    b.Property<string>("AdditionalExplanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Evaluation");

                    b.HasData(
                        new
                        {
                            Id = new Guid("04a772a4-9801-4e2c-a38a-db00c9156176"),
                            AdditionalExplanation = "First test...",
                            Grade = 5,
                            StudentId = new Guid("660ed4cd-1361-4216-9faa-9636e4df681a")
                        },
                        new
                        {
                            Id = new Guid("e2e88444-3536-4c7b-b340-1cc0b2c84cc6"),
                            AdditionalExplanation = "Second test...",
                            Grade = 4,
                            StudentId = new Guid("660ed4cd-1361-4216-9faa-9636e4df681a")
                        },
                        new
                        {
                            Id = new Guid("ff578746-bdaa-4de6-a907-f78e5addc453"),
                            AdditionalExplanation = "First test...",
                            Grade = 3,
                            StudentId = new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac")
                        },
                        new
                        {
                            Id = new Guid("d7ee5482-5200-4845-841b-42873a2237a3"),
                            AdditionalExplanation = "Last test...",
                            Grade = 2,
                            StudentId = new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac")
                        },
                        new
                        {
                            Id = new Guid("a2e3870c-a0c8-433b-a8e3-2f90aed97af5"),
                            AdditionalExplanation = "First test...",
                            Grade = 5,
                            StudentId = new Guid("4addc421-0937-45cb-b55c-200b45c6caca")
                        },
                        new
                        {
                            Id = new Guid("7c95e27a-1f0b-4988-8759-24945135d722"),
                            AdditionalExplanation = "Last test...",
                            Grade = 3,
                            StudentId = new Guid("4addc421-0937-45cb-b55c-200b45c6caca")
                        });
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StudentId");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRegularStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"),
                            Age = 39,
                            Deleted = false,
                            IsRegularStudent = false,
                            Name = "Jurgen Emanuels"
                        },
                        new
                        {
                            Id = new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"),
                            Age = 58,
                            Deleted = false,
                            IsRegularStudent = false,
                            Name = "Alice Emanuels"
                        },
                        new
                        {
                            Id = new Guid("4addc421-0937-45cb-b55c-200b45c6caca"),
                            Age = 42,
                            Deleted = false,
                            IsRegularStudent = false,
                            Name = "Marsika Emanuels"
                        });
                });

            modelBuilder.Entity("Entities.StudentDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StudentDetailsId");

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("Entities.StudentSubject", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubject");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"),
                            SubjectId = new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8")
                        },
                        new
                        {
                            StudentId = new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"),
                            SubjectId = new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7")
                        },
                        new
                        {
                            StudentId = new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"),
                            SubjectId = new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad")
                        },
                        new
                        {
                            StudentId = new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"),
                            SubjectId = new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f")
                        },
                        new
                        {
                            StudentId = new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"),
                            SubjectId = new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8")
                        },
                        new
                        {
                            StudentId = new Guid("4addc421-0937-45cb-b55c-200b45c6caca"),
                            SubjectId = new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f")
                        });
                });

            modelBuilder.Entity("Entities.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SubjectId");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subject");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8"),
                            SubjectName = "Math"
                        },
                        new
                        {
                            Id = new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7"),
                            SubjectName = "English"
                        },
                        new
                        {
                            Id = new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad"),
                            SubjectName = "History"
                        },
                        new
                        {
                            Id = new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f"),
                            SubjectName = "Science"
                        });
                });

            modelBuilder.Entity("Entities.Evaluation", b =>
                {
                    b.HasOne("Entities.Student", "Student")
                        .WithMany("Evaluations")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Entities.StudentDetails", b =>
                {
                    b.HasOne("Entities.Student", "Student")
                        .WithOne("StudentDetails")
                        .HasForeignKey("Entities.StudentDetails", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Entities.StudentSubject", b =>
                {
                    b.HasOne("Entities.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Navigation("Evaluations");

                    b.Navigation("StudentDetails");

                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("Entities.Subject", b =>
                {
                    b.Navigation("StudentSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}