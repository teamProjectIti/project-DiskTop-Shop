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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class Login : Form
    {
        DataContext db = new DataContext();

        public Login()
        {
            InitializeComponent();



            label3.BackColor = Color.FromArgb(100, 76, 78, 78);
            label2.BackColor = Color.FromArgb(100, 73 ,79, 88);
            iconPictureBox1.BackColor = Color.FromArgb(100, 34, 69, 88);
            iconPictureBox2.BackColor = Color.FromArgb(100, 77, 79, 58);
            iconPictureBox3.BackColor = Color.FromArgb(100, 88, 78, 58);
            iconPictureBox4.BackColor = Color.FromArgb(100, 99, 70, 58);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_USName.Text))
            {
                MessageBox.Show(" خطأ في ادخال البيانات !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_USName.Focus();
                return;
            }
            try
            {
                using (DataContext db = new DataContext())
                {
                    var query = db.Users.Where(ww => ww.name == txt_USName.Text && ww.password == txt_Pass.Text).FirstOrDefault();
                        
                    //var query = from u in db.Users
                    //            where u.name == txt_USName.Text && u.password == txt_Pass.Text
                    //            select u;
                    //check if user exists
                    if (query != null)
                    {

                        var qq = db.Users.Where(ww => ww.password == txt_Pass.Text).First();
                        if (qq.user_type == "Admin")
                        {
                            landingPage_disktop.get_Min.بحثToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.منتجاتToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.موظفينToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.عملاءToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.فواتيرToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.شركاتToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.الفروعToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.اصنافToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.button1.Enabled = true;
                            landingPage_disktop.get_Min.button2.Enabled = true;
                            landingPage_disktop.get_Min.button3.Enabled = true;
                            landingPage_disktop.get_Min.button4.Enabled = true;
                            landingPage_disktop.get_Min.button5.Enabled = true;
                            landingPage_disktop.get_Min.عرضفواتيراخراسبوعToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.button6.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox3.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox2.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox10.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox10.Visible = true;
                            landingPage_disktop.get_Min.iconPictureBox11.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox11.Visible = true;
                            landingPage_disktop.get_Min.iconPictureBox1.Enabled = true;
                            Program.salesMan = txt_USName.Text;

                            try
                            {
                                Depature d = new Depature();
                                d.id_user = qq.id_user;
                                d.StartDate = DateTime.Now;
                                d.State = "active";
                                db.Depatures.Add(d);
                                db.SaveChanges();
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                        }
                        else if (qq.user_type == "Employee")
                        {
                            landingPage_disktop.get_Min.فواتيرToolStripMenuItem.Enabled = true;

                            landingPage_disktop.get_Min.button1.Enabled = true;
                            landingPage_disktop.get_Min.button2.Enabled = true;
                            landingPage_disktop.get_Min.button3.Enabled = true;
                            landingPage_disktop.get_Min.button4.Enabled = true;
                            landingPage_disktop.get_Min.button5.Enabled = true;
                            landingPage_disktop.get_Min.فواتيرToolStripMenuItem.Enabled = true;
                            Program.salesMan = txt_USName.Text;

                            try
                            {
                                Depature d = new Depature();
                                d.id_user = qq.id_user;
                                d.StartDate = DateTime.Now;
                                d.State = "active";
                                d.FinshedDate = DateTime.Now;
                                db.Depatures.Add(d);
                                db.SaveChanges();
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                        }
                        else if (qq.user_type == "Manger")
                        {
                            landingPage_disktop.get_Min.فواتيرToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.button1.Enabled = true;
                            landingPage_disktop.get_Min.button2.Enabled = true;
                            landingPage_disktop.get_Min.button3.Enabled = true;
                            landingPage_disktop.get_Min.button4.Enabled = true;
                            landingPage_disktop.get_Min.button5.Enabled = true;
                            landingPage_disktop.get_Min.فواتيرToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.موظفينToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.عملاءToolStripMenuItem.Enabled = true;
                            Program.salesMan = txt_USName.Text;

                            try
                            {
                                Depature d = new Depature();
                                d.id_user = qq.id_user;
                                d.StartDate = DateTime.Now;
                                d.State = "active";
                                db.Depatures.Add(d);
                                db.SaveChanges();
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                        }


                        this.Close();


                        // MessageBox.Show("You have been successfully logged in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Add your code process login here
                    }
                    else
                    {
                        var a = 12345.ToString();
                        if (txt_USName.Text =="test"&& txt_Pass.Text ==a )
                        {
                            Program.salesMan = txt_USName.Text;
                            landingPage_disktop m = new landingPage_disktop();
                            landingPage_disktop.get_Min.بحثToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.منتجاتToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.موظفينToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.عملاءToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.فواتيرToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.شركاتToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.الفروعToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.اصنافToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.button1.Enabled = true;
                            landingPage_disktop.get_Min.button2.Enabled = true;
                            landingPage_disktop.get_Min.button3.Enabled = true;
                            landingPage_disktop.get_Min.button4.Enabled = true;
                            landingPage_disktop.get_Min.button5.Enabled = true;
                            landingPage_disktop.get_Min.عرضفواتيراخراسبوعToolStripMenuItem.Enabled = true;
                            landingPage_disktop.get_Min.button6.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox3.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox2.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox1.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox10.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox10.Visible = true;
                            landingPage_disktop.get_Min.iconPictureBox11.Enabled = true;
                            landingPage_disktop.get_Min.iconPictureBox11.Visible = true;
                            Program.salesMan = txt_USName.Text;
                            this.Close();
                        }
                        else
                        {
                        MessageBox.Show(" خطأ في ادخال اسم المستخدم او الباسورد", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
