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
    public partial class IlkGiris : Form
    {
        public IlkGiris()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 3;
            if (panel3.Width>=599)
            {
                timer1.Stop();
                ANASAYFA frm4 = new ANASAYFA();
                frm4.Show();
                this.Hide();
            }
        }
    }
}
