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

namespace WindowsFormsApp1.user
{
    public partial class Update_Or_Delete : Form
    {

        DataContext db = new DataContext();

        public Update_Or_Delete()
        {
            InitializeComponent();
        }

        private void Update_Or_Delete_Load(object sender, EventArgs e)
        {

        }

        void Data()
        {
            dataGridView1.DataSource = db.Users.Select(x => new
            {
                رقم_المستخدم = x.id_user,
                اسم_المستخدم = x.name,
                الباسورد = x.password,
                رقم_التليفون = x.phone,
                الراتب = x.Salary,
                العنوان = x.address,
                الايميل = x.address,
                تاريخ_الميلاد = x.Bithdate,
                تاريخ_التعديل = x.Updated_Date,
                //   نوع_المستخدم=x.user_type.type
                نوع_المستخدم = x.user_type
            }).ToList();
        }
        int id;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txt_num.Text = id.ToString();

          //  txt_num.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_password.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_salary.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_address.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_mail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_dob.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_updated_date.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_type.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_password.Text != "" && txt_phone.Text != "" && txt_salary.Text != "" && txt_address.Text != "" && txt_mail.Text != "" && txt_dob.Text != "" && txt_updated_date.Text != "" && txt_type.Text != "")
            {

                // int selectedValue_type = Convert.ToInt32(txt_type.SelectedValue);

                try
                {
                    Model.User bra = (from b in db.Users
                                       where b.id_user == id
                                       select b).FirstOrDefault();

                    bra.name = txt_name.Text;
                    bra.password = txt_password.Text;
                    bra.phone = txt_phone.Text;
                    bra.Salary = double.Parse(txt_salary.Text);
                    bra.address = txt_address.Text;
                    bra.mail = txt_mail.Text;
                    bra.Bithdate = txt_dob.Value;
                    bra.Updated_Date = txt_updated_date.Value;

                    //var a = db.users_types.Where(x => x.type.Contains(txt_type.Text)).FirstOrDefault();
                    //bra.user_type_id = Convert.ToInt32(a.id);
                    bra.user_type = txt_type.Text;

                    db.Entry(bra).State = EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("تم تعديل البيانات بنجاح ", "رسالة تنفيذ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    clear();
                    Data();
                }
                catch (Exception)
                {
                    MessageBox.Show("واختيار صورةجديدة. عفوا حدث خطاء في تعديل البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("الرجاء التاكد من ادخال بيانات", "رسالة تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

        }

        private void clear()
        {
            txt_name.Text = txt_password.Text = txt_phone.Text = txt_address.Text = txt_salary.Text = txt_mail.Text = txt_type.Text = "";
            txt_dob.Value = txt_updated_date.Value = DateTime.Now;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var item = db.Users.Find(id);
                db.Users.Remove(item);
                MessageBox.Show("هل تريد بالفعل حذف هذا!", "رسالة مساعدة", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                db.SaveChanges();
                dataGridView1.DataSource = db.Users.ToList();
                MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception)
            {
                MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Data();
        }

      
    }
}
