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

namespace WindowsFormsApp1.Form_table
{
    public partial class delete_all_cat_form : Form
    {
        DataContext db = new DataContext();
        public delete_all_cat_form()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var a = db.cats.Max(m => m.ID_CAt);
            if (a != 0)
            {
                var list = db.cats.Where(c => c.ID_CAt <= a).ToList();
                db.cats.RemoveRange(list);
                db.SaveChanges();
                dataGridView1.DataSource = db.cats.ToList();
                MessageBox.Show("تم عملية حذف جميع العناصر بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            else
            {
                MessageBox.Show("عفوا القائمة فارغة", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
        }
        private void Delete_all_cat_form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.cats.ToList();
        }
    }
}
