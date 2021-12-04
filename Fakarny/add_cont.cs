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
    public partial class add_cont : UserControl
    {
        private void combo_fil()
        {
            cat_combo.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("select * from category where id_user=1 or id_user = " +Convert.ToInt32( id_) + "", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cat_combo.Items.Add(dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }
        SqlConnection cn = new SqlConnection("server=DESKTOP-2ROJPSN ;database=fakarny_data ;integrated security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        string id_ = id.id_user;
        public add_cont()
        {
            InitializeComponent();
            combo_fil();

        }

        private void save_but_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (!nw_cat_check.Checked)
            {
                cmd = new SqlCommand("insert into user_data (id_user,name_app,user_names,pass,email,link,category) values ("
                + Convert.ToInt32(id_) + ",'" + appname_txt.Text + "','" + username_txt.Text + "','" + pass_txt.Text + "','" + email_txt.Text + "','" + link_txt.Text + "','" + cat_combo.Text + "')", cn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cat_combo.Items.Clear();
                cmd = new SqlCommand("insert into user_data (id_user,name_app,user_names,pass,email,link,category) values ("
                + Convert.ToInt32(id_) + ",'" + appname_txt.Text + "','" + username_txt.Text + "','" + pass_txt.Text + "','" + email_txt.Text + "','" + link_txt.Text + "','" + new_cat_txt.Text + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Open();
                cmd = new SqlCommand("insert into category (id_user,category) values (" + id_ + ",'" + new_cat_txt.Text + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                combo_fil();
            }

            cn.Close();
            MessageBox.Show("Saved");
        }

        private void nw_cat_check_CheckedChanged(object sender, EventArgs e)
        {
            if (nw_cat_check.Checked)
            {
                new_cat_txt.ReadOnly = false;
                cat_combo.Visible = false;
                new_cat_txt.Visible = true;

            }
            else
            {
                new_cat_txt.ReadOnly = true;
                cat_combo.Visible = true;
                new_cat_txt.Visible = false;
            }
        }

        private void add_cont_Load(object sender, EventArgs e)
        {

        }
    }
}
