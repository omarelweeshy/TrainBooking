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
    public partial class updateCostumer : Form
    {
        public updateCostumer()
        {
            InitializeComponent();
        }

        private void updateCostumer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trianBookingDataSet2.costumer' table. You can move, or remove it, as needed.
            this.costumerTableAdapter.Fill(this.trianBookingDataSet2.costumer);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianBooking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from costumer where costumer_id = @id", con);
            cmd.Parameters.AddWithValue("@id", comboBox1.Text);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                textBox1.Text = rdr[1].ToString();
                textBox2.Text = rdr[2].ToString();
                textBox3.Text = rdr[3].ToString();
                textBox4.Text = rdr[4].ToString();
                textBox5.Text = rdr[5].ToString();
                
            }
            else
            {
                MessageBox.Show("id not found");
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUP54T1;Initial Catalog=TrianBooking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update costumer set costumer_name=@name, costumer_age=@age, costumer_email=@email, costumer_phone=@phone, costumer_password=@password where costumer_id=@id", con);

            cmd.Parameters.AddWithValue("@id", comboBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@phone", textBox4.Text);
            cmd.Parameters.AddWithValue("@password", textBox5.Text);


            con.Open();
            int rowEffcted = cmd.ExecuteNonQuery();
            if (rowEffcted > 0)
            {
                MessageBox.Show("Updated Successfully");

            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            con.Close();
        }
    }
}
