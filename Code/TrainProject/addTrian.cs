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
    public partial class addTrian : Form
    {
        public addTrian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianBooking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into train values(@train_company, @CoachNo, @Economy, @Business, @Rooms, @capacity)", con);

            cmd.Parameters.AddWithValue("@train_company", textBox1.Text);
            cmd.Parameters.AddWithValue("@CoachNo", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Economy", textBox3.Text);
            cmd.Parameters.AddWithValue("@Business", textBox4.Text);
            cmd.Parameters.AddWithValue("@Rooms", textBox5.Text);
            cmd.Parameters.AddWithValue("@capacity", int.Parse(textBox6.Text));


            con.Open();
            int rowEffcted = cmd.ExecuteNonQuery();
            if (rowEffcted > 0)
            {
                MessageBox.Show("Train added Successfully");

            }
            else
            {
                MessageBox.Show("Train not added");
            }
            con.Close();
        }
    }
}
