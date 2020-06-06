namespace QuantityMeasurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// This class contains the code of volume units.
    /// </summary>
    public class VolumeUnit
    {
        private double litre;
        private double gallon;
        private double milimeter;

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
    }
}