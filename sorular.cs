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
    public partial class sorular : MetroFramework.Forms.MetroForm
    {
        SqlConnection baglanti;
        public sorular()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void sorular_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'matematikDünyaDataSet1.sorular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sorularTableAdapter1.Fill(this.matematikDünyaDataSet1.sorular);
           
           // SqlConnection baglanti;
            baglanti = new SqlConnection("server=DESKTOP-EVR30TQ; Initial Catalog=matematikDünya;Integrated Security=SSPI");
            baglanti.Close();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogretmen form1 = new ogretmen();
            form1.Show();
            this.Hide();
        }

        private void soruEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soruEkle form1 = new soruEkle();
            form1.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            soruID.Text = selectedRow.Cells[0].Value.ToString();
            metroTextBox1.Text = selectedRow.Cells[1].Value.ToString();
            metroTextBox2.Text = selectedRow.Cells[2].Value.ToString();
            metroTextBox3.Text = selectedRow.Cells[3].Value.ToString();
            metroTextBox4.Text = selectedRow.Cells[4].Value.ToString();
            metroTextBox5.Text = selectedRow.Cells[5].Value.ToString();
            metroTextBox6.Text = selectedRow.Cells[6].Value.ToString();
            label1.Text= selectedRow.Cells[0].Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "DELETE FROM sorular WHERE soruID='"+ label1.Text +"'";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@soruID", label1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarı ile silindi");
            sorular form1 = new sorular();
            form1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "update sorular set cevap = '" + metroTextBox1.Text + "',cevapA = '" + metroTextBox2.Text + "', cevapB = '" + metroTextBox3.Text + "',cevapC='" + metroTextBox4.Text + "',cevapD='" + metroTextBox5.Text + "',konuID='" + metroTextBox6.Text + "' where soruID = '" + label1.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarı ile güncellendi");
            sorular form1 = new sorular();
            form1.Show();
            this.Hide();
        }
    }
}
