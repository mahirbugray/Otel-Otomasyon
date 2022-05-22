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
    public partial class Musteriler : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=UBEYD-PC;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        public void populate()
        {
            con.Open();
            string Myquery = "select * from tblMusteri";
            SqlDataAdapter da = new SqlDataAdapter(Myquery,con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            MusteriBilgiGridview2.DataSource = ds.Tables[0];

            con.Close();
        }
        public Musteriler()
        {
            InitializeComponent();
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblMusteri(MusteriAd,MusteriSoyad,MusteriEposta,MusteriTcNo) values (@p1,@p2,@p3,@p4)",con);
            cmd.Parameters.AddWithValue("@p1", MusteriAditxt.Text);
            cmd.Parameters.AddWithValue("@p2", Soyadtxt.Text);
            cmd.Parameters.AddWithValue("@p3", Epostatxt.Text);
            cmd.Parameters.AddWithValue("@p4", TCNotxt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            populate();
            
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void MusteriBilgiGridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from tblMusteri where MusteriAd=@p1";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@p1", MusteriAditxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("musteri silindi");
            con.Close();
            populate();
        }

        private void MusteriBilgiGridview2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MusteriAditxt.Text = MusteriBilgiGridview2.SelectedRows[0].Cells[1].Value.ToString();
            Soyadtxt.Text= MusteriBilgiGridview2.SelectedRows[0].Cells[2].Value.ToString();
            Epostatxt.Text= MusteriBilgiGridview2.SelectedRows[0].Cells[3].Value.ToString();
            TCNotxt.Text= MusteriBilgiGridview2.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
