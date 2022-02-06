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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Form_product
{
    public partial class Edit_form : Form
    {
        DataContext db = new DataContext();
        public Edit_form()
        {
            InitializeComponent();
        }
        void Data()
        {
            dataGridView1.DataSource = db.products.Select(x => new
            {
                الرقم = x.ID_pro,
                الاسم = x.Name,
                الاسم_الفرعي = x.Sub_Cat.Name_Sub,
                الاسم_الرئيسي = x.cat.Name_cat,
                الكمية = x.Qount,
                تاريخ_انتهاء_الصلاحية = x.Date_Experied,
                تاريخ_الانضام = x.Date_attach,
                السعر = x.priceBuy_one,
                سعر_الجمله = x.priceBuyOrgnal_all,
                سعر_القطاعي = x.price_Sall_all,
                سعر_القطاعي_للواحدة = x.price_Sall_one,
                تفاصيل_اخري = x.comment,
                صورة = x.Image
            }).ToList();
        }
        private void Edit_form_Load(object sender, EventArgs e)
        {
            Data();
        }
        int pro_ID;
        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pro_ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tx_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tx_sub.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tx_cat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tx_qount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tx_expeie.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tx_date.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tx_price_one.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tx_price_one_oraginal.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tx_comment.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            byte[]ImageData = (byte[])dataGridView1.Rows[e.RowIndex].Cells[12].Value;

            Image NewImage;
            using (MemoryStream MS = new MemoryStream(ImageData, 0, ImageData.Length))
            { MS.Write(ImageData, 0, ImageData.Length); NewImage = Image.FromStream(MS, true); }
            pictureBox1.Image = NewImage;
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
        private void Button1_Click(object sender, EventArgs e)
        {

            if (pictureBox1.ImageLocation != null && tx_price_one.Text != "" && tx_price_one_oraginal.Text != "" && tx_qount.Text != "" && tx_name.Text != "")
            {
                double all_pice_buy = Convert.ToDouble(tx_qount.Text) * Convert.ToDouble(tx_price_one.Text);
                double all_pice_sall = Convert.ToDouble(tx_qount.Text) * Convert.ToDouble(tx_price_one_oraginal.Text);
                double earn = all_pice_sall - all_pice_buy;
                int selectedValue_cat = Convert.ToInt32(tx_cat.SelectedValue);
                int selectedValue_sub = Convert.ToInt32(tx_sub.SelectedValue);

                try
                {
                    product pro = (from cl in db.products
                                           where cl.ID_pro == pro_ID
                                   select cl).FirstOrDefault();
                    pro.Name = tx_name.Text;
                    pro.Date_Experied = tx_expeie.Value;
                    pro.Date_attach = tx_date.Value;
                    var a = db.cats.Where(x => x.Name_cat.Contains(tx_cat.Text)).FirstOrDefault();
                    pro.Id_cat = Convert.ToInt32(a.ID_CAt);
                    var a2 = db.Sub_Cat.Where(ww => ww.Name_Sub.Contains(tx_sub.Text)).FirstOrDefault();
                    pro.ID_sub = Convert.ToInt32(a2.ID_sub);
                    pro.Qount = Convert.ToDouble(tx_qount.Text);
                    pro.earn_Money = earn;
                    pro.comment = tx_comment.Text;
                    pro.priceBuy_one = Convert.ToDouble(tx_price_one.Text);
                    pro.priceBuyOrgnal_all = all_pice_buy;
                    pro.price_Sall_one = Convert.ToDouble(tx_price_one_oraginal.Text);
                    pro.price_Sall_all = all_pice_sall;
                    pro.Image = ReadFile(pictureBox1.ImageLocation);
                 

                    db.Entry(pro).State = EntityState.Modified;
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
            tx_date.Value = tx_expeie.Value = DateTime.Now;
            tx_name.Text = tx_comment.Text = "";
            tx_price_one.Text = tx_price_one_oraginal.Text = tx_qount.Text = "0";
            pictureBox1.Image = null;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
