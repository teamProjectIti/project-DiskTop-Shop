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
    public partial class Branch : UserControl
    {

        private static Branch _sas;
        public static Branch sas
        {
            get
            {
                if (_sas == null)
                    _sas = new Branch();
                return _sas;
            }
        }
        public Branch()
        {
            InitializeComponent();
        }

        private void btnAdd_Branch_Click(object sender, EventArgs e)
        {

            WindowsFormsApp1.branch.Add_Branch b = new WindowsFormsApp1.branch.Add_Branch();
            b.ShowDialog();
        }

        private void btnUpdate_Branch_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.branch.Update_Or_Delete b = new WindowsFormsApp1.branch.Update_Or_Delete();
            b.ShowDialog();
        }

        private void btnSearch_Branch_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.branch.Search_Branch b = new WindowsFormsApp1.branch.Search_Branch();
            b.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Branch_Load(object sender, EventArgs e)
        {

        }
    }
}
