using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Data
{
   public class DataContext:DbContext
    {
        public DataContext():base("name=default")
        {

        }

        public virtual DbSet<orderDetails> orderDetails { get; set; }
        public virtual DbSet<Order> Order { get; set; }//
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<cat> cats { get; set; }
        public virtual DbSet<Sub_Cat> Sub_Cat { get; set; }
        public virtual DbSet<Branch> Branchs { get; set; }
        public virtual DbSet<Company> Companys { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Depature> Depatures { get; set; }//
        public virtual DbSet<Distribution> Distributions { get; set; }//
        public virtual DbSet<store> Stores { get; set; }//
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Offers> Offers { get; set; }//

    }
}
