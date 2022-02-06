using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Form_table
{
    public partial class Edit_item : Form
    {
        DataContext db = new DataContext();

        public Edit_item()
        {
            InitializeComponent();
        }

        private void Edit_item_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.cats.ToList();
        }

        int CAt_ID;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CAt_ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                cat cat_Item = (from cl in db.cats
                                  where cl.ID_CAt == CAt_ID
                                  select cl).FirstOrDefault();
                cat_Item.Name_cat = textBox1.Text;
                cat_Item.des = textBox2.Text;
                cat_Item.OtherDetails = textBox3.Text;
                db.Entry(cat_Item).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("تم تعديل البيانات بنجاح ", "رسالة تنفيذ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                dataGridView1.DataSource = db.cats.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("عفوا حدث خطاء في تعديل البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }
    }
}
