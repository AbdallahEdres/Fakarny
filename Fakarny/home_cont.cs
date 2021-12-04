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
    
    public partial class home_cont : UserControl
    {
        SqlConnection cn = new SqlConnection("server=DESKTOP-2ROJPSN ;database=fakarny_data ;integrated security=true");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;
        string id_ = id.id_user;
        private void combo_fil()
        {
            chose_combo.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("select * from category where id_user=1 or id_user=" +Convert.ToInt32( id_) + "", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chose_combo.Items.Add(dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }


        public home_cont()
        {
            InitializeComponent();
            cn.Open();
            cmd = new SqlCommand("select name_app,user_names,pass,email,link,category from user_data where id_user= " + Convert.ToInt32(id_) + ";", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "user_data");
            data_grid.DataSource = ds.Tables["user_data"].DefaultView;
            data_grid.Columns.Add("column1", "hhhhh");
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            data_grid.Columns.Add(chk);
            
            cn.Close();
            combo_fil();

        }

        private void chose_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select name_app,user_names,pass,email,link,category from user_data where id_user= " + Convert.ToInt32(id_) + " and category = '" + chose_combo.Text + "';", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "user_data");
            data_grid.DataSource = ds.Tables["user_data"].DefaultView;
            cn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select name_app,user_names,pass,email,link,category from user_data where (name_app like'%" + search_txt.Text + "%'or user_names like'%" + search_txt.Text + "%' or pass like'%" + search_txt.Text + "%' or link like'%" + search_txt.Text + "%' or category like'%" + search_txt.Text + "%') and id_user= " + Convert.ToInt32(id_) + " ;", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "user_data");
            data_grid.DataSource = ds.Tables["user_data"].DefaultView;
            cn.Close();
        }

        private void chose_combo_Click(object sender, EventArgs e)
        {
            combo_fil();
        }
    }
}
