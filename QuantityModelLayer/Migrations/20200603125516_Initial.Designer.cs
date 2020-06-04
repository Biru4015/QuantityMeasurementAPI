﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuantityModelLayer.Model;

namespace QuantityModelLayer.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20200603125516_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuantityModelLayer.Model.Temperature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Celsius")
                        .HasColumnName("CELSIUS")
                        .IsUnicode(false);

                    b.Property<decimal>("Fahrenheit")
                        .HasColumnName("FAHRENHEIT")
                        .IsUnicode(false);

                    b.Property<string>("OptionType")
                        .HasColumnName("OPTIONTYPE")
                        .IsUnicode(false);

                    b.Property<decimal>("Result")
                        .HasColumnName("RESULT")
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Temperature");
                });

            modelBuilder.Entity("QuantityModelLayer.Model.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Feet")
                        .HasColumnName("FEET")
                        .IsUnicode(false);

                    b.Property<decimal>("Inch")
                        .HasColumnName("INCH")
                        .IsUnicode(false);

                    b.Property<string>("OptionType")
                        .HasColumnName("OPTIONTYPE")
                        .IsUnicode(false);

                    b.Property<decimal>("Result")
                        .HasColumnName("RESULT")
                        .IsUnicode(false);

                    b.Property<decimal>("Yard")
                        .HasColumnName("YARD")
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("QuantityModelLayer.Model.Volume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Gallon")
                        .HasColumnName("GALLON")
                        .IsUnicode(false);

                    b.Property<decimal>("Litre")
                        .HasColumnName("LITRE")
                        .IsUnicode(false);

                    b.Property<decimal>("Millilitre")
                        .HasColumnName("MILLILITRE")
                        .IsUnicode(false);

                    b.Property<string>("OptionType")
                        .HasColumnName("OPTIONTYPE")
                        .IsUnicode(false);

                    b.Property<decimal>("Result")
                        .HasColumnName("RESULT")
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Volume");
                });

            modelBuilder.Entity("QuantityModelLayer.Model.Weight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Gram")
                        .HasColumnName("GRAM")
                        .IsUnicode(false);

                    b.Property<decimal>("Kg")
                        .HasColumnName("KG")
                        .IsUnicode(false);

                    b.Property<string>("OptionType")
                        .HasColumnName("OPTIONTYPE")
                        .IsUnicode(false);

                    b.Property<decimal>("Result")
                        .HasColumnName("RESULT")
                        .IsUnicode(false);

                    b.Property<decimal>("Ton")
                        .HasColumnName("TON")
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Weight");
                });
#pragma warning restore 612, 618
        }
    }
}
