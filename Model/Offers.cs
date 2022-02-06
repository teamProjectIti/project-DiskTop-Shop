using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class Offers
    {
        [Key]
        public int Id { get; set; }
        public string CodeCopone { get; set; }
        public string Details { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        [ForeignKey("User")]
        public int id_user { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("product")]
        public int ID_pro { get; set; }
        public virtual product product  { get; set; }
    }
}
