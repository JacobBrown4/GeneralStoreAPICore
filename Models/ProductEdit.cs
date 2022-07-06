using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneralStoreAPI.Models
{
    public class ProductEdit
    {
        public string Name { get; set; } = null!;
        public int QuantityInStock { get; set; }
        public double Price { get; set; }
    }
}