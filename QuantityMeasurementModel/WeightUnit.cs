namespace QuantityMeasurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// This class contains the code of Weight units.
    /// </summary>
    public class WeightUnit
    {
        private double kilogram;
        private double gram;
        private double tonne;

        [Key]
        public int Id
        {
            get; set;
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Kilogram
        {
            get
            {
                return this.kilogram;
            }
            set
            {
                this.kilogram = value;
            }
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Gram
        {
            get
            {
                return this.gram;
            }
            set
            {
                this.gram = value;
            }
        }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Tonne
        {
            get
            {
                return this.tonne;
            }
            set
            {
                this.tonne = value;
            }
        }
        public string WeightOptions { get; set; }
    }
}