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

namespace WindowsFormsApp1
{
    public partial class soruEkle : MetroFramework.Forms.MetroForm
    {
        SqlConnection baglanti;

        public soruEkle()
        {
            InitializeComponent();
            baglanti = new SqlConnection("server=DESKTOP-EVR30TQ; Initial Catalog=matematikDünya;Integrated Security=SSPI");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (A.Checked)      label8.Text = "cA";
            else if (B.Checked) label8.Text = "cB";
            else if (C.Checked) label8.Text="cC";
            else if (D.Checked) label8.Text = "cD";
            else MessageBox.Show("Cevap Seçilmedi");
            SqlCommand cmd;
            cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "insert into sorular (soruIcerik,cevap,cevapA,cevapB,cevapC,cevapD,konuID,cozdumu) values ('" + soruTXT.Text + "','" + label8.Text + "','" + aTXT.Text + "','" + bTXT.Text + "','" + cTXT.Text + "','" + dTXT.Text + "','" + textBox1.Text + "','" + label7.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Başarı ile soru eklendi");
            baglanti.Close();
            MessageBox.Show("Başarı ile silindi");
            soruEkle form1 = new soruEkle();
            form1.Show();
            this.Hide();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogretmen form1 = new ogretmen();
            form1.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void sorularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sorular form1 = new sorular();
            form1.Show();
            this.Hide();
        }
    }
}
