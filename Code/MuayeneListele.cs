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
    public partial class MuayeneListele : Form
    {
        public MuayeneListele()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database=hastane; user ID=postgres; password=1234");
        private void muayeneListeleBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select sira_no,tarih,ad_soyad,tc,dogum_yeri,dogum_tarihi,bulgular,teshis,tedavi,receteno from muayne order by tarih";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            muayeneListeleDgw.DataSource = ds.Tables[0];


            bool kontrol = true;
           //Sonsuz bir döngü var random bir sayı üretiliyor ve bu random sayı tablodaki diğer sayılardan biri olmasın diye kontrol ediliyor bu şartlar sağlanırsa döngüden çıkılıyor.
           for (int a =0; a>1; a--)
                {

                Random rastgele = new Random();
                int sayi = rastgele.Next(999, 10000);

                for (int i = 0; i < muayeneListeleDgw.Rows.Count; i++)
            {
                if (Convert.ToInt32(muayeneListeleDgw.Rows[i].Cells[0].Value) == sayi) { 
                    kontrol = false;
                }


            }
                if (kontrol == true)
                    break;

            }


        }

        private void muayneKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneKaydi mk = new MuayeneKaydi();
            mk.Show();
            this.Close();
            

            
        }

        private void yazılanReçetelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceteListele rl = new ReceteListele();
            rl.Show();
            this.Close();
                
        }

        private void hastanınKullandığıİlaçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastayaReceteEdilenİlaçlar hi = new HastayaReceteEdilenİlaçlar();
            hi.Show();
            this.Close();

            
                
            
        }
    }
}
