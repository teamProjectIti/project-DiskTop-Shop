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
using WindowsFormsApp1.Form_product;

namespace WindowsFormsApp1
{
    public partial class ExpirdDate : Form
    {
        DataContext db = new DataContext();
        public ExpirdDate()
        {
            InitializeComponent();
            CreateDataTabile();
            sum();
        }
        DataTable dt = new DataTable();
        void CreateDataTabile()
        {
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("تاريخ انتهاء الصلاحية");
            dt.Columns.Add("تاريخ الضم للمحل");
            dt.Columns.Add("المكسب");
            dt.Columns.Add("الثمن المدفوع");

            dataGridView1.DataSource = dt;
        }
        void sum()
        {
            string all_price = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[5].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            textBox1.Text = all_price;
        }
        void sum2()
        {
            string all_price = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[6].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            textBox2.Text = all_price;
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            var a = db.products.ToList();
            foreach (var item in a)
            {
                var montt=DateTime.Now;
                var s = item.Date_Experied - montt;
                int dataa = (int)s.TotalDays;
                var r = dt.NewRow();

                if ( dataa < 30)
                {
                    r[0] = item.Name;
                    r[1] = item.priceBuy_one;
                    r[2] = item.Qount;
                    r[3] = item.Date_Experied;
                    r[4] = item.Date_attach;
                    r[5] = item.earn_Money;
                    r[6] = item.price_Sall_all;

                    dt.Rows.Add(r);
                    dataGridView1.DataSource = dt;
                }
            }
            sum();
            sum2();

        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox3.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void IconPictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_form f = new Edit_form();
            f.ShowDialog();
        }

        private void IconPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
