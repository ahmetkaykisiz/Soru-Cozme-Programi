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
    public partial class basarıDurumu : Form
    {
        SqlConnection baglanti;
        public basarıDurumu()
        {
            InitializeComponent();
            baglanti = new SqlConnection("server=DESKTOP-EVR30TQ; Initial Catalog=matematikDünya;Integrated Security=SSPI");

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void basarıDurumu_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM sinav ";
            dr = cmd.ExecuteReader();
            int dogru1 = 0, dogru2 = 0, dogru3 = 0, dogru4 = 0, dogru5 = 0, dogru6 = 0;
            int yanlis1 = 0, yanlis2 = 0, yanlis3 = 0, yanlis4 = 0, yanlis5 = 0, yanlis6 = 0;
            if (dr.Read()) {
                for (int i = 0; i < 100; i++)
                {
                    if (dr["konuID"].ToString() == "1")
                    {
                        if (dr["dogruMu"].ToString() == "0")
                            dogru1++;
                        else
                            yanlis1++; 
                    }
                    if (dr["konuID"].ToString() == "2")
                    {
                        if (dr["dogruMu"].ToString() == "0")
                            dogru2++;
                        else
                            yanlis2++;
                    }
                    if (dr["konuID"].ToString() == "3")
                    {
                        if (dr["dogruMu"].ToString() == "0")
                            dogru3++;
                        else
                            yanlis3++;
                    }
                    if (dr["konuID"].ToString() == "4")
                    {
                        if (dr["dogruMu"].ToString() == "0")
                            dogru4++;
                        else
                            yanlis4++;
                    }
                    if (dr["konuID"].ToString() == "5")
                    {
                        if (dr["dogruMu"].ToString() == "0")
                            dogru5++;
                        else
                            yanlis5++;
                    }
                    if (dr["konuID"].ToString() == "6")
                    {
                        if (dr["dogruMu"].ToString() == "0")
                            dogru6++;
                        else
                            yanlis6++;
                    }
                }
                baglanti.Close();
                //güncelleme
                //unite başına  basarı hesaplama
                int unite1 = dogru1 + yanlis1;
                int basari1= (unite1 / 100) *dogru1;
                int unite2 = dogru2 + yanlis2;
                int basari2 = (unite2 / 100) * dogru2;
                int unite3 = dogru3 + yanlis3;
                int basari3 = (unite3 / 100) * dogru3;
                int unite4 = dogru4 + yanlis4;
                int basari4 = (unite4 / 100) * dogru4;
                int unite5 = dogru5+ yanlis5;
                int basari5 = (unite5 / 100) * dogru5;
                int unite6 = dogru6 + yanlis6;
                int basari6 = (unite6 / 100) * dogru6;
                baglanti.Open();
                string sql = "update basariHesaplama set unite1 = '" + basari1 + "', unite2 = '" + basari2 + "', unite3 = '" + basari3 + "', unite4 = '" + basari4 + "', unite5 = '" + basari5 + "', unite6 = '" + basari6 + "' where id =1 ";
                SqlCommand guncelle = new SqlCommand(sql, baglanti);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                SqlCommand okuyucu;
                SqlDataReader oku;
                okuyucu = new SqlCommand();
                baglanti.Open();
                okuyucu.Connection = baglanti;
                okuyucu.CommandText = "SELECT * FROM basariHesaplama ";
                oku = okuyucu.ExecuteReader();
                while (oku.Read())
                {
                    chart1.Series["Konular"].Points.AddXY("Unite 1", oku["unite1"].ToString());
                    chart1.Series["Konular"].Points.AddXY("Unite 2", oku["unite2"].ToString());
                    chart1.Series["Konular"].Points.AddXY("Unite 3", oku["unite3"].ToString());
                    chart1.Series["Konular"].Points.AddXY("Unite 4", oku["unite4"].ToString());
                    chart1.Series["Konular"].Points.AddXY("Unite 5", oku["unite5"].ToString());
                    chart1.Series["Konular"].Points.AddXY("Unite 6", oku["unite6"].ToString());
                }
                    
            }
        }

        private void testÇözToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sınavBaslatma form1 = new sınavBaslatma();
            form1.Show();
            this.Hide();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenci form1 = new ogrenci();
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
