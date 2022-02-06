using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class product
    {
        [Key]
        public int ID_pro { get; set; }
        public string Name { get; set; }
        public double Qount { get; set; }
        public double priceBuy_one { get; set; }
        public double priceBuyOrgnal_all { get; set; }
        public double price_Sall_one { get; set; }
        public double price_Sall_all { get; set; }
        public double earn_Money { get; set; }
        public DateTime Date_attach { get; set; }
        public DateTime Date_Experied { get; set; }
        public string comment { get; set; }
        public byte[] Image { get; set; }
        [ForeignKey("cat")]
        public int Id_cat { get; set; }
        public virtual cat cat { get; set; }
        [ForeignKey("Sub_Cat")]
        public int ID_sub { get; set; }
        public virtual Sub_Cat Sub_Cat { get; set; }
        public virtual ICollection<orderDetails> orderDetails { get; set; }
        = new HashSet<orderDetails>();
        public virtual ICollection<expireDAta> expireDAta { get; set; }
               = new HashSet<expireDAta>();
        public virtual ICollection<Offers> Offers { get; set; }
     = new HashSet<Offers>();

    }
}
