using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.branch;
using WindowsFormsApp1.client;
using WindowsFormsApp1.company;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.distrbution;
using WindowsFormsApp1.Form_product;
using WindowsFormsApp1.form_Subject;
using WindowsFormsApp1.Form_table;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.order;
using WindowsFormsApp1.search;
using WindowsFormsApp1.Store;
using WindowsFormsApp1.user;

namespace WindowsFormsApp1.Forms
{
    public partial class landingPage_disktop : Form
    {
        private static landingPage_disktop frm;

        static void frm_closed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }
        public static landingPage_disktop get_Min
        {
            get
            {
                if (frm == null)
                {
                    frm = new landingPage_disktop();
                    frm.FormClosed += new FormClosedEventHandler(frm_closed);
                }
                return frm;
            }
        }
        bool hidden;
        public landingPage_disktop()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            if (frm == null)
                frm = this;

            this.بحثToolStripMenuItem.Enabled = false;
            this.منتجاتToolStripMenuItem.Enabled = false;
            this.موظفينToolStripMenuItem.Enabled = false;
            this.عملاءToolStripMenuItem.Enabled = false;
            this.فواتيرToolStripMenuItem.Enabled = false;
            this.شركاتToolStripMenuItem.Enabled = false;
            this.الفروعToolStripMenuItem.Enabled = false;
            this.اصنافToolStripMenuItem.Enabled = false;
            this.عرضفواتيراخراسبوعToolStripMenuItem.Enabled = false;
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.iconPictureBox3.Enabled = false;
            this.iconPictureBox2.Enabled = false;
            this.iconPictureBox1.Enabled = false;
            this.iconPictureBox10.Enabled = false;
            this.iconPictureBox10.Visible = false;
            this.iconPictureBox11.Enabled = false;
            this.iconPictureBox11.Visible = false;


            back();
        }
        void back()
        {
            allPage1.BackColor = Color.FromArgb(100, 99, 70, 58);
            button1.BackColor = Color.FromArgb(100, 99, 70, 58);
            button2.BackColor = Color.FromArgb(100, 99, 70, 58);
            button3.BackColor = Color.FromArgb(100, 99, 70, 58);
            button4.BackColor = Color.FromArgb(100, 99, 70, 58);
            button5.BackColor = Color.FromArgb(100, 99, 70, 58);
            button6.BackColor = Color.FromArgb(100, 99, 70, 58);
            allPage1.BackColor = Color.FromArgb(100, 99, 70, 58);
            iconPictureBox4.BackColor = Color.FromArgb(100, 99, 70, 58);
            iconPictureBox5.BackColor = Color.FromArgb(100, 99, 70, 58);
            iconPictureBox6.BackColor = Color.FromArgb(100, 99, 70, 58);
            iconPictureBox7.BackColor = Color.FromArgb(100, 99, 70, 58);
            iconPictureBox8.BackColor = Color.FromArgb(100, 99, 70, 58);
            iconPictureBox9.BackColor = Color.FromArgb(100, 99, 70, 58);
            iconPictureBox10.BackColor = Color.FromArgb(100, 99, 70, 58);
        }
        private void AllPage1_Load(object sender, EventArgs e)
        {
           
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            try
            {
                DataContext db = new DataContext();
                int a = Convert.ToInt32(Program.Type_User_by_login_BYID);
                Depature brunch_Item = (from cl in db.Depatures
                                        where cl.Id == a
                                        select cl).FirstOrDefault();
                brunch_Item.FinshedDate = DateTime.Now;
                db.Entry(brunch_Item).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {

                this.Close();
            }
            this.Close();
        }

        private void LandingPage_disktop_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataContext db = new DataContext();
                int a = Convert.ToInt32(Program.Type_User_by_login_BYID);
                Depature brunch_Item = (from cl in db.Depatures
                                        where cl.Id == a
                                        select cl).FirstOrDefault();
                brunch_Item.FinshedDate = DateTime.Now;
                db.Entry(brunch_Item).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void طباعةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةمنتججديدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table_cat_designe f = new table_cat_designe();
            f.ShowDialog();
        }

        private void طباعةكلالفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void بحثToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void خروجمنالرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void اضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_pro_Form f = new add_pro_Form();
            f.ShowDialog();

        }

        private void تعديلمنتجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit_item f = new Edit_item();
            f.ShowDialog();
        }

        private void حذفصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_item_cat_form f = new delete_item_cat_form();
            f.ShowDialog();
        }

        private void حذفجميعالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_all_cat_form f = new delete_all_cat_form();
            f.ShowDialog();
        }

        private void اصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةصنففرعيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            branch_subject f = new branch_subject();
            f.ShowDialog();
        }

        private void عرضوبحثالاصنافالفرعيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            all_sub_form f = new all_sub_form();
            f.ShowDialog();
        }

        private void عرضالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            all_product f = new all_product();
            f.ShowDialog();
        }

        private void تعديلمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_form f = new Edit_form();
            f.ShowDialog();

        }

        private void حذفكلالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAll_pro_from f = new DeleteAll_pro_from();
            f.ShowDialog();
        }

        private void اضافةفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_form f = new order_form();
            f.ShowDialog();
        }

        private void عرضفواتيراخراسبوعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetingBill f = new SetingBill();
            f.ShowDialog();

        }

        private void عرضفواتير24ساعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastBill24 f = new lastBill24();
            f.ShowDialog();

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            ExpirdDate f = new ExpirdDate();
            f.ShowDialog();

        }

        private void IconPictureBox1_Click(object sender, EventArgs e)
        {
            ExpirdDate f = new ExpirdDate();
            f.ShowDialog();
        }

        private void IconPictureBox6_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox6.BackColor = Color.FromArgb(10, 50, 50, 58);  //alpha,red, green, blue
            iconPictureBox6.ForeColor = Color.Red;
        }

        private void IconPictureBox6_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox6.BackColor = Color.White;
            iconPictureBox6.ForeColor = Color.Navy;

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IconPictureBox4_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox4.BackColor = Color.FromArgb(10, 50, 50, 58);  //alpha,red, green, blue
            iconPictureBox4.ForeColor = Color.Red;
        }

        private void IconPictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void IconPictureBox5_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox5.BackColor = Color.FromArgb(10, 50, 50, 58);  //alpha,red, green, blue
            iconPictureBox5.ForeColor = Color.Red;
        }

        private void IconPictureBox9_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox9.BackColor = Color.FromArgb(10, 50, 50, 58);  //alpha,red, green, blue
            iconPictureBox9.ForeColor = Color.Red;
        }

        private void IconPictureBox7_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox7.BackColor = Color.White;
            iconPictureBox7.ForeColor = Color.Navy;
        }

        private void IconPictureBox7_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox7.BackColor = Color.FromArgb(10, 50, 50, 58);  //alpha,red, green, blue
            iconPictureBox7.ForeColor = Color.Red;
        }

        private void IconPictureBox8_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox8.BackColor = Color.FromArgb(10, 50, 50, 58);  //alpha,red, green, blue
            iconPictureBox8.ForeColor = Color.Red;
        }

        private void IconPictureBox1_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.FromArgb(10, 50, 50, 58);  //alpha,red, green, blue
            iconPictureBox1.ForeColor = Color.Red;
        }

        private void IconPictureBox2_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox2.BackColor = Color.FromArgb(10, 50, 50, 58);  //alpha,red, green, blue
            iconPictureBox2.ForeColor = Color.Red;
        }

        private void IconPictureBox2_MouseHover_1(object sender, EventArgs e)
        {
            iconPictureBox2.BackColor = Color.FromArgb(10, 50, 50, 58);  //alpha,red, green, blue
            iconPictureBox2.ForeColor = Color.Red;
        }

        private void IconPictureBox3_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox3.BackColor = Color.FromArgb(10, 50, 50, 58);  //alpha,red, green, blue
            iconPictureBox3.ForeColor = Color.Red;
        }

        private void IconPictureBox4_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox4.BackColor = Color.White;
            iconPictureBox4.ForeColor = Color.Navy;
        }

        private void IconPictureBox5_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox5.BackColor = Color.White;
            iconPictureBox5.ForeColor = Color.Navy;
        }

        private void IconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.Navy;
        }

        private void IconPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.Navy;
        }

        private void IconPictureBox3_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox3.BackColor = Color.White;
            iconPictureBox3.ForeColor = Color.Navy;
        }

        private void IconPictureBox8_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox8.BackColor = Color.White;
            iconPictureBox8.ForeColor = Color.Navy;
        }

        private void IconPictureBox9_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox9.BackColor = Color.White;
            iconPictureBox9.ForeColor = Color.Navy;
        }

        private void IconPictureBox2_Click(object sender, EventArgs e)
        {
            Store_F f = new Store_F();
            f.ShowDialog();
        }

        private void عملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Clients.sas))
            {
                panel2.Controls.Add(Clients.sas);
                Clients.sas.Dock = DockStyle.Fill;
                Clients.sas.BringToFront();

            }
            else
                Clients.sas.BringToFront();
        }

        private void الفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Branch.sas))
            {
                panel2.Controls.Add(Branch.sas);
                Branch.sas.Dock = DockStyle.Fill;
                Branch.sas.BringToFront();

            }
            else
                Branch.sas.BringToFront();
        }

        private void شركاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Company.sas))
            {
                panel2.Controls.Add(Company.sas);
                Company.sas.Dock = DockStyle.Fill;
                Company.sas.BringToFront();

            }
            else
                Company.sas.BringToFront();

        }

        private void موظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(User.sas))
            {
                panel2.Controls.Add(User.sas);
                User.sas.Dock = DockStyle.Fill;
                User.sas.BringToFront();

            }
            else
                User.sas.BringToFront();
        }

        private void بحثToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            search_f f = new search_f();
            f.ShowDialog();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            order_form f = new order_form();
            f.ShowDialog();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            Add_Client f = new Add_Client();
            f.ShowDialog();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Add_User f = new Add_User();
            f.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Add_Branch f = new Add_Branch();
            f.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Add_Company f = new Add_Company();
            f.ShowDialog();
        }

        private void عنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("شركة لتصميم و برمجة البرامج تسك توب . وتصميم المواقع الاكترونية مع الربط مع برامج وموبيل اب لاكيشن للتواصل معنا رقم:01234567890 ","من نحن",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataContext db = new DataContext();
                int a = Convert.ToInt32(Program.Type_User_by_login_BYID);
                Depature brunch_Item = (from cl in db.Depatures
                                        where cl.Id ==a
                                        select cl).FirstOrDefault();
                brunch_Item.FinshedDate = DateTime.Now;
                db.Entry(brunch_Item).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {

                this.Close();
            }

            this.Close();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();
        }

        private void IconPictureBox3_Click(object sender, EventArgs e)
        {
            Search_User f = new Search_User();
            f.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FrmDistribution f = new FrmDistribution();
            f.ShowDialog();
        }

        private void IconPictureBox10_Click(object sender, EventArgs e)
        {
            Edit_form f = new Edit_form();
            f.ShowDialog();
        }

        private void IconPictureBox11_Click(object sender, EventArgs e)
        {
            add_pro_Form f = new add_pro_Form();
            f.ShowDialog();
        }
    }
}
