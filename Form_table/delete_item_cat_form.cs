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
    public partial class delete_item_cat_form : Form
    {
        DataContext db = new DataContext();
        public delete_item_cat_form()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var item = db.cats.Find(cat_id);
                db.cats.Remove(item);
                db.SaveChanges();
                dataGridView1.DataSource = db.cats.ToList();
                MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception)
            {
                MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void Delete_item_cat_form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.cats.ToList();
        }
        int cat_id;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cat_id =int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
