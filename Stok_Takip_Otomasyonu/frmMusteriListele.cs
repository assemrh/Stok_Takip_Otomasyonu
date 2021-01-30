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


namespace Stok_Takip_Otomasyonu
{
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private const string cns = "Data Source=EC2AMAZ-8DHV6MA\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(cns);
        DataSet daset = new DataSet();

      
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            kayıtGoster();
        }

        private void kayıtGoster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM Musteri", baglanti);
            adtr.Fill(daset, "Musteri");
            dataGridView1.DataSource = daset.Tables["Musteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Musteri set AdSoyad=@AdSoyad, Telefon=@Telefon, Adres=@Adres, Email=@Email WHERE TC=@TC ", baglanti);
            komut.Parameters.AddWithValue("@TC", txtTc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Musteri"].Clear();
            kayıtGoster();
            MessageBox.Show("Musteri Kayıdı Güncelledi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("DELETE FORM Musteri WHERE TC ='" + dataGridView1.CurrentRow.Cells["TC"].Value.ToString(), baglanti) ;
            Komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Musteri"].Clear();
            kayıtGoster();
            MessageBox.Show("Musteri Kayıdı Silindi");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM Musteri WHERE TC Like '%" + txtTcAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
