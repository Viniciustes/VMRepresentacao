﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VMRepresentacao.Infrastructure.Data.Contexts;

namespace VMRepresentacao.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VMRepresentacao.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("City");

                    b.Property<DateTime>("DateRegister");

                    b.Property<string>("District");

                    b.Property<int>("Number");

                    b.Property<string>("Reference");

                    b.Property<int>("State");

                    b.Property<string>("Superscription");

                    b.Property<int>("TypeOfAddress");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("VMRepresentacao.Domain.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("AddressId");

                    b.Property<DateTime>("DateRegister");

                    b.Property<string>("Name");

                    b.Property<int>("TypeOfSubsidiary");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Company");
                });

            modelBuilder.Entity("VMRepresentacao.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<DateTime>("DateRegister");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("VMRepresentacao.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<DateTime>("DateRegister");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("VMRepresentacao.Domain.Entities.Address", b =>
                {
                    b.OwnsOne("VMRepresentacao.Domain.ValueObjects.ZipCode", "ZipCode", b1 =>
                        {
                            b1.Property<int?>("AddressId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Number")
                                .HasColumnName("ZipCode")
                                .HasMaxLength(8);

                            b1.ToTable("Address");

                            b1.HasOne("VMRepresentacao.Domain.Entities.Address")
                                .WithOne("ZipCode")
                                .HasForeignKey("VMRepresentacao.Domain.ValueObjects.ZipCode", "AddressId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("VMRepresentacao.Domain.Entities.Company", b =>
                {
                    b.HasOne("VMRepresentacao.Domain.Entities.Address", "Address")
                        .WithOne("Company")
                        .HasForeignKey("VMRepresentacao.Domain.Entities.Company", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("VMRepresentacao.Domain.ValueObjects.CNPJ", "CNPJ", b1 =>
                        {
                            b1.Property<int>("CompanyId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Number")
                                .HasColumnName("CNPJ")
                                .HasMaxLength(14);

                            b1.ToTable("Company");

                            b1.HasOne("VMRepresentacao.Domain.Entities.Company")
                                .WithOne("CNPJ")
                                .HasForeignKey("VMRepresentacao.Domain.ValueObjects.CNPJ", "CompanyId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("VMRepresentacao.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("CompanyId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Address")
                                .HasColumnName("Email");

                            b1.ToTable("Company");

                            b1.HasOne("VMRepresentacao.Domain.Entities.Company")
                                .WithOne("Email")
                                .HasForeignKey("VMRepresentacao.Domain.ValueObjects.Email", "CompanyId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("VMRepresentacao.Domain.Entities.Customer", b =>
                {
                    b.OwnsOne("VMRepresentacao.Domain.ValueObjects.CPF", "CPF", b1 =>
                        {
                            b1.Property<int?>("CustomerId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Number")
                                .HasColumnName("CPF")
                                .HasMaxLength(11);

                            b1.ToTable("Customer");

                            b1.HasOne("VMRepresentacao.Domain.Entities.Customer")
                                .WithOne("CPF")
                                .HasForeignKey("VMRepresentacao.Domain.ValueObjects.CPF", "CustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("VMRepresentacao.Domain.ValueObjects.CNPJ", "CNPJ", b1 =>
                        {
                            b1.Property<int>("CustomerId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Number")
                                .HasColumnName("CNPJ")
                                .HasMaxLength(14);

                            b1.ToTable("Customer");

                            b1.HasOne("VMRepresentacao.Domain.Entities.Customer")
                                .WithOne("CNPJ")
                                .HasForeignKey("VMRepresentacao.Domain.ValueObjects.CNPJ", "CustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("VMRepresentacao.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("CustomerId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Address")
                                .HasColumnName("Email");

                            b1.ToTable("Customer");

                            b1.HasOne("VMRepresentacao.Domain.Entities.Customer")
                                .WithOne("Email")
                                .HasForeignKey("VMRepresentacao.Domain.ValueObjects.Email", "CustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
