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

namespace WindowsFormsApp1.Departure
{
    public partial class Departure_form : Form
    {

        DataContext context = new DataContext();
        private Depature _depature;

        public Departure_form()
        {
            InitializeComponent();
        }
        public Departure_form(int id) : this()
        {
            _depature = context.Depatures.FirstOrDefault(y => y.Id == id);

            dateTimePickerEnd.Value = _depature.FinshedDate;
            dateTimePickerStart.Value = _depature.StartDate;
            txtOther.Text = _depature.Others;
            comboBoxUser.SelectedValue = _depature.id_user;
            comboBoxStatus.Text = _depature.State;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            _depature = new Depature
            {
                FinshedDate = dateTimePickerEnd.Value,
                StartDate = dateTimePickerStart.Value,
                Others = txtOther.Text,
                id_user = Convert.ToInt32(comboBoxUser.SelectedValue),
                State = comboBoxStatus.Text
            };

            context.Depatures.Add(_depature);
            context.SaveChanges();
            MessageBox.Show("Data Saved Successfully");
        }

        private void Departure_form_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_depature.Id > 0)
            {
                _depature.FinshedDate = dateTimePickerEnd.Value;
                _depature.StartDate = dateTimePickerStart.Value;
                _depature.Others = txtOther.Text;
                _depature.id_user = Convert.ToInt32(comboBoxUser.SelectedValue);
                _depature.State = comboBoxStatus.Text;

                context.Depatures.AddOrUpdate(_depature);
                context.SaveChanges();

                MessageBox.Show("Data Updated Successfully");
            }
        }

        private void BtnBackToList_Click(object sender, EventArgs e)
        {
            this.Hide();
            landingPage_disktop f = new landingPage_disktop();
            f.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_depature.Id > 0)
            {
                var result = MessageBox.Show("هل انت متاكد من الحذف", "الحذف", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    context.Depatures.Remove(_depature);
                    context.SaveChanges();

                    _depature = new Depature();
                    dateTimePickerEnd.Value = DateTime.Now;
                    dateTimePickerStart.Value = DateTime.Now;
                    txtOther.Text = "";
                    comboBoxUser.SelectedValue = 0;
                    comboBoxStatus.SelectedIndex = 0;
                }
            }
        }
    }
}
