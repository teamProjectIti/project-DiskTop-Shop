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

namespace WindowsFormsApp1.user
{
    public partial class Add_User : Form
    {
        DataContext db = new DataContext();

        public Add_User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( txt_name.Text != "" && txt_password.Text != "" && txt_phone.Text != "" && txt_salary.Text != "" && txt_address.Text != "" && txt_mail.Text != "")
            {
                // int selectedValue_usertype = Convert.ToInt32(txt_type.SelectedValue);

                List<Model.User> m = new List<Model.User>();
                m.Add(new Model.User()
                {

                    name = txt_name.Text,
                    password = txt_password.Text,
                    phone = txt_phone.Text,
                    address = txt_address.Text,
                    mail = txt_mail.Text,
                    Bithdate = txt_DOB.Value,
                    user_type = txt_type.Text,
                    // user_type_id  = selectedValue_usertype,
                    Updated_Date = txt_updated_date.Value,
                    Salary = double.Parse(txt_salary.Text),

                });


                foreach (var item in m.Take(1))
                {
                    db.Users.Add(item);
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

        void Data()
        {
            // txt_type.DataSource = db.users_types.ToList();
            //  txt_type.ValueMember = "id";
            // txt_type.DisplayMember = "type";
        }


        private void clear()
        {
             txt_name.Text = txt_password.Text = txt_phone.Text = txt_salary.Text = txt_address.Text = txt_mail.Text = "";
            txt_updated_date.Value = txt_DOB.Value = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            clear();
            Data();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
