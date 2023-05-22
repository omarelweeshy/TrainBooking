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
    public partial class deleteTrain : Form
    {
        public deleteTrain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianBooking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from train where train_id=@id", con);

            cmd.Parameters.AddWithValue("@id", comboBox1.Text);

            con.Open();
            int rowEffcted = cmd.ExecuteNonQuery();
            if (rowEffcted > 0)
            {
                MessageBox.Show("Deleted Successfully");

            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianBooking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from train where train_id = @id", con);
            cmd.Parameters.AddWithValue("@id", comboBox1.Text);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                label8.Text = rdr[1].ToString();
                label9.Text = rdr[2].ToString();
                label10.Text = rdr[3].ToString();
                label11.Text = rdr[4].ToString();
                label12.Text = rdr[5].ToString();
                label13.Text = rdr[6].ToString();

            }
            else
            {
                MessageBox.Show("id not found");
            }

            con.Close();
        }

        private void deleteTrain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trianBookingDataSet6.train' table. You can move, or remove it, as needed.
            this.trainTableAdapter1.Fill(this.trianBookingDataSet6.train);

        }
    }
}
