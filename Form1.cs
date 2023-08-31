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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GHKR07G1\\SQLEXPRESS;Initial Catalog=SecimUygulamadb;Integrated Security=True");

        private void oygir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblilce (ILCEAD,AKP,CHP,MHP,IYIPARTI,ZAFERPARTI) values (@P1, @P2, @P3, @P4,@P5,@P6) " , baglanti);
            komut.Parameters.AddWithValue("@P1", textBox1.Text);
            komut.Parameters.AddWithValue("@P2", textBox2.Text);
            komut.Parameters.AddWithValue("@P3", textBox3.Text);
            komut.Parameters.AddWithValue("@P4", textBox4.Text);
            komut.Parameters.AddWithValue("@P5", textBox5.Text);
            komut.Parameters.AddWithValue("@P6", textBox6.Text);

            komut.ExecuteNonQuery();

            MessageBox.Show("İşlem Başarılı");
            baglanti.Close();

        }

        private void grafik_Click(object sender, EventArgs e)
        {
            frmgrafikler frm = new frmgrafikler();
            frm.Show();
        }

        private void cik_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
