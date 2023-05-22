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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateCostumer up = new updateCostumer();
            up.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteCostumer d = new deleteCostumer();
            d.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTrian a = new addTrian();
            a.ShowDialog();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            updateTrian u = new updateTrian();     
            u.ShowDialog();

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteTrain dt = new deleteTrain(); 
            dt.ShowDialog();
        }
    }
}
