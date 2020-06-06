namespace QuantityMeasurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// This class contains the code for tempreture units.
    /// </summary>
    public class TempretureUnit
    {
        private double fahrenhiet;
        private double celcius;

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
    }
}