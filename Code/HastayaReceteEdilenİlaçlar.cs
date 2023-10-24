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
    public partial class HastayaReceteEdilenİlaçlar : Form
    {
        public HastayaReceteEdilenİlaçlar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database=hastane; user ID=postgres; password=1234");
        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            //Tabloya yansıtma
            string sorgu = "select m.ad_soyad,m.tc,m.receteno,r.ilacbarkod1,r.ilacbarkod2,r.ilacbarkod3,r.ilacbarkod4,r.ilacbarkod5,r.recete_tarihi from muayne as m INNER JOIN recete as r ON r.receteno = m.receteno";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            receteliİlaclarDgw.DataSource = ds.Tables[0];

            for (int i = 0; i < receteliİlaclarDgw.Rows.Count; i++)
            {
                if (Convert.ToString(receteliİlaclarDgw.Rows[i].Cells[1].Value) == hastaTcTxt.Text)
                {
                    MessageBox.Show("Hasta İsmi:" +Convert.ToString(receteliİlaclarDgw.Rows[i].Cells[0].Value) + "\nRecete No:" + Convert.ToString(receteliİlaclarDgw.Rows[i].Cells[2].Value)
                        + "\nİlac Barkod:" + Convert.ToString(receteliİlaclarDgw.Rows[i].Cells[3].Value) + "\nİlac Barkod:" + Convert.ToString(receteliİlaclarDgw.Rows[i].Cells[4].Value)
                        + "\nİlac Barkod:" + Convert.ToString(receteliİlaclarDgw.Rows[i].Cells[5].Value) + "\nİlac Barkod:" + Convert.ToString(receteliİlaclarDgw.Rows[i].Cells[6].Value)
                        + "\nİlac Barkod:" + Convert.ToString(receteliİlaclarDgw.Rows[i].Cells[7].Value) + "\nRecete Tarihi:" + Convert.ToString(receteliİlaclarDgw.Rows[i].Cells[8].Value));
                }

                

            }
        }
    }
}
