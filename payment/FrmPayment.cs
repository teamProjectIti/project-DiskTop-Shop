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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.payment
{
    public partial class FrmPayment : Form
    {
        DataContext context = new DataContext();
        Payment _payment;
        public FrmPayment()
        {
            InitializeComponent();
            comboBoxCompany.DataSource = context.Companys.ToList();
            comboBoxCompany.DisplayMember = "Name";
            comboBoxCompany.ValueMember = "Id";

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _payment = new Payment()
            {
                Amount = numericUpDown1.Value,
                CompanyId = Convert.ToInt32(comboBoxCompany.SelectedValue),
                Type = comboBoxStatus.Text,
            };
        }
        public FrmPayment(int id) : this()
        {
            _payment = context.Payments.FirstOrDefault(t => t.Id == id);

            numericUpDown1.Value = _payment.Amount;
            comboBoxCompany.SelectedValue = _payment.Company;
        }
        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            if (_payment.Id > 0)
            {

                _payment.CompanyId = Convert.ToInt32(comboBoxCompany.SelectedValue);


                _payment.Type = comboBoxStatus.Text;

                context.Payments.AddOrUpdate(_payment);
                context.SaveChanges();

                MessageBox.Show("تمت عملية التعديل بنجاح");
            }

        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            if (_payment.Id > 0)
            {
                var result = MessageBox.Show("هل انت متاكد من الحذف", "الحذف", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    context.Payments.Remove(_payment);
                    context.SaveChanges();

                    _payment = new Payment();

                    comboBoxCompany.SelectedValue = 0;

                    comboBoxStatus.SelectedIndex = 0;
                }
            }
        }
    }
}
