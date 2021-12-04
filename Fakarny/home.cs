using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakarny
{
    public partial class home : Form
    {
        string i_d = id.id_user;
        public home()
        {
            InitializeComponent();
  
        }

        private void logout_but_Click(object sender, EventArgs e)
        {
            
            Application.OpenForms["form1"].Show();
            this.Close();
        }

        private void home_but_Click(object sender, EventArgs e)
        {
            home_but.BackColor= Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            add_but.BackColor= Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(176)))));
            add_cont1.Hide();
            home_cont1.Show();

        }

        private void add_but_Click(object sender, EventArgs e)
        {
            add_but.BackColor= Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            home_but.BackColor= Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(176)))));

            add_cont1.Show();
            home_cont1.Hide();

        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
