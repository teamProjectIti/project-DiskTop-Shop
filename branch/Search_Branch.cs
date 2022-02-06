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

namespace WindowsFormsApp1.branch
{
    public partial class Search_Branch : Form
    {

        DataContext db = new DataContext();
        public Search_Branch()
        {
            InitializeComponent();
        }

        private void Search_Branch_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Branchs.Select(x => new
            {
                رقم_الفرع = x.id,
                اسم_الفرع = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                اسم_العميل = x.clients.id_client.ToString()

            }).ToList();

        }

        private void btn_name_Click(object sender, EventArgs e)
        {


            dataGridView1.DataSource = db.Branchs.Where(x => x.name.Contains(txtSearchName.Text)).Select(x => new
            {
                رقم_الفرع = x.id,
                اسم_الفرع = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                اسم_العميل = x.clients.id_client.ToString()

            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Branchs.Where(x => x.phone.Contains(txtSearchNum.Text)).Select(x => new
            {
                رقم_الفرع = x.id,
                اسم_الفرع = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                اسم_العميل = x.clients.id_client.ToString()

            }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
