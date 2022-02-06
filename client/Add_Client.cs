using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.client
{
    public partial class Add_Client : Form
    {
        DataContext db = new DataContext();

        public Add_Client()
        {
            InitializeComponent();
        }

        private void btn_Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "اختيار صورة شخصية (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = of.FileName;

            }
        }

        //this  function to store image(help function)
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
        private void clear()
        {
             txt_name.Text = txt_Phone.Text = txt_mail.Text = txt_address.Text = txt_details.Text = "";
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != null && txt_name.Text != "" && txt_address.Text != "" && txt_Phone.Text != "" && txt_mail.Text != "" && txt_details.Text != "")
            {

                List<Model.Client> m = new List<Model.Client>();
                m.Add(new Model.Client()
                {
                    name = txt_name.Text,
                    phone = txt_Phone.Text,
                    address = txt_address.Text,
                    mail = txt_mail.Text,
                    other_details = txt_details.Text,
                    image = ReadFile(pictureBox1.ImageLocation)
                });
                foreach (var item in m.Take(1))
                {
                    db.Clients.Add(item);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Add_Client_Load(object sender, EventArgs e)
        {
            clear();

        }

        private void Txt_SSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
