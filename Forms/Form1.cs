using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgs(0,0,Width,Height,25,25));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgs
            (
            int nleftRect,
            int ntopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        private void Form1_Load(object sender, EventArgs e)
        {
            progress1.Value = 1;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progress1.Value += 1;
            progress1.Text = progress1.Value.ToString() + "%";
            if (progress1.Value == 100)
            {
                timer1.Enabled = false;
                landingPage_disktop f = new landingPage_disktop();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
