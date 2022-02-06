using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class orderDetails
    {
        [Key]
        public int orderDetails_ID { get; set; }
        public int ID_Order { get; set; }
        [ForeignKey("ID_Order")]

        public virtual Order order { get; set; }
        [ForeignKey("product")]
        public int ID_pro { get; set; }
        public virtual product product { get; set; }
        public double totalPrice { get; set; }
        public double amount { get; set; }
        public double DisCount { get; set; }
        public double quentity { get; set; }
        public double totalAmount { get; set; }
        //public double totalAmount(peice* amount) { get; set; }
    }
}
