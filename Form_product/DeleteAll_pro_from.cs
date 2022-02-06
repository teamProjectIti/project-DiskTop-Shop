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

namespace WindowsFormsApp1.Form_product
{
    public partial class DeleteAll_pro_from : Form
    {
        DataContext db = new DataContext();
        public DeleteAll_pro_from()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteAll_pro_from_Load(object sender, EventArgs e)
        {
            Data();
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
               // سعر_الجمله = x.priceBuyOrgnal_all,
               // سعر_القطاعي = x.price_Sall_all,
              //  سعر_القطاعي_للواحدة = x.price_Sall_one,
                تفاصيل_اخري = x.comment,
                صورة = x.Image
            }).ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد حذف هذا العنصر", "قائمة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    if (id_pro !=0)
                    {
                        var item = db.products.Find(id_pro);
                        db.products.Remove(item);
                        db.SaveChanges();
                        Data();
                        MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }
        int id_pro;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                id_pro = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var list = db.products.ToList();
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    timer1.Start();
                    progressBar1.Visible = true;
                    db.products.Remove(item);
                    db.SaveChanges();
                    Data();
                    //MessageBox.Show("تم عملية حذف جميع العناصر بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("عفوا القائمة فارغة", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Step +=1;
            progressBar1.PerformStep();
            progressBar1.Visible = false;

        }
    }
}
