using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
     public class cat
    {
        [Key]
        public int ID_CAt { get; set; }
        public string Name_cat { get; set; }
        public string des { get; set; }
        public string OtherDetails { get; set; }

        public virtual ICollection<product> product { get; set; }
        = new HashSet<product>();
        public virtual ICollection<Sub_Cat> Sub_Cat { get; set; }
      = new HashSet<Sub_Cat>();
    }
}
