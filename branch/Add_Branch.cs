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
    public partial class Add_Branch : Form
    {
        DataContext db = new DataContext();
        public Add_Branch()
        {
            InitializeComponent();
        }

        private void Add_Branch_Load(object sender, EventArgs e)
        {
            clear();
            data();
        }

        private void clear()
        {
             txt_Name.Text = txt_Phone.Text = txt_Address.Text = txt_Client_id.Text = "";

        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            if ( txt_Name.Text != "" && txt_Phone.Text != "" && txt_Address.Text != "")
            {
                int selectedValue_client = Convert.ToInt32(txt_Client_id.SelectedValue);

                List<Model.Branch> m = new List<Model.Branch>();
                m.Add(new Model.Branch()
                {

                    name = txt_Name.Text,
                    phone = txt_Phone.Text,
                    address = txt_Address.Text,
                    client_id = selectedValue_client

                });
                foreach (var item in m.Take(1))
                {
                    db.Branchs.Add(item);
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

        void data()
        {
            txt_Client_id.DataSource = db.Clients.ToList();
            txt_Client_id.ValueMember = "id_client";
            txt_Client_id.DisplayMember = "name";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
