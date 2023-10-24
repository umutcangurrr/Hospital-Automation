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
    public partial class ReceteListele : Form
    {

        public ReceteListele()
        {
            InitializeComponent();
        }


        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database=hastane; user ID=postgres; password=1234");
        private void receteListeleBtn_Click(object sender, EventArgs e)
        {
            //Tablo yansıtılıyor.
            string sorgu = "select receteno,ilacbarkod1,ilacbarkod2,ilacbarkod3,ilacbarkod4,ilacbarkod5,recete_tarihi from recete order by recete_tarihi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            receteListeleDgw.DataSource = ds.Tables[0];
        }

        private void muayneKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneKaydi mk = new MuayeneKaydi();
            mk.Show();
            this.Close();
        }

        private void hastanınKullandığıİlaçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastayaReceteEdilenİlaçlar hi = new HastayaReceteEdilenİlaçlar();
            hi.Show();
            this.Close();
        }

        private void muayeneListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneListele ml = new MuayeneListele();
            ml.Show();
            this.Close();
        }
    }
}
