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
    public partial class sınavBaslatma2 : Form
    {
        SqlConnection baglanti;
        public sınavBaslatma2()
        {
            InitializeComponent();
            baglanti = new SqlConnection("server=DESKTOP-EVR30TQ; Initial Catalog=matematikDünya;Integrated Security=SSPI");

        }

        private void sınavBaslatma2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from sorular where soruID = 5";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["soruIcerik"].ToString();
                label3.Text = dr["cevapA"].ToString();
                label4.Text = dr["cevapB"].ToString();
                label5.Text = dr["cevapC"].ToString();
                label6.Text = dr["cevapD"].ToString();
                cevapLabel.Text = dr["cevap"].ToString();
                soruIDLabel.Text = dr["soruID"].ToString();
                konuIDLabel.Text = dr["konuID"].ToString();
            }
            else
            {
                label1.Text = "SORU CEVAPLANAMADI";
            }
            baglanti.Close();
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
                if (cevapLabel.Text == "cA        ")
                {
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + cevapLabel.Text + "','" + dogru + "','" + konuIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    MessageBox.Show("başarılı");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("basarız");
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + cevapLabel.Text + "','" + yanlis + "','" + konuIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    baglanti.Close();
                }
            }

            if (checkBox2.Checked)
            {
                if (cevapLabel.Text == "cB        ")
                {
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + cevapLabel.Text + "','" + dogru + "','" + konuIDLabel.Text + "')";
                    //soruya verilen cevabı eklemek istedik
                    EKLEME.ExecuteNonQuery();
                    MessageBox.Show("başarılı");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("basarız");
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + cevapLabel.Text + "','" + yanlis + "','" + konuIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            if (checkBox3.Checked)
            {
                if (cevapLabel.Text == "cC        ")
                {
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + cevapLabel.Text + "','" + dogru + "','" + konuIDLabel.Text + "')";
                    //soruya verilen cevabı eklemek istedik
                    EKLEME.ExecuteNonQuery();
                    MessageBox.Show("başarılı");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("basarız");
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + cevapLabel.Text + "','" + yanlis + "','" + konuIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            if (checkBox4.Checked)
            {
                if (cevapLabel.Text == "cC        ")
                {
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + cevapLabel.Text + "','" + dogru + "','" + konuIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    MessageBox.Show("başarılı");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("basarız");
                    EKLEME.CommandText = "insert into sinav (soruID,verilenCevap,dogruMu,konuID) values ('" + soruIDLabel.Text + "','" + cevapLabel.Text + "','" + yanlis + "','" + konuIDLabel.Text + "')";
                    EKLEME.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
        }
    }
}
    
