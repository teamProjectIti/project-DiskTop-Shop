using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Order { get; set; }
        public DateTime createTime { get; set; }
        public DateTime Update_Time { get; set; }
        public string descripation { get; set; }
        public string selasman { get; set; }
        public int id_client { get; set; }
        [ForeignKey("id_client")]

        public virtual Client Client { get; set; }

    }
}
