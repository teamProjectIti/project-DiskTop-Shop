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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.order
{
    public partial class SetingBill : Form
    {
        DataContext db = new DataContext();
        public SetingBill()
        {
            InitializeComponent();
            data();
            all_sum();
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
            all_sum();

        }
        void all_sum()
        {
            string all_price = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[6].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            tx_all_sum_dv.Text = all_price;
        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = db.orderDetails.Include(ww => ww.order).Where(x => x.order.selasman.Contains(textBox1.Text)).Select(ww => new
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
            all_sum();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
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
                all_sum();

            }
            else if (radioButton2.Checked == true)
            {
                DateTime day = DateTime.Now.AddDays(-7);

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
                all_sum();

            }
            else if (radioButton3.Checked == true)
            {
                DateTime day = DateTime.Now.AddMonths(-1);

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
                all_sum();

            }
            else
            {
                data();
            }
        }

        private void Tx_pro_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = db.orderDetails.
                    Include(ww => ww.order).Where(x => x.product.Name.Contains(tx_pro_name.Text)).Select(ww => new
                {
                    رقم_الفاتورة = ww.order.ID_Order,
                    اسم_المنتج = ww.product.Name,
                    الكمية = ww.quentity,
                    تاريخ_الفاتورة = ww.order.createTime,
                    الخصم = ww.DisCount,
                    اسم_البائع = ww.order.selasman,
                    المبلغ = ww.totalAmount,

                }).ToList();
                all_sum();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            order_form f = new order_form();
            this.Hide();
            f.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            update_form f = new update_form();
            f.ShowDialog();
        }
        void Search_id_order()
        {
           
}
        private void Button3_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Tx_Search.Text);
            try
            {
                var aa = db.orderDetails.Include(ww => ww.order).Include(ww => ww.product).Where(ww => ww.ID_Order == a).First();
                if (aa.ID_Order != 0)
                {
                    dataGridView1.DataSource = db.orderDetails.Include(ww => ww.order).Include(ww=>ww.product).Where(ww => ww.ID_Order == a).Select(ww => new
                    {
                        رقم_الفاتورة = ww.order.ID_Order,
                        اسم_المنتج = ww.product.Name,
                        الكمية = ww.quentity,
                        تاريخ_الفاتورة = ww.order.createTime,
                        الخصم = ww.DisCount,
                        اسم_البائع = ww.order.selasman,
                        المبلغ = ww.totalAmount,
                    }).First();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("تاكد من رقم الفاتورة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void Tx_Search_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Tx_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Tx_Search_KeyUp(object sender, KeyEventArgs e)
        {

        }
        int id_pro;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_pro = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد حذف هذا العنصر", "قائمة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    if (id_pro != 0)
                    {
                        var a = db.orderDetails.Include(ww => ww.order).Where(ww => ww.ID_Order == id_pro).First();
                        db.orderDetails.Remove(a);
                        db.SaveChanges();

                        var item = db.Order.Find(id_pro);
                        db.Order.Remove(item);
                        db.SaveChanges();
                        MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        data();
                        all_sum();

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var list = db.orderDetails.ToList();
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    db.orderDetails.Remove(item);
                    db.SaveChanges();
                    data();
                    all_sum();

                    //MessageBox.Show("تم عملية حذف جميع العناصر بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("عفوا القائمة فارغة", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد حذف هذا العنصر", "قائمة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    if (id_pro != 0)
                    {
                        var a = db.orderDetails.Include(ww => ww.order).Where(ww => ww.ID_Order == id_pro).First();
                        db.orderDetails.Remove(a);
                        db.SaveChanges();

                        var item = db.Order.Find(id_pro);
                        db.Order.Remove(item);
                        db.SaveChanges();
                        MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        data();
                        all_sum();

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = db.orderDetails.ToList();
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    db.orderDetails.Remove(item);
                    db.SaveChanges();
                    data();
                    all_sum();

                    //MessageBox.Show("تم عملية حذف جميع العناصر بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("عفوا القائمة فارغة", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
