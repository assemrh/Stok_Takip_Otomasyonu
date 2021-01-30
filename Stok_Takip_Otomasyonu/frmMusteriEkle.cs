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

namespace Stok_Takip_Otomasyonu
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private const string cns = "Data Source=EC2AMAZ-8DHV6MA\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(cns);

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sqlEklemeCumlesi = "INSERT INTO Musteri (TC, AdSoyad, Telefon, Adres, Email) VALUES(@TC, @AdSoyad, @Telefon, @Adres, @Email)";
            String sqlAramaCumlesi = "SELECT TC FROM Musteri Where TC = @_tc;";
            //SqlCommand komud2 = new SqlCommand(sqlAramaCumlesi, baglanti);
            //komud2.Parameters.AddWithValue("@_tc", txtTc.Text);
            SqlCommand komut = new SqlCommand(sqlEklemeCumlesi, baglanti);
            komut.Parameters.AddWithValue("@TC", txtTc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Musteri Kayıdı Eklendi");
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
