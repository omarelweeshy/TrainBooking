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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainProject
{
    public partial class rigesterCostumer : Form
    {
        public rigesterCostumer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianBooking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into costumer values(@name, @age, @email, @phone, @password)", con);

            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@phone", textBox4.Text);
            cmd.Parameters.AddWithValue("@password", textBox5.Text);


            con.Open();
            int rowEffcted = cmd.ExecuteNonQuery();
            if (rowEffcted > 0)
            {
                MessageBox.Show("Resigtered Successfully");
                displayTrips d = new displayTrips();
                d.ShowDialog();

            }
            else
            {
                MessageBox.Show("Resigteration Failed");
            }
            con.Close();
        }
    }
}
