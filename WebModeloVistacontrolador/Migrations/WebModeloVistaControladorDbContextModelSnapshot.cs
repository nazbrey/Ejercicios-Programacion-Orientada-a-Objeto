﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebModeloVistacontrolador.Data;

#nullable disable

namespace WebModeloVistacontrolador.Migrations
{
    [DbContext(typeof(WebModeloVistaControladorDbContext))]
    partial class WebModeloVistaControladorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebModeloVistacontrolador.Models.Coordinator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Document")
                        .HasColumnType("int");

                    b.Property<Guid>("EnterpriseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("EnterpriseId1")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnterpriseId1");

                    b.ToTable("Coordinator");
                });

            modelBuilder.Entity("WebModeloVistacontrolador.Models.Enterprise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Enterprises");
                });

            modelBuilder.Entity("WebModeloVistacontrolador.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CoordinatorId")
                        .HasColumnType("int");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<Guid>("EnterpriseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("EnterpriseId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoordinatorId");

                    b.HasIndex("EnterpriseId1");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("WebModeloVistacontrolador.Models.Coordinator", b =>
                {
                    b.HasOne("WebModeloVistacontrolador.Models.Enterprise", null)
                        .WithMany("coordinators")
                        .HasForeignKey("EnterpriseId1");
                });

            modelBuilder.Entity("WebModeloVistacontrolador.Models.Worker", b =>
                {
                    b.HasOne("WebModeloVistacontrolador.Models.Coordinator", null)
                        .WithMany("workers")
                        .HasForeignKey("CoordinatorId");

                    b.HasOne("WebModeloVistacontrolador.Models.Enterprise", null)
                        .WithMany("Workers")
                        .HasForeignKey("EnterpriseId1");
                });

            modelBuilder.Entity("WebModeloVistacontrolador.Models.Coordinator", b =>
                {
                    b.Navigation("workers");
                });

            modelBuilder.Entity("WebModeloVistacontrolador.Models.Enterprise", b =>
                {
                    b.Navigation("Workers");

                    b.Navigation("coordinators");
                });
#pragma warning restore 612, 618
        }
    }
}
