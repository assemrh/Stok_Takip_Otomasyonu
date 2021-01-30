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


        private void button8_Click(object sender, EventArgs e)
        {
            frmMusteriEkle mEkle = new frmMusteriEkle();
            mEkle.ShowDialog();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            frmMusteriListele mListele = new frmMusteriListele();
            mListele.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmUrunEkle uEkle = new frmUrunEkle();
            uEkle.ShowDialog();
        }
    }
}
