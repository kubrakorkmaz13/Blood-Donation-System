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

namespace KanBagis
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-4BP5RBKH\\SQLEXPRESS;Initial Catalog=kanbagis;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into hasta (ad_soyad,yas,cinsiyet,telefon,kangrubu) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", comboBox2.Text);
            komut.Parameters.AddWithValue("@p4", textBox3.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta başarıyla eklendi.");
        }
    }
}
