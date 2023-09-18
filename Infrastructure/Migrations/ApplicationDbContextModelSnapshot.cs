﻿// <auto-generated />
using System;
using Infrastructure.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("DBCadDev")
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.AuthEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Auth", "DBCadDev");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c5d9f1d-1e7c-4455-a72e-7c8d4c52c680"),
                            Active = true,
                            CreatedBy = "6ef082bf-18d1-4468-969c-d8696e8bd6e7",
                            CreatedDate = new DateTime(2023, 9, 18, 11, 1, 12, 885, DateTimeKind.Local).AddTicks(3294),
                            Login = "llanfredi",
                            Nome = "Leandro Lanfredi",
                            Senha = "9N1RJ4v/JxP6S23Lg8STzA=="
                        });
                });

            modelBuilder.Entity("Domain.Entities.DevEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdTipoDev")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoDev");

                    b.ToTable("Dev", "DBCadDev");
                });

            modelBuilder.Entity("Domain.Entities.TipoDevEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescTipoDev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TipoDev", "DBCadDev");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5d7cf4a1-9102-4333-902c-c230ab738fe2"),
                            Active = true,
                            CreatedBy = "e53dad50-326b-4e18-8665-0026d69b8cb3",
                            CreatedDate = new DateTime(2023, 9, 18, 11, 1, 12, 839, DateTimeKind.Local).AddTicks(5431),
                            DescTipoDev = "Estágiário"
                        },
                        new
                        {
                            Id = new Guid("67c79c71-b703-4af2-8998-a48f4e94645d"),
                            Active = true,
                            CreatedBy = "72e589f8-a7e8-4180-a25f-6b0dfde2ce69",
                            CreatedDate = new DateTime(2023, 9, 18, 11, 1, 12, 839, DateTimeKind.Local).AddTicks(5476),
                            DescTipoDev = "Júnior"
                        },
                        new
                        {
                            Id = new Guid("19e122fd-d0a3-4ff2-bc27-f947abf20bec"),
                            Active = true,
                            CreatedBy = "a3330d55-47c8-424c-b569-156db813c195",
                            CreatedDate = new DateTime(2023, 9, 18, 11, 1, 12, 839, DateTimeKind.Local).AddTicks(5485),
                            DescTipoDev = "Pleno"
                        },
                        new
                        {
                            Id = new Guid("9ffece72-087e-4742-830a-0bc84ba9c318"),
                            Active = true,
                            CreatedBy = "3d4039a4-31bc-4d26-9033-d0d241bc9a34",
                            CreatedDate = new DateTime(2023, 9, 18, 11, 1, 12, 839, DateTimeKind.Local).AddTicks(5511),
                            DescTipoDev = "Sênior"
                        },
                        new
                        {
                            Id = new Guid("8f06da26-929a-409a-b964-9679ba2be79b"),
                            Active = true,
                            CreatedBy = "98306590-41a8-4c30-94a8-5c210435ffb6",
                            CreatedDate = new DateTime(2023, 9, 18, 11, 1, 12, 839, DateTimeKind.Local).AddTicks(5519),
                            DescTipoDev = "Especialista"
                        });
                });

            modelBuilder.Entity("Domain.Entities.DevEntity", b =>
                {
                    b.HasOne("Domain.Entities.TipoDevEntity", "TipoDev")
                        .WithMany()
                        .HasForeignKey("IdTipoDev")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoDev");
                });
#pragma warning restore 612, 618
        }
    }
}
