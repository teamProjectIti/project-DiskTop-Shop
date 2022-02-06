using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.distrbution
{
    public partial class FrmDistribution : Form
    {
        DataContext context = new DataContext();
        private Distribution _distribution;
        public FrmDistribution()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtAddress.Text = txtMail.Text = txtPhone.Text = txtName.Text;
        }
        void data()
        {
            dataGridView1.DataSource = context.Distributions
            .Select(x => new
            {
                الرقم = x.Id,
                اسم_الموزع = x.Name,
                العنوان = x.Address,
                الاميل = x.Mail,
                رقم_الهاتف = x.Phone
            }).ToList();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _distribution = new Distribution()
            {
                Address = txtAddress.Text,
                Mail = txtMail.Text,
                Phone = txtPhone.Text,
                Name = txtName.Text,

            };

            context.Distributions.AddOrUpdate(_distribution);
            context.SaveChanges();
            MessageBox.Show("تم حفظ البيانات بنجاح");
            data();
            clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                try
                {
                    Distribution brunch_Item = (from cl in context.Distributions
                                                where cl.Id == brush_ID
                                                select cl).FirstOrDefault();
                    brunch_Item.Name = txtName.Text;
                    brunch_Item.Phone = txtPhone.Text;
                    brunch_Item.Mail = txtMail.Text;
                    brunch_Item.Phone = txtPhone.Text;
                    context.Entry(brunch_Item).State = EntityState.Modified;
                    context.SaveChanges();

                    MessageBox.Show("تم تعديل البيانات بنجاح ", "رسالة تنفيذ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    clear();
                    data();
                }
                catch (Exception)
                {
                    MessageBox.Show("عفوا حدث خطاء في تعديل البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("يجب تحديد نوع الصنف التي تنتمي لها", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                data();
                clear();

            }
        }
        int brush_ID;
       
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد حذف هذا العنصر", "قائمة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    var item = context.Distributions.Find(brush_ID);
                    context.Distributions.Remove(item);
                    context.SaveChanges();
                    data();
                    clear();
                    MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                catch (Exception)
                {
                    MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            brush_ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
