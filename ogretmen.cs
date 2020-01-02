using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ogretmen : MetroFramework.Forms.MetroForm { 
        public ogretmen()
        {
            InitializeComponent();
        }

        private void ogretmen_Load(object sender, EventArgs e)
        {

        }

        private void soruEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            soruEkle form1 = new soruEkle();
            form1.Show();
            this.Hide();
        }

        private void sorularıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sorular form1 = new sorular();
            form1.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
