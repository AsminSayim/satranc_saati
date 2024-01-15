using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satranc_saati
{
    public partial class Form1 : Form
    {
        int sayacBeyaz = 10;
        int sayacSiyah = 10;
        public Form1()
        {
            InitializeComponent();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            tmBeyaz.Start();
            this.BackColor = Color.White;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayacBeyaz--;
            lblBeyaz.Text = sayacBeyaz.ToString();

            if (sayacBeyaz <= 0)
            {
                tmBeyaz.Stop();

                lblMesaj.Text = "SİYAH KAZANDI";
            }
        }

        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            tmBeyaz.Stop();

            tmSiyah.Start();
        }

        private void btnSiyah_Click(object sender, EventArgs e)
        {
            tmSiyah.Stop();

            tmBeyaz.Start();

        }

        private void tmSiyah_Tick(object sender, EventArgs e)
        {
            sayacSiyah--;
            lblSiyah.Text = sayacSiyah.ToString();

            if (sayacSiyah <= 0)
            {
                tmSiyah.Stop();

                lblMesaj.Text = "BEYAZ KAZANDI";
            }
        }
    }

    
}
