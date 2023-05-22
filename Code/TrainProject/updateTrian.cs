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

namespace TrainProject
{
    public partial class updateTrian : Form
    {
        public updateTrian()
        {
            InitializeComponent();
        }

        private void updateTrian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trianBookingDataSet5.train' table. You can move, or remove it, as needed.
            this.trainTableAdapter.Fill(this.trianBookingDataSet5.train);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianBooking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from train where train_id = @id ", con);

            cmd.Parameters.AddWithValue("@id", comboBox1.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                // data column train_company
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox3.Text = dr[3].ToString();
                textBox4.Text = dr[4].ToString();
                textBox5.Text = dr[5].ToString();
                textBox6.Text = dr[6].ToString();

            }
            else
            {
                MessageBox.Show("Trian ID not found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianBooking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update train set train_company = @train_company, CoachNo = @CoachNO, Economy = @Economy, Business = @Business,Rooms = @Rooms, capacity = @capacity where train_id = @id", con);

            cmd.Parameters.AddWithValue("@id", comboBox1.Text);
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
                MessageBox.Show("Train updated Successfully");

            }
            else
            {
                MessageBox.Show("Train not updated");
            }
            con.Close();
        }
    }
}
