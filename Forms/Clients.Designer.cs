
namespace WindowsFormsApp1.Forms
{
    partial class Clients
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
            this.btnSearch_Client = new System.Windows.Forms.Button();
            this.btnUpdate_Client = new System.Windows.Forms.Button();
            this.btnAdd_Client = new System.Windows.Forms.Button();
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
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Clients_icon_png2;
            this.pictureBox1.Location = new System.Drawing.Point(70, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch_Client
            // 
            this.btnSearch_Client.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch_Client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_Client.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_Client.ForeColor = System.Drawing.Color.Black;
            this.btnSearch_Client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Client.Location = new System.Drawing.Point(449, 346);
            this.btnSearch_Client.Name = "btnSearch_Client";
            this.btnSearch_Client.Size = new System.Drawing.Size(282, 59);
            this.btnSearch_Client.TabIndex = 7;
            this.btnSearch_Client.Text = "بحث عن بيانات عميل معين";
            this.btnSearch_Client.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch_Client.UseVisualStyleBackColor = false;
            this.btnSearch_Client.Click += new System.EventHandler(this.btnSearch_Client_Click);
            // 
            // btnUpdate_Client
            // 
            this.btnUpdate_Client.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate_Client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_Client.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Client.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate_Client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate_Client.Location = new System.Drawing.Point(449, 218);
            this.btnUpdate_Client.Name = "btnUpdate_Client";
            this.btnUpdate_Client.Size = new System.Drawing.Size(282, 59);
            this.btnUpdate_Client.TabIndex = 6;
            this.btnUpdate_Client.Text = "تعديل / حذف عميل";
            this.btnUpdate_Client.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate_Client.UseVisualStyleBackColor = false;
            this.btnUpdate_Client.Click += new System.EventHandler(this.btnUpdate_Client_Click);
            // 
            // btnAdd_Client
            // 
            this.btnAdd_Client.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd_Client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Client.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Client.ForeColor = System.Drawing.Color.Black;
            this.btnAdd_Client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd_Client.Location = new System.Drawing.Point(449, 80);
            this.btnAdd_Client.Name = "btnAdd_Client";
            this.btnAdd_Client.Size = new System.Drawing.Size(282, 59);
            this.btnAdd_Client.TabIndex = 5;
            this.btnAdd_Client.Text = "اضافة عميل جديد";
            this.btnAdd_Client.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd_Client.UseVisualStyleBackColor = false;
            this.btnAdd_Client.Click += new System.EventHandler(this.btnAdd_Client_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Green;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Green;
            this.iconPictureBox2.IconSize = 65;
            this.iconPictureBox2.Location = new System.Drawing.Point(458, 82);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(64, 56);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox2.TabIndex = 10;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconPictureBox3.IconSize = 65;
            this.iconPictureBox3.Location = new System.Drawing.Point(458, 220);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(64, 56);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox3.TabIndex = 11;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox4.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPictureBox4.IconSize = 65;
            this.iconPictureBox4.Location = new System.Drawing.Point(455, 347);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(64, 56);
            this.iconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox4.TabIndex = 12;
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
            this.iconPictureBox1.TabIndex = 13;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch_Client);
            this.Controls.Add(this.btnUpdate_Client);
            this.Controls.Add(this.btnAdd_Client);
            this.Name = "Clients";
            this.Size = new System.Drawing.Size(800, 485);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch_Client;
        private System.Windows.Forms.Button btnUpdate_Client;
        private System.Windows.Forms.Button btnAdd_Client;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
