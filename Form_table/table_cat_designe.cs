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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Form_table
{
    public partial class table_cat_designe : Form
    {
        DataContext db = new DataContext();
        public table_cat_designe()
        {
            InitializeComponent();
        }

        private void Table_cat_designe_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortDateString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<cat> c = new List<cat>();
            try
            {
                if (textBox1.Text != string.Empty)
                {
                    c.Add(new Model.cat
                    {
                        Name_cat = textBox1.Text,
                        des = textBox2.Text,
                        OtherDetails = textBox3.Text,
                    });
                    foreach (var item in c.Take(1))
                    {
                        db.cats.Add(item);
                        db.SaveChanges();
                    }
                    clear();
                    MessageBox.Show("تم عملية التسجيل بنجاح", "رسالة تاكيد نجاح التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                else
                {
                    MessageBox.Show("الرجاء التاكد من ادخال بيانات", "رسالة تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                }
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message, "رسالة تاكيد نجاح التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

        }
        void clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
