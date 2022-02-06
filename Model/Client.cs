using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class Client
    {
        internal int id;

        [Key]
        public int id_client { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string mail { get; set; }
        public byte[] image { get; set; }

        public string other_details { get; set; }

        public ICollection<Branch> branches { get; set; }
        public virtual ICollection<Order> Order { get; set; }

    }
}
