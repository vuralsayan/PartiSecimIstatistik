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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Vural\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // İlçe Adlarını Comboboxa Çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT ILCEAD FROM TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlce.Items.Add(dr[0]);
            }
            baglanti.Close();

            // Partileri Grafiklere Çekme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT SUM(APARTI), SUM(BPARTI), SUM(CPARTI), SUM(DPARTI), SUM(EPARTI) FROM TBLILCE", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);  
            }
            baglanti.Close();


        }

        private void CmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            // İlçe Seçildiğinde O İlçenin Oylarını Grafiklere Çekme
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM TBLILCE WHERE ILCEAD=@P1", baglanti);
            komut3.Parameters.AddWithValue("@P1", CmbIlce.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                progressBar1.Value = int.Parse(dr3[2].ToString());  
                progressBar2.Value = int.Parse(dr3[3].ToString());
                progressBar3.Value = int.Parse(dr3[4].ToString());
                progressBar4.Value = int.Parse(dr3[5].ToString());
                progressBar5.Value = int.Parse(dr3[6].ToString());

                LblA.Text = dr3[2].ToString();  
                LblB.Text = dr3[3].ToString();
                LblC.Text = dr3[4].ToString();
                LblD.Text = dr3[5].ToString();
                LblE.Text = dr3[6].ToString();
            }
            baglanti.Close();
        }
    }
}
