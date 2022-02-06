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

namespace WindowsFormsApp1.search
{
    public partial class search_f : Form
    {
        DataContext db = new DataContext();
        public search_f()
        {
            InitializeComponent();
            comboBox1.Text = "اختر نوع البحث";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "الاصناف")
                {
                    dataGridView1.DataSource = db.cats.Where(ww => ww.Name_cat.Contains(textBox1.Text) || ww.OtherDetails.Contains(textBox1.Text)).Select(ww => new
                    {
                        الاسم = ww.Name_cat,
                        التفاصيل = ww.OtherDetails
                    }).ToList();
                }
                else if (comboBox1.Text == "المنتجات")
                {
                    dataGridView1.DataSource = db.products.Include(ww => ww.cat).Include(ww => ww.Sub_Cat).Where(ww => ww.Name.Contains(textBox1.Text) || ww.cat.Name_cat.Contains(textBox1.Text) || ww.Sub_Cat.Name_Sub.Contains(textBox1.Text)).Select(ww => new
                    {
                        اسم_المنتج = ww.Name,
                        التفاصيل = ww.comment,
                        الصنف = ww.cat.Name_cat,
                        الفرع = ww.Sub_Cat.Name_Sub,
                        سعر_القطعة = ww.priceBuy_one
                    }).ToList();
                }
                else if (comboBox1.Text == "الفواتير")
                {
                    dataGridView1.DataSource = db.orderDetails.
                    Include(ww => ww.order).Where(x => x.product.Name.Contains(textBox1.Text)).Select(ww => new
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
                else if (comboBox1.Text == "العملاء")
                {
                    dataGridView1.DataSource = db.Clients.
                    Where(x => x.name.Contains(textBox1.Text) || x.address.Contains(textBox1.Text) || x.mail.Contains(textBox1.Text)).Select(ww => new
                    {
                        الاسم = ww.name,
                        الاميل = ww.mail,
                        العنوان = ww.address,
                        الهاتف = ww.phone,
                    }).ToList();
                }
                else if (comboBox1.Text == "الموظفيين")
                {
                    dataGridView1.DataSource = db.Users.
                    Where(x => x.name.Contains(textBox1.Text) || x.address.Contains(textBox1.Text) || x.mail.Contains(textBox1.Text)).Select(ww => new
                    {
                        الاسم = ww.name,
                        الاميل = ww.mail,
                        العنوان = ww.address,
                        الهاتف = ww.phone,
                        المرتب = ww.Salary,
                        الرقم_السري = ww.password
                    }).ToList();
                }
                else if (comboBox1.Text == "الموزعين")
                {
                    dataGridView1.DataSource = db.Distributions.
                    Where(x => x.Name.Contains(textBox1.Text) || x.Address.Contains(textBox1.Text) || x.Mail.Contains(textBox1.Text)).Select(ww => new
                    {
                        الاسم = ww.Name,
                        الاميل = ww.Mail,
                        العنوان = ww.Address,
                        الهاتف = ww.Phone,
                    }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
