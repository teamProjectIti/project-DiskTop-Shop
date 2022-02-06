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
    public partial class Clients : UserControl
    {

        private static Clients _sas;
        public static Clients sas
        {
            get
            {
                if (_sas == null)
                    _sas = new Clients();
                return _sas;
            }
        }
        public Clients()
        {
            InitializeComponent();
        }

        private void btnAdd_Client_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.client.Add_Client b = new client.Add_Client();
            b.ShowDialog();
        }

        private void btnUpdate_Client_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.client.Update_Or_Delete b = new client.Update_Or_Delete ();
            b.ShowDialog();
        }

        private void btnSearch_Client_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.client.Search_Client b = new client.Search_Client();
            b.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            // this.Hide();
            this.Parent.Controls.Remove(this);
        }
    }
}
