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

namespace WindowsFormsApp1.branch
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
            dataGridView1.DataSource = db.Branchs.Select(x => new
            {
                رقم_الفرع = x.id,
                اسم_الفرع = x.name,
                رقم_التليفون = x.phone,
                العنوان = x.address,
                اسم_العميل = x.clients.name

            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id =int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txt_ID.Text = id.ToString();
            txt_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Client_id.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "" && txt_Name.Text != "" && txt_Phone.Text != "" && txt_Address.Text != "" && txt_Client_id.Text != "")
            {

                int selectedValue_client = Convert.ToInt32(txt_Client_id.SelectedValue);

                try
                {
                    Model.Branch bra = (from b in db.Branchs
                                         where b.id == id
                                         select b).FirstOrDefault();
                    bra.name = txt_Name.Text;
                    bra.phone = txt_Phone.Text;
                    bra.address = txt_Address.Text;
                    var a = db.Clients.Where(x => x.name.Contains(txt_Client_id.Text)).FirstOrDefault();
                    bra.client_id = Convert.ToInt32(a.id_client);

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var item = db.Branchs.Find(id);
                db.Branchs.Remove(item);
                MessageBox.Show("هل تريد بالفعل حذف هذا!", "رسالة مساعدة", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                db.SaveChanges();
                dataGridView1.DataSource = db.Branchs.ToList();
                MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception)
            {
                MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }

        private void clear()
        {
            txt_ID.Text = txt_Name.Text = txt_Phone.Text = txt_Address.Text = "";

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Data();
        }
    }
}
