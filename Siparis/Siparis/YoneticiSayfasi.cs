using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis
{
    public partial class YoneticiSayfasi : Form
    {
        public Musteri musteri { get; set; }
        public YoneticiSayfasi()
        {
            InitializeComponent();
        }
        static string baglantiDizesi = "server=LAPTOP-DE6TC4RE\\SQLEXPRESS;Database=ayakkabiSiparis;Integrated Security=SSPI";
        
        SqlConnection baglanti = new SqlConnection(baglantiDizesi);
        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView2.CellClick += DataGridView2_CellClick;
            kullanici();
            urun();

        }
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sutun = e.RowIndex;
            DataGridViewRow stn = dataGridView2.Rows[sutun];
            musteriId.Text= stn.Cells[0].Value.ToString();
            kullaniciadi.Text= stn.Cells[1].Value.ToString();
            parola.Text= stn.Cells[2].Value.ToString(); 
            isim.Text= stn.Cells[5].Value.ToString();
            soyisim.Text = stn.Cells[6].Value.ToString();
            yetkili.Text= stn.Cells[3].Value.ToString();
            adres.Text= stn.Cells[4].Value.ToString();

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sutun = e.RowIndex;
            DataGridViewRow stn = dataGridView1.Rows[sutun];
            
            urunid.Text= stn.Cells[0].Value.ToString();
            model.Text= stn.Cells[3].Value.ToString();
            Kagirligi.Text = stn.Cells[1].Value.ToString(); 
            aciklama.Text = stn.Cells[2].Value.ToString();
            fiyat.Text = stn.Cells[4].Value.ToString();
        }
        
        void kullanici() {
            baglanti.Close();

            baglanti.Open();

            string sorguDizesi = "SELECT * from kullanici";
            SqlCommand sorgu = new SqlCommand();

            sorgu.Connection = baglanti;
            sorgu.CommandText = sorguDizesi ;
            SqlDataAdapter sda2 = new SqlDataAdapter(sorgu);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            baglanti.Close();
        }
        void urun() {
            baglanti.Open();
            string sorguDize = "SELECT * from urun";
            SqlCommand s = new SqlCommand();
            s.Connection = baglanti;
            s.CommandText = sorguDize;
            SqlDataAdapter sda = new SqlDataAdapter(s);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
   

      

       
        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = baglanti;
            kmt.CommandText = "INSERT INTO kullanici(kullaniciAdi, parola, yetkili, adres,isim,soyisim) VALUES (@kadi, @parola,@yetkili, @adres,@isim, @soyisim); ";
            kmt.Parameters.AddWithValue("@kadi", kullaniciadi.Text);
            kmt.Parameters.AddWithValue("@parola", parola.Text);
            kmt.Parameters.AddWithValue("@yetkili", yetkili.Text);
            kmt.Parameters.AddWithValue("@adres", adres.Text);
            kmt.Parameters.AddWithValue("@isim", isim.Text);
            kmt.Parameters.AddWithValue("@soyisim", soyisim.Text);
            kmt.ExecuteNonQuery();
           
            baglanti.Close();
            kullanici();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;

                komut.CommandText = "Update  kullanici set kullaniciAdi = @kadi,parola = @parola,yetkili = @yetkili,adres = @adres,isim = @isim,soyisim = @soyisim" +
                    " where kullaniciID = @kId ";
                komut.Parameters.AddWithValue("@kadi", kullaniciadi.Text);
                komut.Parameters.AddWithValue("@parola", parola.Text);
                komut.Parameters.AddWithValue("@yetkili", yetkili.Text);
                komut.Parameters.AddWithValue("@adres", adres.Text);
                komut.Parameters.AddWithValue("@isim", isim.Text);
                komut.Parameters.AddWithValue("@soyisim", soyisim.Text);
                komut.Parameters.AddWithValue("@kId", musteriId.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                kullanici();
                
          
        }
        private void button6_Click(object sender, EventArgs e)
        {
           
                SqlCommand komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from kullanici where kullaniciID=" + musteriId.Text + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
                kullanici();
               
            
        }
      
        private void button5_Click_1(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = baglanti;
            kmt.CommandText = "INSERT INTO urun(kargoAgirligi, aciklama, urunModel, urunFiyat) VALUES (@kargoAgirligi, @aciklama,@urunModel, @urunFiyat); ";
            kmt.Parameters.AddWithValue("@kargoAgirligi", Kagirligi.Text);
            kmt.Parameters.AddWithValue("@aciklama", aciklama.Text);
            kmt.Parameters.AddWithValue("@urunModel", model.Text);
            kmt.Parameters.AddWithValue("@urunFiyat", fiyat.Text);
            kmt.ExecuteNonQuery();
            baglanti.Close();
            urun();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglanti;

                kmt.CommandText = "Update  urun set kargoAgirligi = @kargoAgirligi,aciklama = @aciklama,urunModel = @urunModel,urunFiyat = @urunFiyat where urunID = @urunid ";
                kmt.Parameters.AddWithValue("@kargoAgirligi", Kagirligi.Text);
                kmt.Parameters.AddWithValue("@aciklama", aciklama.Text);
                kmt.Parameters.AddWithValue("@urunid", urunid.Text);
                kmt.Parameters.AddWithValue("@urunModel", model.Text);
                kmt.Parameters.AddWithValue("@urunFiyat", fiyat.Text);
                kmt.ExecuteNonQuery();
                baglanti.Close();
                urun();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from urun where urunID=" + urunid.Text + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
                urun();
              
        }

    }
}
