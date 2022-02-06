using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class Sub_Cat
    {
        [Key]
        public int ID_sub { get; set; }

        public String Name_Sub { get; set; }
        public String Desc { get; set; }
        public String Other_Details { get; set; }
        [ForeignKey("cat")]
        public int ID_CAt { get; set; }
        public virtual cat cat { get; set; }
        public virtual ICollection<product> product { get; set; }
       = new HashSet<product>();

    }
}
