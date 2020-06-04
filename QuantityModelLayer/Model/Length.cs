namespace QuantityModelLayer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// This class contains the code of Length unit
    /// </summary>
    public class Length
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// This is feet method
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Feet { get; set; }
        
        /// <summary>
        /// This is inch method
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Inch { get; set; }
        
        /// <summary>
        /// This is yard method
        /// </summary>
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Yard { get; set; }
        
        /// <summary>
        /// This is result
        /// </summary>
        public decimal Result { get; set; }
        
        /// <summary>
        /// This is  for option type method
        /// </summary>
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string OptionType { get; set; }
    }
}
