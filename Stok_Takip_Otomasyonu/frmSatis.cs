using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Otomasyonu
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        private const string cns = "Data Source=EC2AMAZ-8DHV6MA\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True";
        //SqlConnection baglanti = new SqlConnection(cns);
        private void frmSatis_Load(object sender, EventArgs e)
        {
            label10.Text = cns;
        }


        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle mEkle = new frmMusteriEkle();
            mEkle.ShowDialog();
        }


        private void btnKategori_Click(object sender, EventArgs e)
        {
            frmKategori kEkle = new frmKategori();
            kEkle.ShowDialog();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka mEkle = new frmMarka();
            mEkle.ShowDialog();
        }

        private void btnUrunListeleme_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMusteriListeleme_Click(object sender, EventArgs e)
        {
            frmMusteriListele mListele = new frmMusteriListele();
            mListele.ShowDialog();
        }

        private void btnUrunEkleme_Click(object sender, EventArgs e)
        {
            frmUrunEkle uEkle = new frmUrunEkle();
            uEkle.ShowDialog();
        }
    }
}
