using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.client
{
    public partial class Update_Or_Delete : Form
    {
        DataContext db = new DataContext();

        public Update_Or_Delete()
        {
            InitializeComponent();
        }

        void Data()
        {
            dataGridView1.DataSource = db.Clients.Select(x => new
            {
                رقم_العميل = x.id_client,
                اسم_العميل = x.name,
                العنوان = x.address,
                رقم_التليفون = x.phone,
                الايميل = x.mail,
                بيانات_اخري = x.other_details,
                صورة = x.image
            }).ToList();
        }
        private void Update_Or_Delete_Load(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Data();
        }
        int id;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txt_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_addrees.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_mail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_details.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            byte[] ImageData = (byte[])dataGridView1.Rows[e.RowIndex].Cells[6].Value;

            Image NewImage;
            using (MemoryStream MS = new MemoryStream(ImageData, 0, ImageData.Length))
            { MS.Write(ImageData, 0, ImageData.Length); NewImage = Image.FromStream(MS, true); }
            pictureBox1.Image = NewImage;

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "اختيار صورة للمنتج (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = of.FileName;
            }
        }

        public byte[] ReadFile(string ImagePath)
        {
            byte[] Image_Binary_data = null;
            FileInfo FInfo = new FileInfo(ImagePath);
            long numBytes = FInfo.Length;
            FileStream FStream = new FileStream(ImagePath, FileMode.Open, FileAccess.Read);
            BinaryReader BR = new BinaryReader(FStream);
            Image_Binary_data = BR.ReadBytes((int)numBytes);
            return Image_Binary_data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_no.Text != "" && txt_name.Text != "" && txt_addrees.Text != "" && txt_phone.Text != "" && txt_mail.Text != "" && txt_details.Text != "" && pictureBox1.ImageLocation != null)
            {



                try
                {
                    Model.Client c = (from c1 in db.Clients
                                      where c1.id_client == id
                                      select c1).FirstOrDefault();
                    c.name = txt_name.Text;
                    c.address = txt_addrees.Text;
                    c.phone = txt_phone.Text;
                    c.mail = txt_mail.Text;
                    c.other_details = txt_details.Text;
                    c.image = ReadFile(pictureBox1.ImageLocation);


                    db.Entry(c).State = EntityState.Modified;
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
            txt_name.Text = txt_addrees.Text = txt_phone.Text = txt_mail.Text = txt_details.Text = "";
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متاكد حذف هذا العنصر", "قائمة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    var item = db.Clients.Find(id);
                    db.Clients.Remove(item);
                    db.SaveChanges();
                    Data();
                    clear();
                    MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                catch (Exception)
                {
                    MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }

            }
        }
    }
}
