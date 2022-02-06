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

namespace WindowsFormsApp1.company
{
    public partial class Update_Delete : Form
    {

        DataContext db = new DataContext();

        public Update_Delete()
        {
            InitializeComponent();
        }

        void Data()
        {
            dataGridView1.DataSource = db.Companys.Select(x => new
            {
                رقم_الشركة = x.id,
                اسم_الشركة = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                الايميل = x.mail,
                تفاصيل = x.other_details

            }).ToList();
        }




        private void Update_Delete_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Data();

        }
        int id;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txt_no.Text = id.ToString();

           // txt_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_addrees.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_mail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_details.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_no.Text != "" && txt_name.Text != "" && txt_phone.Text != "" && txt_addrees.Text != "" && txt_mail.Text != "" && txt_details.Text != "")
            {

                try
                {
                    Model.Company com = (from b in db.Companys
                                          where b.id == id
                                          select b).FirstOrDefault();
                    com.name = txt_name.Text;
                    com.phone = txt_phone.Text;
                    com.address = txt_addrees.Text;
                    com.mail = txt_mail.Text;
                    com.other_details = txt_details.Text;

                    db.Entry(com).State = EntityState.Modified;
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
            txt_no.Text = txt_name.Text = txt_phone.Text = txt_addrees.Text = txt_mail.Text = txt_details.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var item = db.Companys.Find(id);
                db.Companys.Remove(item);
                MessageBox.Show("هل تريد بالفعل حذف هذا!", "رسالة مساعدة", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                db.SaveChanges();
                dataGridView1.DataSource = db.Companys.ToList();
                MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception)
            {
                MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
