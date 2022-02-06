using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class Depature
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int id_user { get; set; }
        public virtual User User { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime FinshedDate { get; set; }
        public string State { get; set; }
        public string Others { get; set; }

    }
}
