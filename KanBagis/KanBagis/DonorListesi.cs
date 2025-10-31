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
    public partial class DonorListesi : Form
    {
        public DonorListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-4BP5RBKH\\SQLEXPRESS;Initial Catalog=kanbagis;Integrated Security=True");
        private void DonorListesi_Load(object sender, EventArgs e)
        {
         
            this.donorTableAdapter.Fill(this.kanbagisDataSet1.donor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM Donor WHERE ad_soyad=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
