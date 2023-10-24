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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void muayeneKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneKaydi mk = new MuayeneKaydi();
            mk.Show();
            this.Hide();
        }

        private void yazılanReçetelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceteListele rl = new ReceteListele();
            rl.Show();
            this.Hide();
        }

        private void muayeneListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneListele ml = new MuayeneListele();
            ml.Show();
            this.Hide();
                
        }

        private void hastanınKullandığıİlaçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastayaReceteEdilenİlaçlar hi = new HastayaReceteEdilenİlaçlar();
            hi.Show();
            this.Hide();
        }
    }
}
