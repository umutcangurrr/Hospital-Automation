using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ReceteGiris : Form
    {
        public ReceteGiris()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database=hastane; user ID=postgres; password=1234");


        public int VeriAlıcı;
        private void ilaclarıGosterBtn_Click(object sender, EventArgs e)
        {
            
            string sorgu = "select barkodno,adı,tipi from ilac order by barkodno";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ilaclarDgw.DataSource = ds.Tables[0];
        }

        private void ReceteGiris_Load(object sender, EventArgs e)
        {

        }

        private void ilacEkleBtn_Click(object sender, EventArgs e)
        {
            int bos = 0;
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into recete(receteno,ilacbarkod1,ilacbarkod2,ilacbarkod3,ilacbarkod4,ilacbarkod5,recete_tarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",baglanti);
            komut1.Parameters.AddWithValue("@p1", VeriAlıcı);
            komut1.Parameters.AddWithValue("@p2", Convert.ToInt32(ilac1Txt.Text));
            if (ilac2Txt.Text == "")
            {
                komut1.Parameters.AddWithValue("@p3", bos);
            }
            else
            {
                komut1.Parameters.AddWithValue("@p3", Convert.ToInt32(ilac2Txt.Text));
            }


            if (ilac3Txt.Text == "")
            {
                komut1.Parameters.AddWithValue("@p4", bos);
            }
            else
            {
                komut1.Parameters.AddWithValue("@p4", Convert.ToInt32(ilac3Txt.Text));
            }


            if (ilac4Txt.Text == "")
            {
                komut1.Parameters.AddWithValue("@p5", bos);
            }
            else
            {
                komut1.Parameters.AddWithValue("@p5", Convert.ToInt32(ilac4Txt.Text));
            }

            if (ilac5Txt.Text == "")
            {
                komut1.Parameters.AddWithValue("@p6", bos);
            }
            else
            {
                komut1.Parameters.AddWithValue("@p6", Convert.ToInt32(ilac5Txt.Text));
            }


            komut1.Parameters.AddWithValue("@p7", DateTime.Now);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Başarılı");


            ;        }
    }
}
