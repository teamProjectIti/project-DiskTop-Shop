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
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.form_Subject
{
    public partial class branch_subject : Form
    {
        DataContext db = new DataContext();
        public branch_subject()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Branch_subject_Load(object sender, EventArgs e)
        {
            data();
            combox();
        }
        void combox()
        {
            //var value = db.Sub_Cat.Select(x => x.cat.Name_cat).ToString();
            comboBox1.DataSource = db.cats.ToList();
            comboBox1.ValueMember = "ID_CAt";
            comboBox1.DisplayMember = "Name_cat";
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            clear();
            combox();
            data();
        }
        void clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }
        void data()
        {
            //dataGridView1.DataSource = db.Sub_Cat.ToList();
            dataGridView1.DataSource = db.Sub_Cat.Select(x => new
            {
                الرقم=x.ID_CAt,
                رقم_الفرع=x.ID_sub,
                الاسم=x.Name_Sub,
                الاسم_الفرعي=x.cat.Name_cat,
                الوصف=x.Desc
            }).ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "حدد نوع الصنف")
            {
                try
                {
                    Sub_Cat brunch_Item = (from cl in db.Sub_Cat
                                           where cl.ID_sub == brush_ID
                                           select cl).FirstOrDefault();
                    brunch_Item.Name_Sub = textBox1.Text;
                    brunch_Item.Desc = textBox2.Text;
                    brunch_Item.Other_Details = textBox3.Text;
                    brunch_Item.ID_CAt = Convert.ToInt32(comboBox1.SelectedValue);
                    db.Entry(brunch_Item).State = EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("تم تعديل البيانات بنجاح ", "رسالة تنفيذ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    clear();
                    combox();
                    data();
                }
                catch (Exception)
                {
                    MessageBox.Show("عفوا حدث خطاء في تعديل البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("يجب تحديد نوع الصنف التي تنتمي لها","تنبية ",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                combox();
                data();
                clear();
                
            }
        }
        int brush_ID;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_com = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            brush_ID = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = "حدد نوع الصنف";

            ////الرقم = x.ID_CAt,
            ////    رقم_الفرع = x.ID_sub,
            ////    الاسم = x.Name_Sub,
            ////    الاسم_الفرعي = x.cat.Name_cat,
            ////    الوصف = x.Desc
            //Sub_Cat brunch_Item = (from cl in db.Sub_Cat
            //                       where cl.ID_sub == brush_ID
            //                       select cl).FirstOrDefault();
            //brunch_Item.Name_Sub = textBox1.Text;
            //brunch_Item.Desc = textBox2.Text;
            //brunch_Item.Other_Details = textBox3.Text;
            //brunch_Item.ID_CAt = Convert.ToInt32(comboBox1.SelectedValue);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var a = db.cats.Find(Convert.ToInt32(comboBox1.SelectedValue));
            if (a.ID_CAt != 0)
            {

                List<Sub_Cat> c = new List<Sub_Cat>();
                try
                {
                    if (textBox1.Text != string.Empty && textBox2.Text != "" && comboBox1.Text!="")
                    {
                        c.Add(new Sub_Cat
                        {
                            Name_Sub = textBox1.Text,
                            Desc = textBox2.Text,
                            Other_Details = textBox3.Text,
                            ID_CAt = Convert.ToInt32(comboBox1.SelectedValue)
                        });
                        foreach (var item in c.Take(1))
                        {
                            db.Sub_Cat.Add(item);
                            db.SaveChanges();
                        }
                        clear();
                        combox();
                        data();
                        MessageBox.Show("تم عملية التسجيل بنجاح", "رسالة تاكيد نجاح التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    else
                    {
                        MessageBox.Show("الرجاء التاكد من ادخال بيانات", "رسالة تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    }
                }
                catch (Exception w)
                {
                    MessageBox.Show(w.Message, "رسالة تاكيد نجاح التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            else
            {
                data();
                combox();
                clear();
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد حذف هذا العنصر","قائمة تاكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                try
                {
                    var item = db.Sub_Cat.Find(brush_ID);
                    db.Sub_Cat.Remove(item);
                    db.SaveChanges();
                    data();
                    clear();
                    combox();
                    MessageBox.Show("تم عملية حذف الصنف بنجاح", "رسالة مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                catch (Exception)
                {
                    MessageBox.Show("عفوا حدث خطاء في حذف البيانات يرجي المحاولة مرة اخري", "رساله من قاعدى البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Sub_Cat.Where(x => x.Name_Sub.Contains(tx_search.Text) 
            || x.Other_Details.Contains(tx_search.Text) ||
            x.Desc.Contains(tx_search.Text)).AsQueryable().ToList();
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Tx_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }
    }
}
