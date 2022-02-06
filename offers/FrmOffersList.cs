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
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.offers
{
    public partial class FrmOffersList : Form
    {
        DataContext context = new DataContext();
        public FrmOffersList()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgrList.DataSource = context.Offers
                            .Select(x => new
                            {
                                رقم = x.Id,
                                التفاصيل = x.Details,
                                كود = x.CodeCopone,
                                المنتج = x.product != null ? x.product.Name : ""
                            }).ToList();
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmOffers frm = new FrmOffers();
            frm.Show();
            this.Hide();
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgrList.SelectedRows[0].Cells[0].Value);

            FrmOffers frm = new FrmOffers(id);
            frm.Show();
            this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل انت متاكد من حذف هذا البيان", "تاكيد الحذف", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgrList.SelectedRows[0].Cells[0].Value);
                Offers entity = context.Offers.FirstOrDefault(t => t.Id == id);

                context.Offers.Remove(entity);
                context.SaveChanges();
                LoadData();
            }

        }

        private void IconPictureBox2_Click(object sender, EventArgs e)
        {
            landingPage_disktop f = new landingPage_disktop();
            f.ShowDialog();
            this.Hide();
        }
    }
}
