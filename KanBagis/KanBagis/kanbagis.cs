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
    public partial class kanbagis : Form
    {
        public kanbagis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-4BP5RBKH\\SQLEXPRESS;Initial Catalog=kanbagis;Integrated Security=True");
        private void kanbagis_Load(object sender, EventArgs e)
        {
           
            this.donorTableAdapter.Fill(this.kanbagisDataSet9.donor);
            this.kan_stoguTableAdapter.Fill(this.kanbagisDataSet8.kan_stogu);

        }


        
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int stok = 1;
            SqlCommand komut = new SqlCommand("UPDATE kan_stogu SET kanstok = kanstok + " + stok + " WHERE kangrubu = '" + textBox2.Text + "'", baglanti);
                     
            komut.ExecuteNonQuery();
            MessageBox.Show("Bağış Başarılı");
            baglanti.Close();
            
           

        }
    }
}
