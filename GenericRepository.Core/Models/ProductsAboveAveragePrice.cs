using System;
using System.Collections.Generic;

#nullable disable

namespace GenericRepository.Core.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
