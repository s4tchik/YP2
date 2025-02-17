﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectForYp2.data;

#nullable disable

namespace ProjectForYp2.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20241119063930_Init3")]
    partial class Init3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectForYp2.Model.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int?>("MasterId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("MasterId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ProjectForYp2.Model.OrgTechType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("OrgTechType");
                });

            modelBuilder.Entity("ProjectForYp2.Model.Requests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("CompletionDate")
                        .HasColumnType("date");

                    b.Property<int>("Id_OrgTechTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Id_StatysId")
                        .HasColumnType("int");

                    b.Property<int?>("MasterId")
                        .HasColumnType("int");

                    b.Property<string>("OrgTechManufacture")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OrgTechModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OrgTechNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RepairParts")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("Id_OrgTechTypeId");

                    b.HasIndex("Id_StatysId");

                    b.HasIndex("MasterId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("ProjectForYp2.Model.Statys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Statys");
                });

            modelBuilder.Entity("ProjectForYp2.Model.Types", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("ProjectForYp2.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Phone")
                        .HasColumnType("decimal(11,0)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProjectForYp2.Model.Comment", b =>
                {
                    b.HasOne("ProjectForYp2.Model.User", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("ProjectForYp2.Model.User", "Master")
                        .WithMany()
                        .HasForeignKey("MasterId");

                    b.Navigation("Client");

                    b.Navigation("Master");
                });

            modelBuilder.Entity("ProjectForYp2.Model.Requests", b =>
                {
                    b.HasOne("ProjectForYp2.Model.User", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectForYp2.Model.OrgTechType", "Id_OrgTechType")
                        .WithMany()
                        .HasForeignKey("Id_OrgTechTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectForYp2.Model.Statys", "Id_Statys")
                        .WithMany()
                        .HasForeignKey("Id_StatysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectForYp2.Model.User", "Master")
                        .WithMany()
                        .HasForeignKey("MasterId");

                    b.Navigation("Client");

                    b.Navigation("Id_OrgTechType");

                    b.Navigation("Id_Statys");

                    b.Navigation("Master");
                });

            modelBuilder.Entity("ProjectForYp2.Model.User", b =>
                {
                    b.HasOne("ProjectForYp2.Model.Types", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
