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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        SqlConnection baglanti;
        public Form1()
        {
            InitializeComponent();
            baglanti = new SqlConnection("server=DESKTOP-EVR30TQ; Initial Catalog=matematikDünya;Integrated Security=SSPI");


        }


        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
           
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM kullanici where kullaniciAd='" + user + "' AND sifre='" + pass + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["yetki"].ToString()== "1") {
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");
                    ogrenci form1 = new ogrenci();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    ogretmen form1 = new ogretmen();
                    form1.Show();
                    this.Hide();
                }
                
               
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
        }
    }
}
