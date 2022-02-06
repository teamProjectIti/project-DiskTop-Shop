
namespace WindowsFormsApp1.Forms
{
    partial class User
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
            this.btnSearch_User = new System.Windows.Forms.Button();
            this.btnUpdate_User = new System.Windows.Forms.Button();
            this.btnAdd_User = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            // btnSearch_User
            // 
            this.btnSearch_User.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_User.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_User.ForeColor = System.Drawing.Color.Black;
            this.btnSearch_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_User.Location = new System.Drawing.Point(421, 350);
            this.btnSearch_User.Name = "btnSearch_User";
            this.btnSearch_User.Size = new System.Drawing.Size(297, 59);
            this.btnSearch_User.TabIndex = 8;
            this.btnSearch_User.Text = "بحث عن بيانات مستخدم معين";
            this.btnSearch_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch_User.UseVisualStyleBackColor = false;
            this.btnSearch_User.Click += new System.EventHandler(this.btnSearch_User_Click);
            // 
            // btnUpdate_User
            // 
            this.btnUpdate_User.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_User.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_User.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate_User.Location = new System.Drawing.Point(421, 215);
            this.btnUpdate_User.Name = "btnUpdate_User";
            this.btnUpdate_User.Size = new System.Drawing.Size(297, 59);
            this.btnUpdate_User.TabIndex = 7;
            this.btnUpdate_User.Text = "تعديل / حذف بيانات مستخدم\r\n";
            this.btnUpdate_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate_User.UseVisualStyleBackColor = false;
            this.btnUpdate_User.Click += new System.EventHandler(this.btnUpdate_User_Click);
            // 
            // btnAdd_User
            // 
            this.btnAdd_User.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_User.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_User.ForeColor = System.Drawing.Color.Black;
            this.btnAdd_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd_User.Location = new System.Drawing.Point(421, 76);
            this.btnAdd_User.Name = "btnAdd_User";
            this.btnAdd_User.Size = new System.Drawing.Size(297, 59);
            this.btnAdd_User.TabIndex = 6;
            this.btnAdd_User.Text = "اضافة مستخدم جديد بصلاحيات";
            this.btnAdd_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd_User.UseVisualStyleBackColor = false;
            this.btnAdd_User.Click += new System.EventHandler(this.btnAdd_User_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.vote_1;
            this.pictureBox1.Location = new System.Drawing.Point(82, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Green;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Green;
            this.iconPictureBox2.IconSize = 65;
            this.iconPictureBox2.Location = new System.Drawing.Point(432, 78);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(64, 56);
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
            this.iconPictureBox3.Location = new System.Drawing.Point(432, 217);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(64, 56);
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
            this.iconPictureBox4.Location = new System.Drawing.Point(432, 351);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(64, 56);
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
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch_User);
            this.Controls.Add(this.btnUpdate_User);
            this.Controls.Add(this.btnAdd_User);
            this.Name = "User";
            this.Size = new System.Drawing.Size(800, 485);
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch_User;
        private System.Windows.Forms.Button btnUpdate_User;
        private System.Windows.Forms.Button btnAdd_User;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
