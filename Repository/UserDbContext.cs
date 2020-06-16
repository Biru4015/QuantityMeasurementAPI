using Microsoft.EntityFrameworkCore;
using QuantityMeasurementModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<LengthUnit> Lengths { get; set;}
        public DbSet<VolumeUnit> Volumes { get; set; }
        public DbSet<WeightUnit> Weights { get; set; }
        public DbSet<TempretureUnit> Tempretures { get; set; }
    }
}
