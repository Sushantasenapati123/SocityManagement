using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bank.Domain.Product
{
    public class ProductEntity
    {
        [Key]
        public int CatId { get; set; }
        public string Catname { get; set; }
        public int SubcatId { get; set; }
        public string Subcatame { get; set; }
        public int ProductId { get; set; }
        public string Productname { get; set; }
        public decimal? Productrate { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductPhoto { get; set; }
        public DateTime saledate { get; set; }
        public int Slno { get; set; }
        public int? Quantity { get; set; }
        public decimal? amount { get; set; }

    }
}
