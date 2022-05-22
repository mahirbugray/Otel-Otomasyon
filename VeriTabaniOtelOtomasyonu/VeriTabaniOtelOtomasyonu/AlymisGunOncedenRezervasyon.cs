using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeriTabaniOtelOtomasyonu
{
    public partial class AlymisGunOncedenRezervasyon : Form
    {
        public AlymisGunOncedenRezervasyon()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=UBEYD-PC;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        DateTime today;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
        }
        public void populate()
        {
            con.Open();
            string Myquery = "select RezervasyonTipi,RezervasyonNo,MusteriId,OdaId,GelisTarihi,GidisTarihi from tblRezervasyon";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RezervasyonBilgiGridview.DataSource = ds.Tables[0];
            con.Close();
        }
        public void fillOdacombo()
        {
            con.Open();
            string OdaDurumu = "Bos";
            SqlCommand cmd = new SqlCommand("select OdaId from tblOda where BosDolu ='" + OdaDurumu + "'", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("OdaId", typeof(int));
            dt.Load(rdr);
            OdaNoCmbox.ValueMember = "OdaId";
            OdaNoCmbox.DataSource = dt;
            con.Close();
        }
        public void fillMustericombo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select MusteriId from tblMusteri", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MusteriId", typeof(int));
            dt.Load(rdr);
            MusteriIdCmbox.ValueMember = "MusteriId";
            MusteriIdCmbox.DataSource = dt;
            con.Close();
        }

        private void AlymisGunOncedenRezervasyon_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            today = GirisGunu.Value;
            populate();
            fillOdacombo();
            fillMustericombo();
        }
        public void updateOdaDurum()
        {
            con.Open();
            string yenidurum = "Dolu";
            string query = "update tblOda set BosDolu=@p1 where OdaId=@p2";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@p1", yenidurum);
            cmd.Parameters.AddWithValue("@p2", OdaNoCmbox.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Oda düzenlendi");
            con.Close();
            fillOdacombo();

        }
        public void updateOdaSilme()
        {
            con.Open();
            string yenidurum = "Bos";
            string odaId = RezervasyonBilgiGridview.SelectedRows[0].Cells[3].Value.ToString();
            string query = "update tblOda set BosDolu=@p1 where OdaId=@p2";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@p1", yenidurum);
            cmd.Parameters.AddWithValue("@p2", odaId);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Oda düzenlendi");
            con.Close();
            fillOdacombo();

        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            if (RezerNotxt.Text == "")
            {
                MessageBox.Show("Silmek için rezervasyon seçiniz!!");
            }
            else
            {
                con.Open();
                string query = "delete from tblRezervasyon where RezervasyonNo=@p1";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p1", RezerNotxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Oda silindi");
                con.Close();
                updateOdaSilme();
                populate();
            }
        }

        private void Duzenlebtn_Click(object sender, EventArgs e)
        {
            if (RezerTipitxt.Text == "")
            {
                MessageBox.Show("Rezervasyon tipi boş, rezervasyon tipi giriniz");
            }
            else
            {
                con.Open();
                string query = "update tblRezervasyon set RezervasyonTipi=@p1,RezervasyonNo=@p2,GelisTarihi=@p3,GidisTarihi=@p4 where OdaId=@p5";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p1", RezerTipitxt.Text);
                cmd.Parameters.AddWithValue("@p2", RezerNotxt.Text);
                cmd.Parameters.AddWithValue("@p3", GirisGunu.Value);
                cmd.Parameters.AddWithValue("@p4", CikisGunu.Value);
                cmd.Parameters.AddWithValue("@p5", OdaNoCmbox.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Oda düzenlendi");
                con.Close();
                populate();
            }
        }

        private void RezervasyonBilgiGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RezerTipitxt.Text = RezervasyonBilgiGridview.SelectedRows[0].Cells[0].Value.ToString();
            RezerNotxt.Text = RezervasyonBilgiGridview.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblRezervasyon(RezervasyonTipi,RezervasyonNo,MusteriId,OdaId,GelisTarihi,GidisTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6)", con);
            cmd.Parameters.AddWithValue("@p1", "altmisGunOnce");
            cmd.Parameters.AddWithValue("@p2", RezerNotxt.Text);
            cmd.Parameters.AddWithValue("@p3", MusteriIdCmbox.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@p4", OdaNoCmbox.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@p5", GirisGunu.Value);
            cmd.Parameters.AddWithValue("@p6", CikisGunu.Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Rezervasyon eklendi");
            con.Close();
            updateOdaDurum();
            populate();
        }

        private void GirisGunu_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark = Convert.ToDateTime(GirisGunu.Value) - Convert.ToDateTime(today);
            int fark1 = Convert.ToInt32(fark.TotalDays);
            // int res = DateTime.Compare(GirisGunu.Value, today);
            if (fark1 < 60)
            {
                MessageBox.Show("Geçersiz Rezervasyon Günü");
            }
        }

        private void CikisGunu_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(CikisGunu.Value, GirisGunu.Value);
            if (res < 0)
            {
                MessageBox.Show("Geçersiz Rezervasyon Günü Aralığı");
            }
        }
        }
}
