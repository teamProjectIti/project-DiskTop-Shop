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

namespace WindowsFormsApp1.company
{
    public partial class Add_Company : Form
    {

        DataContext db = new DataContext();

        public Add_Company()
        {
            InitializeComponent();
        }

        private void Add_Company_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
           txt_name.Text = txt_phone.Text = txt_address.Text = txt_mail.Text = txt_details.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( txt_name.Text != "" && txt_address.Text != "" && txt_phone.Text != "" && txt_mail.Text != "" && txt_details.Text != "")
            {

                List<Model.Company> m = new List<Model.Company>();
                m.Add(new Model.Company()
                {
                    name = txt_name.Text,
                    phone = txt_phone.Text,
                    address = txt_address.Text,
                    mail = txt_phone.Text,
                    other_details = txt_details.Text,

                });
                foreach (var item in m.Take(1))
                {
                    db.Companys.Add(item);
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

        private void txt_details_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
