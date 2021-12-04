using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fakarny
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection("server=DESKTOP-2ROJPSN ;database=fakarny_data ;integrated security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select * from user_sign where user_names ='"+username_txt.Text+"' and passwords ='"+password_txt.Text+"';", cn);
            dr = cmd.ExecuteReader();
           
            if (dr.Read() == true)
            {
                id.id_user = dr[0].ToString();

                home h = new home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username doesn't exist ");
            }
            dr.Close();
            cn.Close();
            
            if (rmmbr_check.Checked == false)
            {
                username_txt.Text = "";
                password_txt.Text = "";
            }
        }

        private void sign_up_lnkdlabl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up s = new sign_up();
            s.Show();
        }

        private void username_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_txt.Focus();

            }
        }

        private void password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.login_but.PerformClick();
            }
        }
    }
}
