using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuantityMeasurementModel
{
    public class TempretureUnit
    {
        public double fahrenhiet;
        public double celcius;

        [Key]
        public int Id
        {
            get; set;
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Fahrenhiet
        {
            get
            {
                return this.fahrenhiet;
            }
            set
            {
                this.fahrenhiet = value;
            }
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Celcius
        {
            get
            {
                return this.celcius;
            }
            set
            {
                this.celcius = value;
            }
        }
        public string OptionType { get; set; }
    }
}
