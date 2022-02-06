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
    public partial class Search_Company : Form
    {
        DataContext db = new DataContext();

        public Search_Company()
        {
            InitializeComponent();
        }

        private void Search_Company_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Companys.Select(x => new
            {
                رقم_الشركة = x.id,
                اسم_الشركة = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                الايميل = x.mail,
                تفاصيل_اخري = x.other_details

            }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Companys.Where(x => x.name.Contains(name.Text)).Select(x => new
            {
                رقم_الشركة = x.id,
                اسم_الشركة = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                الايميل = x.mail,
                تفاصيل_اخري = x.other_details

            }).ToList();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Companys.Where(x => x.phone.Contains(phone.Text)).Select(x => new
            {
                رقم_الشركة = x.id,
                اسم_الشركة = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                الايميل = x.mail,
                تفاصيل_اخري = x.other_details

            }).ToList();
        }
    }
}
