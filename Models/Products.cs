using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Final_Project_Homekit_4.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        
        [Required]
        [Display(Name="Product")]
        public string ProductName { get; set; }


        [Range(1, 5000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name="Price")]
        public decimal ProductPrice { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Category { get; set; }

        public int BrandID { get; set; }    // FK

        public Brand Brand { get; set; }   // Nav. Each Product has one Brand
    }
}