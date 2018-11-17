using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APMPrducts
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
        public string ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal StarRating { get; set; }
        public string ImageUrl { get; set; }
    }
}
