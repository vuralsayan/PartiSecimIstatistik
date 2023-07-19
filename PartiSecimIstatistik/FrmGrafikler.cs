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
        }
    }
}
