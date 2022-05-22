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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=UBEYD-PC;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        public void populate()
        {
            con.Open();
            string Myquery = "select OdaId,BosDolu from tblOda";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OdaBilgiGridview.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Eklebtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (BosRbtn.Checked==true)
            {
                isfree = "Bos";
            }
            else
            {
                isfree = "Dolu";
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblOda(OdaId,BosDolu) values (@p1,@p3)", con);
            cmd.Parameters.AddWithValue("@p1", OdaIdtxt.Text);
            ////cmd.Parameters.AddWithValue("@p2", OdaNotxt.Text);
            cmd.Parameters.AddWithValue("@p3", isfree);
            cmd.ExecuteNonQuery();
            MessageBox.Show("oda eklendi");
            con.Close();
            populate();
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from tblOda where OdaId=@p1";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@p1", OdaIdtxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Oda silindi");
            con.Close();
            populate();
        }

        private void OdaBilgiGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OdaIdtxt.Text = OdaBilgiGridview.SelectedRows[0].Cells[0].Value.ToString();
            OdaNotxt.Text = OdaBilgiGridview.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Duzenlebtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (BosRbtn.Checked == true)
            {
                isfree = "Bos";
            }
            else
            {
                isfree = "Dolu";
            }
            con.Open();
            string query = "update tblOda set BosDolu=@p3 where OdaId=@p1";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@p1", OdaIdtxt.Text);
            //cmd.Parameters.AddWithValue("@p2", OdaNotxt.Text);
            cmd.Parameters.AddWithValue("@p3", isfree);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Oda düzenlendi");
            con.Close();
            populate();

        }
    }
}
