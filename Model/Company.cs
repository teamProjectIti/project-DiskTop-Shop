using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class Company
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string mail { get; set; }
        public string other_details { get; set; }

        public virtual ICollection<Offers> Offers { get; set; }
            = new HashSet<Offers>();
        public virtual ICollection<Payment> Payment { get; set; }
          = new HashSet<Payment>();
        public virtual ICollection<store> Store { get; set; }
         = new HashSet<store>();
    }
}
