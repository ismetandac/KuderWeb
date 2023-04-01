using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuder.Core.Data.Entity
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public bool IsActive { get; set; }
        public decimal Score { get; set; }
        public int StockCount { get; set; }
        public int MaxOrderCount { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }

    public class ProductImage : EntityBase
    {
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public string Path { get; set; }
        public bool IsActive { get; set; }
    }
}
