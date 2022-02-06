using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class expireDAta
    {
        [Key]
        public int ID_expire { get; set; }
        public bool check { get; set; }
        public DateTime date_expir_last_month { get; set; }

        [ForeignKey("product")]
        public int ID_pro { get; set; }
        public virtual product product { get; set; }
    }
}
