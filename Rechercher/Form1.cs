using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechercher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rechercher1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Q1 q = new Q1();
            q.Show();
        }

        private void rechercher2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Q2 q = new Q2();
            q.Show();
        }

        private void rechercher3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Q3 q = new Q3();
            q.Show();
        }

        private void rechercher4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Q4 q = new Q4();
            q.Show();
        }


    }
}
