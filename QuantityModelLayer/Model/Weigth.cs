using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuantityModelLayer.Model
{
    public class Weight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Kg { get; set; }
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Gram { get; set; }
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Ton { get; set; }
        public decimal Result { get; set; }
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string OptionType { get; set; }
    }
}
