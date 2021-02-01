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
    public partial class Sepet : Form
    {
        private int sepet=0;
        public Musteri musteri { get; set; }
        public Sepet()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           getir();


        }
        static string baglantiDizesi = "server=LAPTOP-DE6TC4RE\\SQLEXPRESS;Database=ayakkabiSiparis;Integrated Security=SSPI";
       
        SqlConnection baglanti = new SqlConnection(baglantiDizesi);
       


        DataTable da = new DataTable();
       
        private void getir()
        {
            baglanti.Open();
            string kayit = "SELECT * from urun";
            SqlCommand komut = new SqlCommand();

            komut.Connection = baglanti;
            komut.CommandText = "SELECT * from urun";
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.CellClick += DataGridView1_CellClick;
            baglanti.Close();
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            da.Columns.Add("kargoAgirligi", typeof(string));
            da.Columns.Add("aciklama", typeof(string));
            da.Columns.Add("urunModel", typeof(string));
            da.Columns.Add("urunFiyat", typeof(string));
            da.Columns.Add("urunID", typeof(int));
            dataGridView2.DataSource = da;
            dataGridView2.CellClick += DataGridView2_CellClick; 
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sutun = e.RowIndex;
            DataGridViewRow stn = dataGridView2.Rows[sutun];
            sepet -= Convert.ToInt16(stn.Cells[3].Value.ToString());
            label4.Text = "Fiyat :" + sepet;
            da.Rows[sutun].Delete();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sutun = e.RowIndex;
            
                DataGridViewRow stn = dataGridView1.Rows[sutun];
                sepet += Convert.ToInt16( stn.Cells[4].Value.ToString());
                label4.Text = "Fiyat :" + sepet;
                DataRow dr = da.NewRow();
                dr["urunID"] = stn.Cells[0].Value.ToString();
                dr["kargoAgirligi"] = stn.Cells[1].Value.ToString();
                dr["aciklama"] = stn.Cells[2].Value.ToString();
                dr["urunModel"] = stn.Cells[3].Value.ToString();
                dr["urunFiyat"] = stn.Cells[4].Value.ToString();
                da.Rows.Add(dr);
            
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sepet!=0) { 
                OdemeSayfasi form5 = new OdemeSayfasi();
                form5.dt = da;
                form5.sepet = sepet;
                form5.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
                form5.Show();
            }
        }

        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
    }
}
