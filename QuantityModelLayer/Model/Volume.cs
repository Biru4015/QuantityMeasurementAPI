namespace QuantityModelLayer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// This class contains the code for all volume units convertor
    /// </summary>
    public class Volume
    {
        /// <summary>
        /// This is gererating unique key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        /// <summary>
        /// This is use for gallon convertor
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Gallon { get; set; }
        
        /// <summary>
        /// This is use for litres convertor
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Litre { get; set; }
        
        /// <summary>
        /// This is use for mililitres convertors
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Millilitre { get; set; }
        
        /// <summary>
        /// This is use results
        /// </summary>
        public decimal Result { get; set; }
        
        /// <summary>
        /// This  method is for option type
        /// </summary>
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string OptionType { get; set; }
    }
}