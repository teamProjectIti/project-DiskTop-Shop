using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Form_product
{
    public partial class all_product : Form
    {
        DataContext db = new DataContext();

        public all_product()
        {
            InitializeComponent();
        }

        private void All_product_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.products.Select(x => new
            {
                الرقم = x.ID_pro,
                الاسم = x.Name,
                الاسم_الفرعي = x.cat.Name_cat,
                الاسم_الرئيسي = x.Sub_Cat.Name_Sub,
                الكمية=x.Qount,
                السعر=x.priceBuy_one,
                تاريخ_انتهاء_الصلاحية=x.Date_Experied,
                تاريخ_الانضام=x.Date_attach,
                تعليق=x.comment
            }).ToList();
        }
        private void Btn_search_Click(object sender, EventArgs e)
        {
         dataGridView1.DataSource = db.products.Where(x => x.Sub_Cat.Name_Sub.Contains(tx_search.Text)
         ||x.Name.Contains(tx_search.Text)||x.cat.Name_cat.Contains(tx_search.Text)||
         x.comment.Contains(tx_search.Text)).ToList();
        }
    }
}
