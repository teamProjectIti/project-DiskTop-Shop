using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
    public partial class FrmOffers : Form
    {
            DataContext context = new DataContext();
        private Offers _savedOffer;

        public FrmOffers()
        {
            InitializeComponent();

        comboBoxCompany.DataSource = context.Companys.ToList();
            comboBoxCompany.DisplayMember = "Name";
            comboBoxCompany.ValueMember = "Id";

            comboBoxUser.DataSource = context.Users.ToList();
            comboBoxUser.DisplayMember = "Name";
            comboBoxUser.ValueMember = "Id";

            comboBoxProduct.DataSource = context.products.ToList();
            comboBoxProduct.DisplayMember = "Name";
            comboBoxProduct.ValueMember = "Id";
        }

        private void IconPictureBox2_Click(object sender, EventArgs e)
        {
            landingPage_disktop f = new landingPage_disktop();
            f.ShowDialog();
            this.Hide();
        }
        public FrmOffers(int id) : this()
        {
            _savedOffer = context.Offers.FirstOrDefault(x => x.Id == id);

            txtCode.Text = _savedOffer.CodeCopone;
            txtDetails.Text = _savedOffer.Details;
            dateTimePickerCreateOffer.Value = _savedOffer.CreatedDate;
            dateTimePickerEndOffer.Value = _savedOffer.EndDate;
            comboBoxCompany.SelectedValue = _savedOffer.CompanyId;
            comboBoxUser.SelectedValue = _savedOffer.id_user;
            comboBoxProduct.SelectedValue = _savedOffer.ID_pro;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Offers offers = new Offers()
            {
                Details = txtDetails.Text,
                CodeCopone = txtCode.Text,
                CompanyId = Convert.ToInt32(comboBoxCompany.SelectedValue),
                id_user = Convert.ToInt32(comboBoxUser.SelectedValue),
                CreatedDate = dateTimePickerCreateOffer.Value,
                EndDate = dateTimePickerEndOffer.Value,
                ID_pro = Convert.ToInt32(comboBoxProduct.SelectedValue)
            };

            context.Offers.AddOrUpdate(offers);

            context.SaveChanges();
            _savedOffer = offers;

            MessageBox.Show("تم حفظ البيانات بنجاح");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_savedOffer.Id > 0)
            {
                var result = MessageBox.Show("هل انت متاكد من الحذف", "الحذف", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    context.Offers.Remove(_savedOffer);
                    context.SaveChanges();

                    _savedOffer = new Offers();

                    txtCode.Text = "";
                    txtDetails.Text = "";
                    dateTimePickerCreateOffer.Value = DateTime.Now;
                    dateTimePickerEndOffer.Value = DateTime.Now;
                    comboBoxCompany.SelectedIndex = 0;
                    comboBoxUser.SelectedIndex = 0;
                    comboBoxProduct.SelectedIndex = 0;

                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_savedOffer.Id > 0)
            {
                _savedOffer.CodeCopone = txtCode.Text;
                _savedOffer.Details = txtDetails.Text;
                _savedOffer.CodeCopone = txtCode.Text;
                _savedOffer.CompanyId = Convert.ToInt32(comboBoxCompany.SelectedValue);
                _savedOffer.id_user = Convert.ToInt32(comboBoxUser.SelectedValue);
                _savedOffer.CreatedDate = dateTimePickerCreateOffer.Value;
                _savedOffer.EndDate = dateTimePickerEndOffer.Value;
                _savedOffer.ID_pro = Convert.ToInt32(comboBoxProduct.SelectedValue);

                context.Offers.AddOrUpdate(_savedOffer);

                context.SaveChanges();

                MessageBox.Show("Data Updated Successfully");
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
