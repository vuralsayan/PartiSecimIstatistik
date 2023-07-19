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

namespace PartiSecimIstatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Vural\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("INSERT INTO TBLILCE (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtilceAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtA.Text);
            komut.Parameters.AddWithValue("@P3", TxtB.Text);
            komut.Parameters.AddWithValue("@P4", TxtC.Text);
            komut.Parameters.AddWithValue("@P5", TxtD.Text);
            komut.Parameters.AddWithValue("@P6", TxtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }
    }
}
