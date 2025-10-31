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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            DonorListesi donorListesi = new DonorListesi();
            donorListesi.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HastaListesi hastaListesi = new HastaListesi();
            hastaListesi.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            KanStok kanStok= new KanStok();
            kanStok.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            kanbagis kanbagis=new kanbagis();
            kanbagis.Show();
        }
    }
}
