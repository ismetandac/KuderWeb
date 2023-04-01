using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuder.Core.Data.Entity
{
    public class Order : EntityBase
    {
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public KuderUser KuderUser { get; set; }
        public _OrderStatus OrderStatus { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public decimal TotalPrice { get; set; }
        public int BankID { get; set; }
        [ForeignKey("BankID")]
        public Bank Bank { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
    public enum _OrderStatus
    {
        Active = 0,
        Confirm = 1,
        Cargo = 2,
        Complated = 3

    }
    public class OrderProduct : EntityBase
    {
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
