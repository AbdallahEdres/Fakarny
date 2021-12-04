
namespace Fakarny
{
    partial class sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up));
            this.sign_but = new System.Windows.Forms.Button();
            this.pasword_labl = new System.Windows.Forms.Label();
            this.username_labl = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sign_but
            // 
            this.sign_but.BackColor = System.Drawing.Color.Transparent;
            this.sign_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_but.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 36F, System.Drawing.FontStyle.Bold);
            this.sign_but.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sign_but.Location = new System.Drawing.Point(190, 623);
            this.sign_but.Name = "sign_but";
            this.sign_but.Size = new System.Drawing.Size(149, 56);
            this.sign_but.TabIndex = 21;
            this.sign_but.Text = "Sign Up";
            this.sign_but.UseVisualStyleBackColor = false;
            this.sign_but.Click += new System.EventHandler(this.sign_but_Click);
            // 
            // pasword_labl
            // 
            this.pasword_labl.AutoSize = true;
            this.pasword_labl.BackColor = System.Drawing.Color.Transparent;
            this.pasword_labl.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasword_labl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pasword_labl.Location = new System.Drawing.Point(206, 474);
            this.pasword_labl.Name = "pasword_labl";
            this.pasword_labl.Size = new System.Drawing.Size(118, 48);
            this.pasword_labl.TabIndex = 16;
            this.pasword_labl.Text = "Passwor";
            // 
            // username_labl
            // 
            this.username_labl.AutoSize = true;
            this.username_labl.BackColor = System.Drawing.Color.Transparent;
            this.username_labl.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_labl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username_labl.Location = new System.Drawing.Point(182, 339);
            this.username_labl.Name = "username_labl";
            this.username_labl.Size = new System.Drawing.Size(169, 48);
            this.username_labl.TabIndex = 15;
            this.username_labl.Text = "User name";
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txt.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 36F, System.Drawing.FontStyle.Bold);
            this.password_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_txt.Location = new System.Drawing.Point(62, 533);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '☻';
            this.password_txt.Size = new System.Drawing.Size(396, 44);
            this.password_txt.TabIndex = 14;
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txt.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 36F, System.Drawing.FontStyle.Bold);
            this.username_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username_txt.Location = new System.Drawing.Point(62, 405);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(396, 44);
            this.username_txt.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(516, 705);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sign_but);
            this.Controls.Add(this.pasword_labl);
            this.Controls.Add(this.username_labl);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sign_up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sign_but;
        private System.Windows.Forms.Label pasword_labl;
        private System.Windows.Forms.Label username_labl;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}