using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCartStart.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Range(0, 10000)]
        public short Quantity { get; set; }

    }
}