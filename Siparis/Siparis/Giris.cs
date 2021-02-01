using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Threading;

namespace Siparis
{
    public partial class Giris : Form
    {

        public Giris()
        {
            InitializeComponent();
        }
        public Musteri m;
        private void button1_Click(object sender, EventArgs e)
        {
          
                String kullaniciAdi = kAdi.Text.ToString();
                String parolasi = parola.Text.ToString();
             
               
                SqlConnection baglanti = new SqlConnection("server=LAPTOP-DE6TC4RE\\SQLEXPRESS; Initial Catalog=ayakkabiSiparis;Integrated Security=SSPI");
                SqlCommand komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM kullanici where  CONVERT(VARCHAR, kullaniciAdi)='" + kullaniciAdi + "' AND  CONVERT(VARCHAR, parola)='" + parolasi + "'";
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    m = new Musteri((int)dr["kullaniciID"], (string)dr["kullaniciAdi"], (string)dr["parola"], (string)dr["isim"], (string)dr["soyisim"], (string)dr["adres"], (string)dr["yetkili"]);
                if ((string)dr["yetkili"] == "0")
                    {
                        Sepet form3 = new Sepet();
                        form3.musteri = m;
                        form3.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
                        form3.Show();
                    }
                    else {
                    YoneticiSayfasi form4 = new YoneticiSayfasi();
                    form4.musteri = m;
                        form4.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
                        form4.Show();
                    }
                    

                    this.Hide();
                }
                baglanti.Close();


           
            

        }
        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
  

      
    }
