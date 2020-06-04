using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using QuantityModelLayer.Model;

namespace QuantityModelLayer.Model
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {

        }

        /// <summary>
        /// Parameterized Constructor 
        /// </summary>
        /// <param name="options"></param>
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        /// <summary>
        ///  Navigation Properties Of Model classes
        /// </summary>
        public virtual DbSet<Length> Unit { get; set; }
        public virtual DbSet<Volume> Volume { get; set; }
        public virtual DbSet<Weight> Weight { get; set; }
        public virtual DbSet<Temperature> Temperature { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////Length Builder
            modelBuilder.Entity<Length>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Feet)
                 .HasColumnName("FEET")
                 .IsUnicode(false);

                entity.Property(e => e.Inch)
                .HasColumnName("INCH")
                .IsUnicode(false);

                entity.Property(e => e.Yard)
                .HasColumnName("YARD")
                .IsUnicode(false);

                entity.Property(e => e.Result)
                 .HasColumnName("RESULT")
                 .IsUnicode(false);

                entity.Property(e => e.OptionType)
                .HasColumnName("OPTIONTYPE")
                 .IsUnicode(false);

            });

            ////Volume builder
            modelBuilder.Entity<Volume>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gallon)
                 .HasColumnName("GALLON")
                 .IsUnicode(false);

                entity.Property(e => e.Litre)
                .HasColumnName("LITRE")
                .IsUnicode(false);

                entity.Property(e => e.Millilitre)
                .HasColumnName("MILLILITRE")
                .IsUnicode(false);

                entity.Property(e => e.Result)
                 .HasColumnName("RESULT")
                 .IsUnicode(false);

                entity.Property(e => e.OptionType)
                .HasColumnName("OPTIONTYPE")
                 .IsUnicode(false);

            });

            //// Weigths builder
            modelBuilder.Entity<Weight>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kg)
                 .HasColumnName("KG")
                 .IsUnicode(false);

                entity.Property(e => e.Gram)
                .HasColumnName("GRAM")
                .IsUnicode(false);

                entity.Property(e => e.Ton)
                .HasColumnName("TON")
                .IsUnicode(false);

                entity.Property(e => e.Result)
                 .HasColumnName("RESULT")
                 .IsUnicode(false);

                entity.Property(e => e.OptionType)
                .HasColumnName("OPTIONTYPE")
                 .IsUnicode(false);

            });

            //// Temperature builder
            modelBuilder.Entity<Temperature>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Celsius)
                 .HasColumnName("CELSIUS")
                 .IsUnicode(false);

                entity.Property(e => e.Fahrenheit)
                .HasColumnName("FAHRENHEIT")
                .IsUnicode(false);

                entity.Property(e => e.Result)
                 .HasColumnName("RESULT")
                 .IsUnicode(false);

                entity.Property(e => e.OptionType)
                .HasColumnName("OPTIONTYPE")
                 .IsUnicode(false);

            });
        }
    }
}
