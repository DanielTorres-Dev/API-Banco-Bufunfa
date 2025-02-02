﻿// <auto-generated />
using APIBancoBufunfa.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIBancoBufunfa.Migrations
{
    [DbContext(typeof(ContaContext))]
    partial class ContaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("APIBancoBufunfa.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Saldo")
                        .HasColumnType("double");

                    b.Property<char>("Tipo")
                        .HasColumnType("int");

                    b.Property<string>("Titular")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contas");
                });
#pragma warning restore 612, 618
        }
    }
}
