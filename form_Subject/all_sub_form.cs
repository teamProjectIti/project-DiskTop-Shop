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

namespace WindowsFormsApp1.form_Subject
{
    public partial class all_sub_form : Form
    {
        DataContext db = new DataContext();
        public all_sub_form()
        {
            InitializeComponent();
        }
        private void All_sub_form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Sub_Cat.Select(x => new
            {
                الرقم = x.ID_CAt,
                الاسم = x.Name_Sub,
                الاسم_الفرعي = x.cat.Name_cat,
                الوصف = x.Desc
            }).ToList();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Sub_Cat.Where(x => x.Name_Sub.Contains(tx_search.Text)
           || x.Other_Details.Contains(tx_search.Text) ||
           x.Desc.Contains(tx_search.Text)).AsQueryable().ToList();

        }
    }
}
