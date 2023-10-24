
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
    public partial class MuayeneKaydi : Form
    {
        public MuayeneKaydi()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database=hastane; user ID=postgres; password=1234");
        

        private void receteYazBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select sira_no,tarih,ad_soyad,tc,dogum_yeri,dogum_tarihi,bulgular,teshis,tedavi,receteno from muayne order by tarih";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            musteriKaydındaListDgw.DataSource = ds.Tables[0];


            bool kontrol = true;
            int sayi = 0;
            // Sonsuz bir döngü var koşullar sağlanana kadar döngü devam ediyor.
            for (int a = 0; a > -1; a++)
            {

                Random rastgele = new Random();
                sayi = rastgele.Next(999, 10000);

                for (int i = 0; i < musteriKaydındaListDgw.Rows.Count; i++)
                {
                    if (Convert.ToInt32(musteriKaydındaListDgw.Rows[i].Cells[9].Value) == sayi)
                    {
                        kontrol = false;
                    }


                }
                if (kontrol == true)
                    break;

            }

            bool kontrol2 = true;
             
            for (int i = 0; i < musteriKaydındaListDgw.Rows.Count; i++)
            {
                if (Convert.ToString(musteriKaydındaListDgw.Rows[i].Cells[3].Value) == tcTxt.Text)
                    kontrol2 = false;
            }

            if (kontrol2 == true) { 
            MuayeneListele ml = new MuayeneListele();
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into muayne (sira_no,tarih,ad_soyad,dogum_yeri,dogum_tarihi,bulgular,teshis,tedavi,tc,hasta_sikayet,hasta_adres,hasta_telefon,medenidurum,receteno) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(sıraNoTxt.Text));
            komut1.Parameters.AddWithValue("@p2", DateTime.Now);
            komut1.Parameters.AddWithValue("@p3", adSoyadTxt.Text);
            komut1.Parameters.AddWithValue("@p4", dogumYeriTxt.Text);
            komut1.Parameters.AddWithValue("@p5", dogumTarihiTxt.Text);
            komut1.Parameters.AddWithValue("@p6", bulgularTxt.Text);
            komut1.Parameters.AddWithValue("@p7", teshisTxt.Text);
            komut1.Parameters.AddWithValue("@p8", tedaviTxt.Text);
            komut1.Parameters.AddWithValue("@p9", tcTxt.Text);
            komut1.Parameters.AddWithValue("@p10", hastaSikayetiTxt.Text);
            komut1.Parameters.AddWithValue("@p11", adresTxt.Text);
            komut1.Parameters.AddWithValue("@p12", telefonTxt.Text);
            komut1.Parameters.AddWithValue("@p13", medeniDurumTxt.Text);

           

            komut1.Parameters.AddWithValue("@p14", sayi);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Başarılı");

            ReceteGiris rg = new ReceteGiris();
            rg.VeriAlıcı = sayi;
            rg.Show();

            }

            else
            {
                MessageBox.Show("Bu TC'ye sahip hasta bu gün muayne oldu. Muayne geçersiz.");
            }


        }


        private void MuayeneKaydi_Load(object sender, EventArgs e)
        {

        }

        private void yazılanReçetelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceteListele rl = new ReceteListele();
            rl.Show();
            this.Close();
        }

        private void recetesizİslemBtn_Click(object sender, EventArgs e)
        {
            //Tablo yansıtılıyor
            string sorgu = "select sira_no,tarih,ad_soyad,tc,dogum_yeri,dogum_tarihi,bulgular,teshis,tedavi,receteno from muayne order by tarih";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            musteriKaydındaListDgw.DataSource = ds.Tables[0];

            bool kontrol1 = true;

            for (int i = 0; i < musteriKaydındaListDgw.Rows.Count; i++)
            {
                if (Convert.ToString(musteriKaydındaListDgw.Rows[i].Cells[3].Value) == tcTxt.Text)
                    kontrol1 = false;
            }

            if(kontrol1==true) { 
            baglanti.Open();
            // Kayıt için parametreler oluşturuluyor.
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into muayne (sira_no,tarih,ad_soyad,dogum_yeri,dogum_tarihi,bulgular,teshis,tedavi,tc,hasta_sikayet,hasta_adres,hasta_telefon,medenidurum,receteno) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(sıraNoTxt.Text));
            komut1.Parameters.AddWithValue("@p2", DateTime.Now);
            komut1.Parameters.AddWithValue("@p3", adSoyadTxt.Text);
            komut1.Parameters.AddWithValue("@p4", dogumYeriTxt.Text);
            komut1.Parameters.AddWithValue("@p5", dogumTarihiTxt.Text);
            komut1.Parameters.AddWithValue("@p6", bulgularTxt.Text);
            komut1.Parameters.AddWithValue("@p7", teshisTxt.Text);
            komut1.Parameters.AddWithValue("@p8", tedaviTxt.Text);
            komut1.Parameters.AddWithValue("@p9", tcTxt.Text);
            komut1.Parameters.AddWithValue("@p10", hastaSikayetiTxt.Text);
            komut1.Parameters.AddWithValue("@p11", adresTxt.Text);
            komut1.Parameters.AddWithValue("@p12", telefonTxt.Text);
            komut1.Parameters.AddWithValue("@p13", medeniDurumTxt.Text);
            Random rastgele = new Random();
            int sayi = rastgele.Next(999, 10000);
            komut1.Parameters.AddWithValue("@p14", sayi);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Başarılı");
            }

            else
            {
                MessageBox.Show("Bu TC'ye sahip hasta bu gün muayne oldu. Muayne geçersiz.");
            }
        }

        private void hastanınKullandığıİlaçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastayaReceteEdilenİlaçlar hr = new HastayaReceteEdilenİlaçlar();
            hr.Show();
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
