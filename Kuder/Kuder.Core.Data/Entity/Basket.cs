using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuder.Core.Data.Entity
{
    public class Basket : EntityBase
    {
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public KuderUser KuderUser { get; set; }
    }

    public class BasketProduct : EntityBase
    {
        public int BasketID { get; set; }
        [ForeignKey("BasketID")]
        public Basket Basket { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
