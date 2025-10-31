using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBagis
{
    public partial class KanStok : Form
    {
        public KanStok()
        {
            InitializeComponent();
        }

        private void KanStok_Load(object sender, EventArgs e)
        {
          
            this.kan_stoguTableAdapter1.Fill(this.kanbagisDataSet5.kan_stogu);
            this.kan_stoguTableAdapter.Fill(this.kanbagisDataSet4.kan_stogu);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
