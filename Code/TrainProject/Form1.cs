using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginAdmin l = new loginAdmin();
            l.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rigesterCostumer r = new rigesterCostumer();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginCostumer lc = new loginCostumer(); 
            lc.ShowDialog();
        }
    }
}
