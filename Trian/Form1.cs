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

namespace Trian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM costumer WHERE costumer_email = '" + textBox2.Text + "' AND costumer_password = '" + textBox1.Text + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                MessageBox.Show("kosomk anta htzer m3aya");
            }

            con.Close();
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
