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
    public partial class RezervasyonTipi : Form
    {
        public RezervasyonTipi()
        {
            InitializeComponent();
        }

        private void btnOnOdemeli_Click(object sender, EventArgs e)
        {
            OnOdemeliRezervasyon s = new OnOdemeliRezervasyon();
            s.Show();
        }

        private void btnOnceden_Click(object sender, EventArgs e)
        {
            AlymisGunOncedenRezervasyon a = new AlymisGunOncedenRezervasyon();
            a.Show();
        }

        private void btnStandart_Click(object sender, EventArgs e)
        {
            StandartRezervasyon c = new StandartRezervasyon();
            c.Show();
        }

        private void btnTesvik_Click(object sender, EventArgs e)
        {
            TesvikRezervasyon d = new TesvikRezervasyon();
            d.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
