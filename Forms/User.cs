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
    public partial class User : UserControl
    {
        private static User _sas;
        public static User sas
        {
            get
            {
                if (_sas == null)
                    _sas = new User();
                return _sas;
            }
        }

        public User()
        {
            InitializeComponent();
        }

        private void btnAdd_User_Click(object sender, EventArgs e)
        {

            WindowsFormsApp1.user.Add_User b = new WindowsFormsApp1.user.Add_User();
            b.ShowDialog();
        }

        private void btnUpdate_User_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.user.Update_Or_Delete b = new WindowsFormsApp1.user.Update_Or_Delete();
            b.ShowDialog();
        }

        private void btnSearch_User_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.user.Search_User b = new WindowsFormsApp1.user.Search_User();
            b.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
