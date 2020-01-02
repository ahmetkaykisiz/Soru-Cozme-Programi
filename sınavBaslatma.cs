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
    public partial class sınavBaslatma : MetroFramework.Forms.MetroForm
    {
        int sayac = 1;
        SqlConnection baglanti;
        public sınavBaslatma()
        {
            baglanti = new SqlConnection("server=DESKTOP-EVR30TQ; Initial Catalog=matematikDünya;Integrated Security=SSPI");

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand EKLEME;
            EKLEME = new SqlCommand();
            baglanti.Open();
            EKLEME.Connection = baglanti;

            int dogru = 0;
            int yanlis = 1;
            if (checkBox1.Checked)
            { 
                if (label7.Text == "cA        ")
                {
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + soruIDLabel.Text + "','" + dogru + "','" + soruIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    MessageBox.Show("başarılı");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("basarız");
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + soruIDLabel.Text + "','" + yanlis + "','" + soruIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    MessageBox.Show("hatalı cevap");
                    baglanti.Close();
                }
            }

            if (checkBox2.Checked)
            {
                if (label7.Text == "cB        ") {
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + label7.Text + "','" + dogru + "','" + soruIDLabel.Text + "')";
                    //soruya verilen cevabı eklemek istedik
                    EKLEME.ExecuteNonQuery();
                    MessageBox.Show("başarılı");
                    baglanti.Close();
                }
                else
                { MessageBox.Show("basarız");
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + label7.Text + "','" + yanlis + "','" + soruIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    baglanti.Close(); }
            }
            if (checkBox3.Checked)
            {
                if (label7.Text == "cC        ")
                {
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + label7.Text + "','" + dogru + "','" + soruIDLabel.Text + "')";
                    //soruya verilen cevabı eklemek istedik
                    EKLEME.ExecuteNonQuery();
                    MessageBox.Show("başarılı");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("basarız");
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + label7.Text + "','" + yanlis + "','" + soruIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            if (checkBox4.Checked)
            {
                if (label7.Text == "cD        ")
                {
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + soruIDLabel.Text + "','" + dogru + "','" + soruIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    MessageBox.Show("başarılı");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("basarız");
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + soruIDLabel.Text + "','" + yanlis + "','" + soruIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    baglanti.Close();
                    }
            }

        }
        
        
       

        private void sınavBaslatma_Load(object sender, EventArgs e)
        {//SORUYU GÖSTERİYORUZ
            sayac = sayac + 1;//KAÇINCI SORUDA OLDUĞUNU GÖRÜYOR
            label2.Text = sayac.ToString();
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand();            
            komut.Connection = baglanti;
            Random rastgele = new Random();
            int sayi = rastgele.Next(3);
            komut.CommandText = "Select * from sorular where soruID = 1";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["soruIcerik"].ToString();
                label3.Text = dr["cevapA"].ToString();
                label4.Text = dr["cevapB"].ToString();
                label5.Text = dr["cevapC"].ToString();
                label6.Text = dr["cevapD"].ToString();
                label7.Text = dr["cevap"].ToString();
                //konuIDLabel.Text = dr["konuID"].ToString();
                soruIDLabel.Text = dr["soruID"].ToString();
            }
            else
            {
                label1.Text = "SORU GETİRİLEMEDİ";
            }
            baglanti.Close();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenci form1 = new ogrenci();
            form1.Show();
            this.Hide();
        }

        private void başarıDurumuToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
