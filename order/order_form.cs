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
using System.Data.Entity;
namespace WindowsFormsApp1.order
{
    public partial class order_form : Form
    {
        DataContext db = new DataContext();
        public order_form()
        {
            InitializeComponent();
            CreateDataTabile();

        }
        DataTable dt = new DataTable();
        void CreateDataTabile()
        {
            dt.Columns.Add("رقم الفاتورة");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("نسبة الخصم %");
            dt.Columns.Add("المبلغ الاجمالي");

            dataGridView1.DataSource = dt;
        }
        private void Order_form_Load(object sender, EventArgs e)
        {
            tx_name_salesman.Text = Program.salesMan;
            btn_save.Enabled = false;
            Add_compBox();
        }
        void Add_compBox()
        {

            tx_pro.ValueMember = "ID_pro";
            tx_pro.DisplayMember = "Name";
            tx_pro.DataSource = db.products.Include(WW => WW.cat).Include(WW => WW.Sub_Cat).ToList();



            comboBoxClient.ValueMember = "id_client";
            comboBoxClient.DisplayMember = "name";
            comboBoxClient.DataSource = db.Clients.ToList();



        }
        int a;
        private void Button1_Click(object sender, EventArgs e)
        {
            var aa = db.Order.Select(ww => ww.ID_Order).Count();

            if (aa == 0)
            {
                a = 1;
            }
            else
            {
                a = db.Order.Max(ww => ww.ID_Order) + 1;
            }
            tx_number_bill.Text = a.ToString();
            tx_name_salesman.Text = Program.salesMan;
            new_buy_btn.Enabled = false;
            btn_save.Enabled = true;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {


            #region Save_order
            Order o = new Order();

            o.ID_Order = Convert.ToInt32(tx_number_bill.Text.ToString());
            o.descripation = tx_describtion.Text;
            o.selasman = tx_name_salesman.Text;
            o.createTime = DateTime.Now;
            o.Update_Time = DateTime.Now;
            o.id_client = Convert.ToInt32(comboBoxClient.SelectedValue);
            db.Order.Add(o);
            



            #endregion

            #region Save_product
            DataRow r = dt.NewRow();
            int selectedValue_pro = Convert.ToInt32(tx_pro.SelectedValue);
            var a = db.products.Where(ww => ww.ID_pro == selectedValue_pro).First();

            List<orderDetails> od = new List<orderDetails>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                od.Add(new orderDetails
                {
                    ID_pro = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                    totalPrice = Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[2].Value),
                    quentity = Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[3].Value),
                    amount = Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[4].Value),
                    DisCount = Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[5].Value),
                    totalAmount = Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[6].Value),
                    ID_Order = Convert.ToInt32(tx_number_bill.Text)
                });
            }
            foreach (var item in od)
            {
                db.orderDetails.Add(item);
                db.SaveChanges();

                product pro = db.products.Find(Convert.ToInt32(tx_pro.SelectedValue));
                item.product.Qount = item.product.Qount - item.quentity;
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
            tx_number_bill.Text = tx_describtion.Text = "";
            #endregion

            MessageBox.Show("تمت عملية التسحيل الفاتورة بنجاح", "رسالة  ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            clearBoxes();



            new_buy_btn.Enabled = true;
            btn_save.Enabled = false;
            clearBoxes();

        }

        private void Order_form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        void calc()
        {
            if (tx_quentity.Text != string.Empty && tx_descound.Text != string.Empty && tx_sum.Text != string.Empty)
            {
                double discound = Convert.ToDouble(tx_descound.Text);
                double summ = Convert.ToDouble(tx_sum.Text);
                double totalAmount = summ - (summ * (discound / 100));
                tx_all_sum.Text = totalAmount.ToString();
            }

        }

        private void Tx_pro_KeyPress(object sender, KeyPressEventArgs e)
        {



            //if (selectedValue_pro != null)
            //{
            //    product product = db.products.FirstOrDefault(ww => ww.Id_cat == a2);
            //    tx_price.Text = product.priceBuy_one.ToString();
            //}

        }

        private void Tx_quentity_TextChanged(object sender, EventArgs e)
        {
            if (tx_quentity.Text != string.Empty && tx_quentity.Text != "")
            {
                tx_sum.Text = (Convert.ToDouble(tx_quentity.Text) * Convert.ToDouble(tx_price.Text)).ToString();
                //tx_descound.Focus();
            }
        }

        private void Tx_pro_SelectedIndexChanged(object sender, EventArgs e)
        {


            int selectedValue_pro = Convert.ToInt32(tx_pro.SelectedValue);
            var a = db.products.Where(ww => ww.ID_pro == selectedValue_pro).First();
            tx_price.Text = a.priceBuy_one.ToString();
            tx_quentity.Focus();

        }

        private void Tx_quentity_KeyUp(object sender, KeyEventArgs e)
        {
            calc();
        }

        private void Tx_descound_KeyUp(object sender, KeyEventArgs e)
        {
            calc();
        }
        void clearBoxes()
        {
            tx_all_sum.Text = tx_descound.Text = tx_price.Text = tx_quentity.Text = tx_sum.Text = "";
            Add_compBox();
        }
        private void Tx_descound_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRow r = dt.NewRow();
                int selectedValue_pro = Convert.ToInt32(tx_pro.SelectedValue);
                var a = db.products.Where(ww => ww.ID_pro == selectedValue_pro).First();

                product pro = db.products.Find(Convert.ToInt32(tx_pro.SelectedValue));


                if (pro.Qount < Convert.ToInt32(tx_quentity.Text))
                {
                    MessageBox.Show("عفوا الكمية المطلوبة اكبر من الكمية المخزنة = " + pro.Qount, "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == a.ID_pro.ToString())
                    {
                        MessageBox.Show("عفوا هذا المنتج موجود بالفعل", "رسالة تاكيد ", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        //Tx_descound_KeyDown(sender,e);
                        return;

                    }
                }
                try
                {
                    if (tx_quentity.Text != "")
                    {
                        r[0] = a.ID_pro.ToString();
                        r[1] = tx_pro.Text;
                        r[2] = tx_price.Text;
                        r[3] = tx_quentity.Text;
                        r[4] = tx_sum.Text;
                        r[5] = tx_descound.Text;
                        r[6] = tx_all_sum.Text;

                        dt.Rows.Add(r);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("عفواء حدث خطاء في ادخال البيانات","رسالة خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                }
                //clear all textbox
                clearBoxes();
                //calc all price product
                string all_price = (from DataGridViewRow row in dataGridView1.Rows
                                    where row.Cells[6].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
                tx_sum_all_prod.Text = all_price;
            }
        }
        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                tx_pro.DisplayMember = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tx_price.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tx_quentity.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                tx_sum.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                tx_descound.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                tx_all_sum.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                tx_quentity.Focus();
            }
            catch (Exception)
            {

                MessageBox.Show("عفوا حدث خطاء في ادخال البيانات", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }
        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //calc all price product
            string all_price = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[6].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            tx_sum_all_prod.Text = all_price;
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView1_DoubleClick(sender, e);
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();
        }

        private void Tx_name_salesman_TextChanged(object sender, EventArgs e)
        {

        }
        private void Tx_quentity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tx_descound.Focus();
            }
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tx_all_sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tx_descound_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tx_sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tx_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Tx_describtion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Tx_number_bill_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBoxClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int selectedValue_pro = Convert.ToInt32(comboBoxClient.SelectedValue);
                var a = db.Clients.Where(ww => ww.id_client == selectedValue_pro).First();
                tx_address.Text = a.address.ToString();
                tx_phone.Text = a.phone.ToString();
                tx_mail.Text = a.mail.ToString();
                tx_quentity.Focus();
            }
        }
    }
}
