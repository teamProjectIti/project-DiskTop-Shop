using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Company : UserControl
    {
        private static Company _sas;
        public static Company sas
        {
            get
            {
                if (_sas == null)
                    _sas = new Company();
                return _sas;
            }
        }
        public Company()
        {
            InitializeComponent();
        }

        private void btnAdd_Company_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.company.Add_Company b = new WindowsFormsApp1.company.Add_Company();
            b.ShowDialog();
        }

        private void btnUpdate_Company_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.company.Update_Delete b = new WindowsFormsApp1.company.Update_Delete();
            b.ShowDialog();
        }

        private void btnSearch_Company_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.company.Search_Company b = new WindowsFormsApp1.company.Search_Company();
            b.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void Company_Load(object sender, EventArgs e)
        {

        }
    }
}
