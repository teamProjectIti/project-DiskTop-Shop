namespace WindowsFormsApp1.offers
{
    partial class FrmOffers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOffers));
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEndOffer = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCreateOffer = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCodeCobone = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxProduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(103, 20);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(655, 37);
            this.comboBoxProduct.TabIndex = 23;
            // 
            // dateTimePickerEndOffer
            // 
            this.dateTimePickerEndOffer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerEndOffer.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimePickerEndOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.dateTimePickerEndOffer.Location = new System.Drawing.Point(103, 398);
            this.dateTimePickerEndOffer.Name = "dateTimePickerEndOffer";
            this.dateTimePickerEndOffer.Size = new System.Drawing.Size(655, 36);
            this.dateTimePickerEndOffer.TabIndex = 22;
            // 
            // dateTimePickerCreateOffer
            // 
            this.dateTimePickerCreateOffer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerCreateOffer.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimePickerCreateOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.dateTimePickerCreateOffer.Location = new System.Drawing.Point(103, 337);
            this.dateTimePickerCreateOffer.Name = "dateTimePickerCreateOffer";
            this.dateTimePickerCreateOffer.Size = new System.Drawing.Size(655, 36);
            this.dateTimePickerCreateOffer.TabIndex = 21;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(103, 275);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(655, 37);
            this.comboBoxUser.TabIndex = 20;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCompany.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(103, 213);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(655, 37);
            this.comboBoxCompany.TabIndex = 19;
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDetails.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtDetails.Location = new System.Drawing.Point(103, 145);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(655, 43);
            this.txtDetails.TabIndex = 18;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtCode.Location = new System.Drawing.Point(103, 82);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(655, 38);
            this.txtCode.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(61, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(697, 81);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اعدادات";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(4, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(761, 2);
            this.label5.TabIndex = 44;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__5_;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(464, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(229, 43);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(232, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(236, 43);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(6, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(231, 43);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Blue;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.HandPointLeft;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Blue;
            this.iconPictureBox2.IconSize = 45;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 11);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(62, 45);
            this.iconPictureBox2.TabIndex = 24;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.IconPictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Controls.Add(this.lblCodeCobone);
            this.panel1.Controls.Add(this.lblDetails);
            this.panel1.Controls.Add(this.lblCompany);
            this.panel1.Controls.Add(this.lblCreateDate);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Location = new System.Drawing.Point(764, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 529);
            this.panel1.TabIndex = 11;
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProduct.Location = new System.Drawing.Point(14, 20);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(99, 29);
            this.lblProduct.TabIndex = 25;
            this.lblProduct.Tag = "";
            this.lblProduct.Text = "اسم المنتج";
            // 
            // lblCodeCobone
            // 
            this.lblCodeCobone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodeCobone.AutoSize = true;
            this.lblCodeCobone.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeCobone.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeCobone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodeCobone.Location = new System.Drawing.Point(14, 84);
            this.lblCodeCobone.Name = "lblCodeCobone";
            this.lblCodeCobone.Size = new System.Drawing.Size(107, 29);
            this.lblCodeCobone.TabIndex = 24;
            this.lblCodeCobone.Text = "كود العرض";
            // 
            // lblDetails
            // 
            this.lblDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDetails.Location = new System.Drawing.Point(14, 148);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(83, 29);
            this.lblDetails.TabIndex = 23;
            this.lblDetails.Text = "التفاصيل";
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCompany.Location = new System.Drawing.Point(14, 212);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(70, 29);
            this.lblCompany.TabIndex = 22;
            this.lblCompany.Text = "الشركه";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateDate.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreateDate.Location = new System.Drawing.Point(14, 340);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(117, 29);
            this.lblCreateDate.TabIndex = 21;
            this.lblCreateDate.Text = "بدايه العرض";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(14, 276);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 29);
            this.lblUser.TabIndex = 20;
            this.lblUser.Text = "المستخدم";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndDate.Location = new System.Drawing.Point(14, 404);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(119, 29);
            this.lblEndDate.TabIndex = 19;
            this.lblEndDate.Text = "نهايه العرض";
            // 
            // FrmOffers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 524);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.dateTimePickerEndOffer);
            this.Controls.Add(this.dateTimePickerCreateOffer);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.panel1);
            this.Name = "FrmOffers";
            this.Text = "العروض والخصومات";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCodeCobone;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndOffer;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreateOffer;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtCode;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
    }
}