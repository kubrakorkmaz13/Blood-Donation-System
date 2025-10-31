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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KanBagis
{
    public partial class HastaListesi : Form
    {
        public HastaListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-4BP5RBKH\\SQLEXPRESS;Initial Catalog=kanbagis;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Hasta Set  yas=@a1, cinsiyet=@a2 ,telefon=@a3, kangrubu=@a4 where ad_soyad=@a5", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@a2", comboBox2.Text);
            komutguncelle.Parameters.AddWithValue("@a3", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@a4", comboBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a5", textBox1.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta Bilgisi Güncellendi");
        }

        private void HastaListesi_Load(object sender, EventArgs e)
        {
          
            this.hastaTableAdapter.Fill(this.kanbagisDataSet3.hasta);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From hasta where ad_soyad=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta Silindi");
        }
    }
}
