namespace WindowsFormsApp1.Departure
{
    partial class Departure_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departure_form));
            this.lblDepature = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBackToList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblFinshedDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepature
            // 
            this.lblDepature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepature.AutoSize = true;
            this.lblDepature.BackColor = System.Drawing.Color.Transparent;
            this.lblDepature.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDepature.Location = new System.Drawing.Point(297, 3);
            this.lblDepature.Name = "lblDepature";
            this.lblDepature.Size = new System.Drawing.Size(349, 42);
            this.lblDepature.TabIndex = 24;
            this.lblDepature.Text = "مواعيد الحضور/ الانصراف";
            // 
            // txtOther
            // 
            this.txtOther.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtOther.Location = new System.Drawing.Point(91, 349);
            this.txtOther.Name = "txtOther";
            this.txtOther.ReadOnly = true;
            this.txtOther.Size = new System.Drawing.Size(623, 36);
            this.txtOther.TabIndex = 33;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.dateTimePickerStart.Location = new System.Drawing.Point(91, 149);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(623, 36);
            this.dateTimePickerStart.TabIndex = 29;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.dateTimePickerEnd.Location = new System.Drawing.Point(91, 214);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(623, 36);
            this.dateTimePickerEnd.TabIndex = 28;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "اختر حالة الموظف",
            "نشط",
            "غير نشط"});
            this.comboBoxStatus.Location = new System.Drawing.Point(91, 278);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(623, 37);
            this.comboBoxStatus.TabIndex = 27;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(91, 83);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(623, 37);
            this.comboBoxUser.TabIndex = 26;
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
            this.btnSave.Location = new System.Drawing.Point(498, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(233, 43);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1, 435);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(233, 43);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(240, 435);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(233, 43);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnBackToList
            // 
            this.btnBackToList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackToList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackToList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackToList.BackgroundImage")));
            this.btnBackToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnBackToList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackToList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToList.Location = new System.Drawing.Point(1, 4);
            this.btnBackToList.Name = "btnBackToList";
            this.btnBackToList.Size = new System.Drawing.Size(233, 43);
            this.btnBackToList.TabIndex = 25;
            this.btnBackToList.Text = "العودة الى القائمة";
            this.btnBackToList.UseVisualStyleBackColor = false;
            this.btnBackToList.Click += new System.EventHandler(this.BtnBackToList_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblOther);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.lblFinshedDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Location = new System.Drawing.Point(737, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 489);
            this.panel1.TabIndex = 0;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.BackColor = System.Drawing.Color.Transparent;
            this.lblOther.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblOther.Location = new System.Drawing.Point(46, 350);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(75, 36);
            this.lblOther.TabIndex = 10;
            this.lblOther.Text = "اخرى";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblState.Location = new System.Drawing.Point(47, 280);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(72, 36);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "الحاله";
            // 
            // lblFinshedDate
            // 
            this.lblFinshedDate.AutoSize = true;
            this.lblFinshedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblFinshedDate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinshedDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFinshedDate.Location = new System.Drawing.Point(31, 215);
            this.lblFinshedDate.Name = "lblFinshedDate";
            this.lblFinshedDate.Size = new System.Drawing.Size(105, 36);
            this.lblFinshedDate.TabIndex = 8;
            this.lblFinshedDate.Text = "انصراف";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStartDate.Location = new System.Drawing.Point(39, 150);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(89, 36);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "حضور";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUser.Location = new System.Drawing.Point(30, 85);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(106, 36);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "المستخدم";
            // 
            // Departure_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 490);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBackToList);
            this.Controls.Add(this.lblDepature);
            this.Controls.Add(this.panel1);
            this.Name = "Departure_form";
            this.Text = "حضور وانصراف الموظفين";
            this.Load += new System.EventHandler(this.Departure_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblFinshedDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnBackToList;
        private System.Windows.Forms.Label lblDepature;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}