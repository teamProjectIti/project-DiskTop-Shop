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

namespace WindowsFormsApp1.Store
{
    public partial class Store_F : Form
    {
        DataContext context = new DataContext();

        public Store_F()
        {
            InitializeComponent(); Data();
            combox();
        }
        void Data()
        {
            dataGridView1.DataSource = context.Stores
                            .Select(x => new
                            {
                                الرقم = x.Id,
                                اسم_المخزن = x.Name,
                                العنوان = x.Address,
                                اسم_الشركه = x.Company.name,
                                اسم_الموزع = x.Distribution.Name,
                                التاريخ = x.UpdateDate,
                                الموظف = x.User.name,
                            }).ToList();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            store _store = new store()
            {
                Name = textName.Text,
                Address = textAddress.Text,
                CompanyId = Convert.ToInt32(comboBoxCompany.SelectedValue),
                UserId = Convert.ToInt32(comboBoxUser.SelectedValue),
                UpdateDate = dateTimePicker1.Value,
                id_Distrubation = Convert.ToInt32(comboBox_distrubtion.SelectedValue)
            };
            context.Stores.Add(_store);
            context.SaveChanges();
            MessageBox.Show("تم حفظ البيانات بنجاح");
            Data();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBoxUser.Text != "" && comboBox_distrubtion.Text != "" && comboBoxCompany.Text != "")
            {
                try
                {
                    store brunch_Item = (from cl in context.Stores
                                         where cl.Id == brush_ID
                                         select cl).FirstOrDefault();
                    brunch_Item.Name = txtName.Text;
                    brunch_Item.Address = txtAddress.Text;
                    brunch_Item.UpdateDate = dateTimePicker1.Value;
                    brunch_Item.CompanyId = Convert.ToInt32(comboBoxCompany.SelectedValue);
                    brunch_Item.UserId = Convert.ToInt32(comboBoxUser.SelectedValue);
                    brunch_Item.id_Distrubation = Convert.ToInt32(comboBox_distrubtion.SelectedValue);

                    context.Entry(brunch_Item).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("تم تعديل البيانات بنجاح ", "رسالة تنفيذ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    clear();
                    combox();
                    Data();
                }
                catch (Exception)
                {
                    MessageBox.Show("عفوا حدث خطاء في تعديل البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("يجب تحديد نوع الصنف التي تنتمي لها", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                combox();
                Data();
                clear();

            }

        }
        void combox()
        {
            comboBoxCompany.DataSource = context.Companys.ToList();
            comboBoxCompany.ValueMember = "id";
            comboBoxCompany.DisplayMember = "name";




            comboBoxUser.DataSource = context.Users.ToList();
            comboBoxUser.ValueMember = "id_user";
            comboBoxUser.DisplayMember = "name";


            comboBox_distrubtion.DataSource = context.Distributions.ToList();
            comboBox_distrubtion.ValueMember = "Id";
            comboBox_distrubtion.DisplayMember = "Name";
        }
        int brush_ID;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            brush_ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxCompany.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox_distrubtion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            comboBoxUser.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        void clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            comboBoxCompany.SelectedIndex = 0;
            comboBox_distrubtion.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            comboBoxUser.SelectedIndex = 0;

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد حذف هذا العنصر", "قائمة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    var item = context.Stores.Find(brush_ID);
                    context.Stores.Remove(item);
                    context.SaveChanges();
                    Data();
                    clear();
                    combox();
                    MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                catch (Exception)
                {
                    MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            clear();
            txtName.Text = "الاسم";
            txtAddress.Text = "العنوان";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IconPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
