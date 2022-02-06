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
    public partial class Search_User : Form
    {
        DataContext db = new DataContext();


        public Search_User()
        {
            InitializeComponent();
        }

        private void Search_User_Load(object sender, EventArgs e)
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
                // نوع_المستخدم = x.user_type.type
                نوع_المستخدم = x.user_type
            }).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Users.Where(x => x.name.Contains(name.Text)).Select(x => new
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
                // نوع_المستخدم = x.user_type.type
                نوع_المستخدم = x.user_type
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Users.Where(x => x.Salary.ToString().Contains(salary.Text)).Select(x => new
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
                // نوع_المستخدم = x.user_type.type
                نوع_المستخدم = x.user_type

            }).ToList();
        }
    }
}
