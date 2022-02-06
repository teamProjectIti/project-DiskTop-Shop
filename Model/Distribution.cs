﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public  class Distribution
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }

        public int User_ID { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<store> Store { get; set; }
    }
}
