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

namespace SeçimUygulama
{
    public partial class frmgrafikler : Form
    {
        public frmgrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GHKR07G1\\SQLEXPRESS;Initial Catalog=SecimUygulamadb;Integrated Security=True");


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void frmgrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ILCEAD FROM tblilce", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }   
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT SUM(AKP),SUM(CHP),SUM(MHP),SUM(IYIPARTI),SUM(ZAFERPARTI) FROM tblilce", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("AKP", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("CHP", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("MHP", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("IYIPARTI", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("ZAFERPARTI", dr2[4]);

            }
            baglanti.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tblilce WHERE ILCEAD=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                label7.Text = dr[2].ToString();
                label8.Text = dr[3].ToString();
                label9.Text = dr[4].ToString();
                label10.Text = dr[5].ToString();
                label11.Text = dr[6].ToString();
            }
            baglanti.Close();
        }
    }
}
