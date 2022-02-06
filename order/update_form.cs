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
using System.Data.Entity;

namespace WindowsFormsApp1.order
{
    public partial class update_form : Form
    {
        DataContext db = new DataContext();
        public update_form()
        {
            InitializeComponent();
            data();
        }
        void data()
        {
            dataGridView1.DataSource = db.orderDetails.Include(ww => ww.order).Include(ww => ww.product).Select(ww => new
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
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_form_Load(object sender, EventArgs e)
        {
            data();
        }
       
        void Search_id_order()
        {
            int a = Convert.ToInt32(Tx_Search.Text);
            //try
            //{
                var aa = db.orderDetails.Include(ww=>ww.order).Where(ww=>ww.ID_Order== a).First();
                if (aa.ID_Order != 0)
                {
                    dataGridView1.DataSource = db.orderDetails.Include(ww => ww.ID_Order).Include(ww=>ww.product).Where(r => r.order.ID_Order == a).Select(ww => new
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
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("تاكد من رقم الفاتورة","رسالة تنبية",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
            //}
        }
        void Search_Name_product()
        {
            dataGridView1.DataSource = db.orderDetails.Include(ww => ww.order).Where(x => x.product.Name.Contains(Tx_Search.Text)).Select(ww => new
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
        private void Button2_Click(object sender, EventArgs e)
        {
            Search_id_order();
        }

        private void Tx_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            Search_id_order();

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Search_Name_product();
        }

        private void TX_search2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Name_product();

            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int id_com = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            //brush_ID = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            //textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //comboBox1.Text = "حدد نوع الصنف";
            //tx_pro.Text=

        }

        private void Tx_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
