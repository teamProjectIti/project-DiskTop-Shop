
namespace WindowsFormsApp1.Forms
{
    partial class Company
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch_Company = new System.Windows.Forms.Button();
            this.btnUpdate_Company = new System.Windows.Forms.Button();
            this.btnAdd_Company = new System.Windows.Forms.Button();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.index;
            this.pictureBox1.Location = new System.Drawing.Point(66, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch_Company
            // 
            this.btnSearch_Company.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch_Company.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch_Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_Company.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_Company.ForeColor = System.Drawing.Color.Black;
            this.btnSearch_Company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Company.Location = new System.Drawing.Point(439, 339);
            this.btnSearch_Company.Name = "btnSearch_Company";
            this.btnSearch_Company.Size = new System.Drawing.Size(295, 59);
            this.btnSearch_Company.TabIndex = 8;
            this.btnSearch_Company.Text = "بحث عن بيانات شركة";
            this.btnSearch_Company.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch_Company.UseVisualStyleBackColor = false;
            this.btnSearch_Company.Click += new System.EventHandler(this.btnSearch_Company_Click);
            // 
            // btnUpdate_Company
            // 
            this.btnUpdate_Company.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate_Company.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate_Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_Company.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Company.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate_Company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate_Company.Location = new System.Drawing.Point(439, 215);
            this.btnUpdate_Company.Name = "btnUpdate_Company";
            this.btnUpdate_Company.Size = new System.Drawing.Size(295, 59);
            this.btnUpdate_Company.TabIndex = 7;
            this.btnUpdate_Company.Text = "تعديل / حذف شركة ";
            this.btnUpdate_Company.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate_Company.UseVisualStyleBackColor = false;
            this.btnUpdate_Company.Click += new System.EventHandler(this.btnUpdate_Company_Click);
            // 
            // btnAdd_Company
            // 
            this.btnAdd_Company.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd_Company.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd_Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Company.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Company.ForeColor = System.Drawing.Color.Black;
            this.btnAdd_Company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd_Company.Location = new System.Drawing.Point(439, 86);
            this.btnAdd_Company.Name = "btnAdd_Company";
            this.btnAdd_Company.Size = new System.Drawing.Size(295, 59);
            this.btnAdd_Company.TabIndex = 6;
            this.btnAdd_Company.Text = "اضافة شركة جديدة";
            this.btnAdd_Company.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd_Company.UseVisualStyleBackColor = false;
            this.btnAdd_Company.Click += new System.EventHandler(this.btnAdd_Company_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Green;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Green;
            this.iconPictureBox2.IconSize = 65;
            this.iconPictureBox2.Location = new System.Drawing.Point(450, 87);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(64, 56);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox2.TabIndex = 11;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconPictureBox3.IconSize = 65;
            this.iconPictureBox3.Location = new System.Drawing.Point(450, 217);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(64, 56);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox3.TabIndex = 12;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox4.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPictureBox4.IconSize = 65;
            this.iconPictureBox4.Location = new System.Drawing.Point(450, 340);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(64, 56);
            this.iconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox4.TabIndex = 13;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconSize = 60;
            this.iconPictureBox1.Location = new System.Drawing.Point(768, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch_Company);
            this.Controls.Add(this.btnUpdate_Company);
            this.Controls.Add(this.btnAdd_Company);
            this.Name = "Company";
            this.Size = new System.Drawing.Size(800, 485);
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch_Company;
        private System.Windows.Forms.Button btnUpdate_Company;
        private System.Windows.Forms.Button btnAdd_Company;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
