using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabaniOtelOtomasyonu
{
    public partial class ANASAYFA : Form
    {
        public ANASAYFA()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RezervasyonTipi frm = new RezervasyonTipi();
            frm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler frm2 = new Musteriler();
            frm2.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odalar frm3 = new Odalar();
            frm3.Show();
         
        }

        private void ANASAYFA_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
