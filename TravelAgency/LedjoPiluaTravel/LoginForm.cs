using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedjoPiluaTravel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";


            string query = "select * from UserCred where username = '" + txtUsername.Text.Trim() + "' and pass = '" + txtPassword.Text.Trim() + "'";

            SqlDataAdapter DA = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();

            DA.Fill(dtbl);


            if (dtbl.Rows.Count == 1)
            {
                          this.Hide();
               Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Wrong Data");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
