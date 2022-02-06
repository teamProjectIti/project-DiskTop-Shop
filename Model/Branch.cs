using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class Branch
    {

        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public int client_id { get; set; }  //foregin key

        [ForeignKey("client_id")]
        public virtual Client clients { get; set; }




    }


}
