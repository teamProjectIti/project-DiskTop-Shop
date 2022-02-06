using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class User
    {
        [Key]
        public int id_user { get; set; }
        public string name { get; set; }

        public string password { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public double Salary { get; set; }
        public string mail { get; set; }
        public DateTime Updated_Date { get; set; }
        public DateTime Bithdate { get; set; }
        public string permissions { get; set; }
        public string user_type { get; set; }


        public virtual ICollection<Depature> Depature { get; set; }
        = new HashSet<Depature>();
        public virtual ICollection<Offers> Offers { get; set; }
       = new HashSet<Offers>();
        public virtual ICollection<store> Store { get; set; }
      = new HashSet<store>();

    }
}
