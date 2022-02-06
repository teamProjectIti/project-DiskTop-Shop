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

namespace WindowsFormsApp1.client
{
    public partial class Search_Client : Form
    {
        DataContext db = new DataContext();
        public Search_Client()
        {
            InitializeComponent();
        }

        private void Search_Client_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Clients.Select(x => new
            {
                رقم_العميل = x.id_client,
                اسم_العميل = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                الايميل = x.mail,
                بيانات_اخري = x.other_details

            }).ToList();
        }

        private void btn_Search1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Clients.Where(x => x.name.Contains(name.Text)).Select(x => new
            {
                رقم_العميل = x.id_client,
                اسم_العميل = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                الايميل = x.mail,
                بيانات_اخري = x.other_details

            }).ToList();

        }

        private void btn_Search2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Clients.Where(x => x.phone.Contains(phone.Text)).Select(x => new
            {
                رقم_العميل = x.id_client,
                اسم_العميل = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                الايميل = x.mail,
                بيانات_اخري = x.other_details

            }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
