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
    public partial class ogrenci : MetroFramework.Forms.MetroForm
    {
        public ogrenci()
        {
            InitializeComponent();
        }

        private void sınavBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sınavBaslatma form1 = new sınavBaslatma();
            form1.Show();
            this.Hide();
        }

        private void başarıDurumumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basarıDurumu form1 = new basarıDurumu();
            form1.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void ogrenci_Load(object sender, EventArgs e)
        {

        }
    }
}
