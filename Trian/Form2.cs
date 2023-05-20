using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trian
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add a = new Add();
            a.ShowDialog();
        }

        private void costumerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
