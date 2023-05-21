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

namespace TrainProject
{
    public partial class loginAdmin : Form
    {
        public loginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianBooking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM _admin WHERE admin_email = '" + textBox1.Text + "' AND admin_password = '" + textBox2.Text + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
               edit ed = new edit();
               ed.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

            con.Close();
        }
    }
}
