using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.search
{
    public partial class lastBill24 : Form
    {
        DataContext db = new DataContext();
        public lastBill24()
        {

            InitializeComponent();
        }

        private void LastBill24_Load(object sender, EventArgs e)
        {

            DateTime day = DateTime.Now.AddDays(-1);

            //var a2 = db.person.Where(z => z.lastTime.Value <= d2).ToList();

            dataGridView1.DataSource = db.orderDetails.Include(ww => ww.order).Where(x => x.order.createTime >= day).Select(ww => new
            {
                رقم_الفاتورة = ww.order.ID_Order,
                اسم_المنتج = ww.product.Name,
                الكمية = ww.quentity,
                تاريخ_الفاتورة = ww.order.createTime,
                الخصم = ww.DisCount,
                اسم_البائع = ww.order.selasman,
                المبلغ = ww.totalAmount,

            }).ToList();
        }
    }
}