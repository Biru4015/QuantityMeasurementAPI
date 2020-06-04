namespace QuantityModelLayer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// This clas contains the code of Tempreture units 
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// Key generating
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// This is for celcius method
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Celsius { get; set; }
        
        /// <summary>
        /// This is  for fahrenhiet method
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Fahrenheit { get; set; }

        /// <summary>
        /// This is for results method
        /// </summary>
        public decimal Result { get; set; }

        /// <summary>
        /// This is for option type method
        /// </summary>
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string OptionType { get; set; }
    }
}
