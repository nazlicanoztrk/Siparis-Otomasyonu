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
    public partial class OdemeSayfasi : Form
    {
        public DataTable dt;
        public int sepet = 0;
        public OdemeSayfasi()
        {
            InitializeComponent();
        }
        static string baglantiDizesi = "server=LAPTOP-DE6TC4RE\\SQLEXPRESS;Database=ayakkabiSiparis;Integrated Security=SSPI";
        SqlConnection baglanti = new SqlConnection(baglantiDizesi);
        bool kontrolEt(int para) {
            if ((Convert.ToInt32(label10.Text) - para) >=0) {
              
                    sepet -= para;
               

                return true;
            }
            
            return false;
        }
         void Form5_Load(object sender, EventArgs e)
        {
            
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            label10.Text = sepet.ToString();
            dataGridView1.DataSource = dt;
        }

       


        private void button4_Click(object sender, EventArgs e)
        {
            if (kontrolEt(Convert.ToInt16(tutar.Text)))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO odeme(tutar)  VALUES (@tutar);SELECT SCOPE_IDENTITY();";
                komut.Parameters.AddWithValue("@tutar", tutar.Text);
                int odemeId = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();
                baglanti.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglanti;
                kmt.CommandText = "INSERT INTO kredi(kartNumara, kartTipi, skt, cvv,odemeID) VALUES (@kno, @ktip,@skt, @cvv,@odeme); ";
                kmt.Parameters.AddWithValue("@kno", kartNo.Text);
                kmt.Parameters.AddWithValue("@ktip", kartTip.Text);
                kmt.Parameters.AddWithValue("@skt", ay.Text + "," + yil.Text);
                kmt.Parameters.AddWithValue("@cvv", cvv.Text);
                kmt.Parameters.AddWithValue("@odeme", odemeId);
                kmt.ExecuteNonQuery();
                label10.Text = sepet.ToString();
                baglanti.Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kontrolEt(Convert.ToInt16(tutarr.Text)))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO odeme(tutar)  VALUES (@tutar);SELECT SCOPE_IDENTITY();";
                komut.Parameters.AddWithValue("@tutar", tutarr.Text);
                int odemeId = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();
                baglanti.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglanti;
                kmt.CommandText = "INSERT INTO cek(isim, bankaNum, odemeID) VALUES (@isim, @bno,@odeme); ";
                kmt.Parameters.AddWithValue("@bno", Bnum.Text);
                kmt.Parameters.AddWithValue("@isim", isimSoyisim.Text);
                kmt.Parameters.AddWithValue("@odeme", odemeId);
                kmt.ExecuteNonQuery();
                label10.Text = sepet.ToString();
                baglanti.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (kontrolEt(Convert.ToInt16(tutarrr.Text)))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO odeme(tutar)  VALUES (@tutar);SELECT SCOPE_IDENTITY();";
                komut.Parameters.AddWithValue("@tutar", tutarrr.Text);
                int odemeId = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();
                baglanti.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglanti;
                kmt.CommandText = "INSERT INTO nakit(nakitAlim, odemeID) VALUES (@nakit, @odeme); ";
                kmt.Parameters.AddWithValue("@nakit", tutarrr.Text);
                kmt.Parameters.AddWithValue("@odeme", odemeId);
                kmt.ExecuteNonQuery();
                label10.Text = sepet.ToString();
                baglanti.Close();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
