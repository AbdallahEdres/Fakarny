
namespace Fakarny
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_but = new FontAwesome.Sharp.IconButton();
            this.add_but = new FontAwesome.Sharp.IconButton();
            this.home_but = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_cont1 = new Fakarny.home_cont();
            this.add_cont1 = new Fakarny.add_cont();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.logout_but);
            this.panel1.Controls.Add(this.add_but);
            this.panel1.Controls.Add(this.home_but);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 719);
            this.panel1.TabIndex = 0;
            // 
            // logout_but
            // 
            this.logout_but.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_but.FlatAppearance.BorderSize = 0;
            this.logout_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_but.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.logout_but.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logout_but.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.logout_but.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.logout_but.IconSize = 60;
            this.logout_but.Location = new System.Drawing.Point(0, 616);
            this.logout_but.Name = "logout_but";
            this.logout_but.Size = new System.Drawing.Size(310, 103);
            this.logout_but.TabIndex = 4;
            this.logout_but.Text = "Log Out";
            this.logout_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout_but.UseVisualStyleBackColor = true;
            this.logout_but.Click += new System.EventHandler(this.logout_but_Click);
            // 
            // add_but
            // 
            this.add_but.FlatAppearance.BorderSize = 0;
            this.add_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_but.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.add_but.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.add_but.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.add_but.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_but.Location = new System.Drawing.Point(0, 403);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(310, 95);
            this.add_but.TabIndex = 2;
            this.add_but.Text = "New Acount";
            this.add_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // home_but
            // 
            this.home_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(176)))));
            this.home_but.FlatAppearance.BorderSize = 0;
            this.home_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_but.Font = new System.Drawing.Font("Milla Cilla - Personal Use", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.home_but.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.home_but.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(25)))), ((int)(((byte)(125)))));
            this.home_but.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.home_but.Location = new System.Drawing.Point(-15, 278);
            this.home_but.Name = "home_but";
            this.home_but.Size = new System.Drawing.Size(325, 95);
            this.home_but.TabIndex = 1;
            this.home_but.Text = "Home";
            this.home_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home_but.UseVisualStyleBackColor = false;
            this.home_but.Click += new System.EventHandler(this.home_but_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // home_cont1
            // 
            this.home_cont1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.home_cont1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_cont1.Location = new System.Drawing.Point(310, 3);
            this.home_cont1.Name = "home_cont1";
            this.home_cont1.Size = new System.Drawing.Size(1001, 719);
            this.home_cont1.TabIndex = 2;
            this.home_cont1.Visible = false;
            // 
            // add_cont1
            // 
            this.add_cont1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_cont1.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_cont1.Location = new System.Drawing.Point(310, 0);
            this.add_cont1.Name = "add_cont1";
            this.add_cont1.Size = new System.Drawing.Size(1001, 719);
            this.add_cont1.TabIndex = 1;
            this.add_cont1.Visible = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1304, 719);
            this.Controls.Add(this.home_cont1);
            this.Controls.Add(this.add_cont1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.Text = "home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.home_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton logout_but;
        private FontAwesome.Sharp.IconButton add_but;
        private FontAwesome.Sharp.IconButton home_but;
        private System.Windows.Forms.PictureBox pictureBox1;
        private add_cont add_cont1;
        private home_cont home_cont1;
    }
}