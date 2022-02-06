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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Form_product
{
    public partial class add_pro_Form : Form
    {
        DataContext db = new DataContext();
        public add_pro_Form()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "اختيار صورة للمنتج (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
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
            tx_date.Value =tx_expeie.Value= DateTime.Now;
            tx_name.Text =tx_comment.Text= "";
            tx_price_one.Text = tx_price_one_oraginal.Text = tx_qount.Text = "0";
             pictureBox1.Image = null;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != null && tx_price_one.Text != "" && tx_price_one_oraginal.Text != "" && tx_qount.Text != ""&& tx_name.Text != "")
            {
                double all_pice_buy = Convert.ToDouble(tx_qount.Text) * Convert.ToDouble(tx_price_one.Text);
                double all_pice_sall = Convert.ToDouble(tx_qount.Text) * Convert.ToDouble(tx_price_one_oraginal.Text);
                double earn = all_pice_sall - all_pice_buy;
                int selectedValue_cat = Convert.ToInt32(tx_cat.SelectedValue);
                int selectedValue_sub = Convert.ToInt32(tx_sub.SelectedValue);
                List<product> m = new List<product>();
                m.Add(new product()
                {
                    Id_cat = selectedValue_cat,
                    ID_sub = selectedValue_sub,
                    Name = tx_name.Text,
                    priceBuy_one = Convert.ToDouble(tx_price_one.Text),
                    priceBuyOrgnal_all = all_pice_buy,
                    price_Sall_one = Convert.ToDouble(tx_price_one_oraginal.Text),
                    price_Sall_all = all_pice_sall,
                    Image = ReadFile(pictureBox1.ImageLocation),
                    Date_attach = tx_date.Value,
                    Date_Experied = tx_expeie.Value,
                    Qount = Convert.ToDouble(tx_qount.Text),
                    earn_Money = earn,
                    comment=tx_comment.Text
                });
                foreach (var item in m.Take(1))
                {
                    db.products.Add(item);
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

        private void Add_pro_Form_Load(object sender, EventArgs e)
        {
            clear();
         data();
        }
        void data()
        {
             tx_cat.DataSource = db.cats.ToList();
            tx_cat.ValueMember = "ID_CAt";
            tx_cat.DisplayMember = "Name_cat";

            tx_sub.DataSource = db.Sub_Cat.ToList();
            tx_sub.ValueMember = "ID_sub";
            tx_sub.DisplayMember = "Name_Sub";

        }

        private void Tx_qount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled == char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال رقم ", "تنبية للاستخدام", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void Tx_price_one_oraginal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tx_price_one_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tx_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tx_expeie_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Tx_sub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Tx_comment_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Tx_cat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tx_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Tx_qount_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
