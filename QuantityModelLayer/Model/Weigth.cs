namespace QuantityModelLayer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// This class contains thre code for weight method
    /// </summary>
    public class Weight
    {
        /// <summary>
        /// This is generating unique key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// This is for kilogram
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Kg { get; set; }

        /// <summary>
        /// This is  for gram
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Gram { get; set; }

        /// <summary>
        /// This is for tonne
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Ton { get; set; }

        /// <summary>
        /// This for results
        /// </summary>
        public decimal Result { get; set; }

        /// <summary>
        /// This is for option type
        /// </summary>
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string OptionType { get; set; }
    }
}