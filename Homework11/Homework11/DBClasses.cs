using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    [Table("Orders")]
    public class DB_Order
    {
        [Key]
        public int Order_ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime OrderTime { get; set; }
        public List<DB_OrderItem> OrderItems { get; set; }
    }

    [Table("Items")]
    public class DB_OrderItem
    {
        [Key]
        public int ItemID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public DB_Order Order { get; set; }
    }
}
