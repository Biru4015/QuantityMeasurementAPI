using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuantityMeasurementModel
{
    public class LengthUnit
    {

        private double feet;
        private double inch;
        private double centimeter;
        private double yard;

        [Key]
        public int Id
        {
            get; set;
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Feet
        {
            get
            {
                return this.feet;
            }
            set
            {
                this.feet = value;
            }
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Inch
        {
            get
            {
                return this.inch;
            }
            set
            {
                this.inch = value;
            }
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Centimeter
        {
            get
            {
                return this.centimeter;
            }
            set
            {
                this.centimeter = value;
            }
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Yard
        {
            get
            {
                return this.yard;
            }
            set
            {
                this.yard = value;
            }
        }
        public string OptionType { get; set; }
    }
}
