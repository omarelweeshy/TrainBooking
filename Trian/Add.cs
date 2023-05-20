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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into costumer values(@id, @name, @age, @email, @phone, @password)", con);

            cmd.Parameters.AddWithValue("@id", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@age", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@phone", textBox4.Text);
            cmd.Parameters.AddWithValue("@password", textBox5.Text);
            

            con.Open();
            int rowEffcted = cmd.ExecuteNonQuery();
            if (rowEffcted > 0)
            {
                MessageBox.Show("Resigtered Successfully");
            }
            else
            {
                MessageBox.Show("Resigteration Failed");
            }
            con.Close();
        }
    }
}
