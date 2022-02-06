namespace WindowsFormsApp1.Form_product
{
    partial class add_pro_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_cat = new System.Windows.Forms.ComboBox();
            this.tx_earn_money = new System.Windows.Forms.TextBox();
            this.tx_date = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_comment = new System.Windows.Forms.TextBox();
            this.tx_sub = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_expeie = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.tx_price_one = new System.Windows.Forms.TextBox();
            this.tx_price_one_oraginal = new System.Windows.Forms.TextBox();
            this.tx_qount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_cat
            // 
            this.tx_cat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tx_cat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tx_cat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cat.FormattingEnabled = true;
            this.tx_cat.Location = new System.Drawing.Point(12, 22);
            this.tx_cat.Name = "tx_cat";
            this.tx_cat.Size = new System.Drawing.Size(424, 26);
            this.tx_cat.TabIndex = 43;
            this.tx_cat.SelectedIndexChanged += new System.EventHandler(this.Tx_cat_SelectedIndexChanged);
            // 
            // tx_earn_money
            // 
            this.tx_earn_money.Enabled = false;
            this.tx_earn_money.Location = new System.Drawing.Point(610, 502);
            this.tx_earn_money.Multiline = true;
            this.tx_earn_money.Name = "tx_earn_money";
            this.tx_earn_money.Size = new System.Drawing.Size(316, 28);
            this.tx_earn_money.TabIndex = 42;
            // 
            // tx_date
            // 
            this.tx_date.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_date.Location = new System.Drawing.Point(598, 233);
            this.tx_date.Name = "tx_date";
            this.tx_date.Size = new System.Drawing.Size(319, 26);
            this.tx_date.TabIndex = 39;
            this.tx_date.ValueChanged += new System.EventHandler(this.Tx_date_ValueChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(130, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(822, 2);
            this.label12.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(429, 15);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(177, 37);
            this.label11.TabIndex = 36;
            this.label11.Text = "صنف المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(937, 502);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(139, 29);
            this.label10.TabIndex = 35;
            this.label10.Text = "العائد";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(918, 430);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(178, 37);
            this.label8.TabIndex = 34;
            this.label8.Text = "سعر القطعة جملة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(914, 158);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(179, 37);
            this.label6.TabIndex = 33;
            this.label6.Text = "الكمية";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(919, 226);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(179, 37);
            this.label7.TabIndex = 32;
            this.label7.Text = "تاريخ تخزينها";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(916, 362);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(178, 37);
            this.label5.TabIndex = 31;
            this.label5.Text = "سعر القطعة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(916, 90);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(177, 37);
            this.label4.TabIndex = 30;
            this.label4.Text = "اسم المنتج";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(9, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(555, 31);
            this.button2.TabIndex = 29;
            this.button2.Text = "صورة للمنتج";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(9, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 31);
            this.button3.TabIndex = 46;
            this.button3.Text = "عرض جميع البيانات المسجلة";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(159, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 31);
            this.button1.TabIndex = 45;
            this.button1.Text = "اضافة منتج جديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(428, 97);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 47;
            this.label1.Text = "تفاصيل اخري";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tx_comment
            // 
            this.tx_comment.Location = new System.Drawing.Point(12, 90);
            this.tx_comment.Multiline = true;
            this.tx_comment.Name = "tx_comment";
            this.tx_comment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tx_comment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_comment.Size = new System.Drawing.Size(424, 97);
            this.tx_comment.TabIndex = 48;
            this.tx_comment.TextChanged += new System.EventHandler(this.Tx_comment_TextChanged);
            // 
            // tx_sub
            // 
            this.tx_sub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tx_sub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tx_sub.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_sub.FormattingEnabled = true;
            this.tx_sub.Location = new System.Drawing.Point(598, 29);
            this.tx_sub.Name = "tx_sub";
            this.tx_sub.Size = new System.Drawing.Size(319, 26);
            this.tx_sub.TabIndex = 52;
            this.tx_sub.SelectedIndexChanged += new System.EventHandler(this.Tx_sub_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(917, 22);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 51;
            this.label3.Text = "الصنف الفرعي";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // tx_expeie
            // 
            this.tx_expeie.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_expeie.Location = new System.Drawing.Point(598, 301);
            this.tx_expeie.Name = "tx_expeie";
            this.tx_expeie.Size = new System.Drawing.Size(319, 26);
            this.tx_expeie.TabIndex = 54;
            this.tx_expeie.ValueChanged += new System.EventHandler(this.Tx_expeie_ValueChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(919, 294);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(179, 37);
            this.label9.TabIndex = 53;
            this.label9.Text = "تاريخ انتهاء الصلاحية";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // tx_name
            // 
            this.tx_name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_name.Location = new System.Drawing.Point(596, 91);
            this.tx_name.Multiline = true;
            this.tx_name.Name = "tx_name";
            this.tx_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tx_name.Size = new System.Drawing.Size(321, 29);
            this.tx_name.TabIndex = 55;
            this.tx_name.TextChanged += new System.EventHandler(this.Tx_name_TextChanged);
            // 
            // tx_price_one
            // 
            this.tx_price_one.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_price_one.Location = new System.Drawing.Point(598, 362);
            this.tx_price_one.Multiline = true;
            this.tx_price_one.Name = "tx_price_one";
            this.tx_price_one.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tx_price_one.Size = new System.Drawing.Size(321, 29);
            this.tx_price_one.TabIndex = 56;
            this.tx_price_one.TextChanged += new System.EventHandler(this.Tx_price_one_TextChanged);
            this.tx_price_one.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tx_qount_KeyPress);
            // 
            // tx_price_one_oraginal
            // 
            this.tx_price_one_oraginal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_price_one_oraginal.Location = new System.Drawing.Point(598, 437);
            this.tx_price_one_oraginal.Multiline = true;
            this.tx_price_one_oraginal.Name = "tx_price_one_oraginal";
            this.tx_price_one_oraginal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tx_price_one_oraginal.Size = new System.Drawing.Size(321, 29);
            this.tx_price_one_oraginal.TabIndex = 57;
            this.tx_price_one_oraginal.TextChanged += new System.EventHandler(this.Tx_price_one_oraginal_TextChanged);
            this.tx_price_one_oraginal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tx_qount_KeyPress);
            // 
            // tx_qount
            // 
            this.tx_qount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_qount.Location = new System.Drawing.Point(598, 166);
            this.tx_qount.Multiline = true;
            this.tx_qount.Name = "tx_qount";
            this.tx_qount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tx_qount.Size = new System.Drawing.Size(321, 29);
            this.tx_qount.TabIndex = 58;
            this.tx_qount.TextChanged += new System.EventHandler(this.Tx_qount_TextChanged);
            this.tx_qount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tx_qount_KeyPress);
            // 
            // add_pro_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 545);
            this.Controls.Add(this.tx_qount);
            this.Controls.Add(this.tx_price_one_oraginal);
            this.Controls.Add(this.tx_price_one);
            this.Controls.Add(this.tx_name);
            this.Controls.Add(this.tx_expeie);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tx_sub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_comment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_cat);
            this.Controls.Add(this.tx_earn_money);
            this.Controls.Add(this.tx_date);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "add_pro_Form";
            this.RightToLeftLayout = true;
            this.Text = "المنتجات";
            this.Load += new System.EventHandler(this.Add_pro_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox tx_cat;
        private System.Windows.Forms.TextBox tx_earn_money;
        private System.Windows.Forms.DateTimePicker tx_date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_comment;
        private System.Windows.Forms.ComboBox tx_sub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tx_expeie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.TextBox tx_price_one;
        private System.Windows.Forms.TextBox tx_price_one_oraginal;
        private System.Windows.Forms.TextBox tx_qount;
    }
}