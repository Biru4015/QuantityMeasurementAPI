using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuantityMeasurementModel
{
    public class VolumeUnit
    {
        public double litre;
        public double gallon;
        public double milimeter;

        [Key]
        public int Id
        {
            get; set;
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Litre
        {
            get
            {
                return this.litre;
            }
            set
            {
                this.litre = value;
            }
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Gallon
        {
            get
            {
                return this.gallon;
            }
            set
            {
                this.gallon = value;
            }
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Mililitre
        {
            get
            {
                return this.milimeter;
            }
            set
            {
                this.milimeter = value;
            }
        }
        public string OptionType { get; set; }
    }
}
