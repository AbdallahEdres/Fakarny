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
    public partial class sign_up : Form
    {
        SqlConnection cn = new SqlConnection("server=DESKTOP-2ROJPSN ;database=fakarny_data ;integrated security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        public sign_up()
        {
            InitializeComponent();
        }

        private void sign_but_Click(object sender, EventArgs e)
        {
            if (username_txt.Text == "")
            {
                username_labl.ForeColor = Color.Red;
                username_txt.Focus();
            }
            if (password_txt.Text == "")
            {
                pasword_labl.ForeColor = Color.Red;
                password_txt.Focus();
            }
            
            if (username_txt.Text != "" && password_txt.Text != "" )
            {
                cn.Open();
                cmd = new SqlCommand("select user_names from user_sign where user_names ='" + username_txt.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read() == false)
                {
                    cn.Close();
                    cn.Open();
                    cmd = new SqlCommand("insert into user_sign (user_names,passwords)values ('" + username_txt.Text + "','" + password_txt.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    username_txt.Text = "";
                    password_txt.Text = "";
                    MessageBox.Show("succesful");
                    Application.OpenForms[0].Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("UserName Exists");
                    username_txt.Focus();
                }
                dr.Close();
                cn.Close();

            }
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            username_labl.ForeColor = Color.Black;
        }

       

      

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            pasword_labl.ForeColor = Color.Black;
        }
    }
    
}
