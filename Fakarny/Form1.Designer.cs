
namespace Fakarny
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sign_up_lnkdlabl = new System.Windows.Forms.LinkLabel();
            this.login_but = new System.Windows.Forms.Button();
            this.pasword_labl = new System.Windows.Forms.Label();
            this.username_labl = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rmmbr_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sign_up_lnkdlabl
            // 
            this.sign_up_lnkdlabl.AutoSize = true;
            this.sign_up_lnkdlabl.BackColor = System.Drawing.Color.Transparent;
            this.sign_up_lnkdlabl.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up_lnkdlabl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.sign_up_lnkdlabl.Location = new System.Drawing.Point(379, 650);
            this.sign_up_lnkdlabl.Name = "sign_up_lnkdlabl";
            this.sign_up_lnkdlabl.Size = new System.Drawing.Size(125, 35);
            this.sign_up_lnkdlabl.TabIndex = 11;
            this.sign_up_lnkdlabl.TabStop = true;
            this.sign_up_lnkdlabl.Text = "Sign UP?";
            this.sign_up_lnkdlabl.VisitedLinkColor = System.Drawing.Color.Black;
            this.sign_up_lnkdlabl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sign_up_lnkdlabl_LinkClicked);
            // 
            // login_but
            // 
            this.login_but.BackColor = System.Drawing.Color.Transparent;
            this.login_but.FlatAppearance.BorderSize = 0;
            this.login_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_but.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.login_but.Location = new System.Drawing.Point(35, 618);
            this.login_but.Name = "login_but";
            this.login_but.Size = new System.Drawing.Size(169, 86);
            this.login_but.TabIndex = 10;
            this.login_but.Text = "Log in";
            this.login_but.UseVisualStyleBackColor = false;
            this.login_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // pasword_labl
            // 
            this.pasword_labl.AutoSize = true;
            this.pasword_labl.BackColor = System.Drawing.Color.Transparent;
            this.pasword_labl.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasword_labl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.pasword_labl.Location = new System.Drawing.Point(188, 376);
            this.pasword_labl.Name = "pasword_labl";
            this.pasword_labl.Size = new System.Drawing.Size(147, 60);
            this.pasword_labl.TabIndex = 9;
            this.pasword_labl.Text = "Passwor";
            // 
            // username_labl
            // 
            this.username_labl.AutoSize = true;
            this.username_labl.BackColor = System.Drawing.Color.Transparent;
            this.username_labl.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_labl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.username_labl.Location = new System.Drawing.Point(154, 255);
            this.username_labl.Name = "username_labl";
            this.username_labl.Size = new System.Drawing.Size(212, 60);
            this.username_labl.TabIndex = 8;
            this.username_labl.Text = "User name";
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.White;
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txt.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.password_txt.Location = new System.Drawing.Point(52, 453);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '☻';
            this.password_txt.Size = new System.Drawing.Size(416, 55);
            this.password_txt.TabIndex = 7;
            this.password_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_txt_KeyDown);
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.White;
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txt.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.username_txt.Location = new System.Drawing.Point(52, 318);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(416, 55);
            this.username_txt.TabIndex = 6;
            this.username_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_txt_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // rmmbr_check
            // 
            this.rmmbr_check.AutoSize = true;
            this.rmmbr_check.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmmbr_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.rmmbr_check.Location = new System.Drawing.Point(52, 527);
            this.rmmbr_check.Name = "rmmbr_check";
            this.rmmbr_check.Size = new System.Drawing.Size(163, 39);
            this.rmmbr_check.TabIndex = 13;
            this.rmmbr_check.Text = "Remember me";
            this.rmmbr_check.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(516, 705);
            this.Controls.Add(this.rmmbr_check);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sign_up_lnkdlabl);
            this.Controls.Add(this.login_but);
            this.Controls.Add(this.pasword_labl);
            this.Controls.Add(this.username_labl);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel sign_up_lnkdlabl;
        private System.Windows.Forms.Button login_but;
        private System.Windows.Forms.Label pasword_labl;
        private System.Windows.Forms.Label username_labl;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox rmmbr_check;
    }
}

