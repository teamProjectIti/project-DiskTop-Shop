using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.branch;
using WindowsFormsApp1.distrbution;
using WindowsFormsApp1.user;
using WindowsFormsApp1.Store;
using WindowsFormsApp1.order;

namespace WindowsFormsApp1
{
    public partial class AllPage : UserControl
    {
        public AllPage()
        {
            InitializeComponent();
        }

        private void Label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(85, 215, 219);
            this.label3.ForeColor = System.Drawing.Color.White;
        }

        private void Label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
            this.label3.ForeColor = System.Drawing.Color.Navy;

        }

        private void Panel1_MouseHover(object sender, EventArgs e)
        {
            Label l = new Label();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            SetingBill f = new SetingBill();
            f.ShowDialog();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Search_User f = new Search_User();
            f.ShowDialog();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            FrmDistribution f = new FrmDistribution();
            f.ShowDialog();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            Store_F f = new Store_F();
            f.ShowDialog();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            branch.Update_Or_Delete f = new branch.Update_Or_Delete();
            f.ShowDialog();
        }

        private void Label10_Click(object sender, EventArgs e)
        {
        }

        private void Label3_MouseHover_1(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(85, 215, 219);
            this.label3.ForeColor = System.Drawing.Color.White;

        }

        private void Label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(85, 215, 219);
            this.label4.ForeColor = System.Drawing.Color.White;
        }

        private void Label5_MouseHover(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(85, 215, 219);
            this.label5.ForeColor = System.Drawing.Color.White;
        }

        private void Label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(85, 215, 219);
            this.label6.ForeColor = System.Drawing.Color.White;
        }

        private void Label7_MouseHover(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(85, 215, 219);
            this.label7.ForeColor = System.Drawing.Color.White;
        }

        private void Label8_MouseHover(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(85, 215, 219);
            this.label8.ForeColor = System.Drawing.Color.White;
        }

        private void Label9_MouseHover(object sender, EventArgs e)
        {
            label9.BackColor = Color.FromArgb(85, 215, 219);
            this.label9.ForeColor = System.Drawing.Color.White;
        }



        private void Label3_MouseLeave_1(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
            this.label3.ForeColor = System.Drawing.Color.Navy;

        }

        private void Label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.White;
            this.label4.ForeColor = System.Drawing.Color.Navy;

        }

        private void Label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.White;
            this.label5.ForeColor = System.Drawing.Color.Navy;

        }

        private void Label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.White;
            this.label6.ForeColor = System.Drawing.Color.Navy;

        }

        private void Label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.White;
            this.label7.ForeColor = System.Drawing.Color.Navy;

        }

        private void Label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.White;
            this.label8.ForeColor = System.Drawing.Color.Navy;

        }

        private void Label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.White;
            this.label9.ForeColor = System.Drawing.Color.Navy;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
                panel1.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
                panel1.Visible = false;
                button1.Visible = true;
                button2.Visible = false;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
          
        }

        private void AllPage_Load(object sender, EventArgs e)
        {

        }

        private void Label3_MouseHover_2(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(85, 215, 219);
            this.label3.ForeColor = System.Drawing.Color.White;
        }

        private void Label3_MouseLeave_2(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
            this.label3.ForeColor = System.Drawing.Color.Navy;
        }

        private void Label3_Click_1(object sender, EventArgs e)
        {
            client.Update_Or_Delete f = new client.Update_Or_Delete();
            f.ShowDialog();
        }
    }
}

        
      
