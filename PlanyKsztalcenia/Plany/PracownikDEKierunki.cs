using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plany
{
    public partial class PracownikDEKierunki : Form
    {
        private kierunek kierunek;
        public PracownikDEKierunki(kierunek kier)
        {
            this.kierunek = kier;
            InitializeComponent();
            if(kierunek == null)
            {
                kierunek = new kierunek();
            }
            else
            {
                tbid_kierunek.Text = kierunek.id_kierunek.ToString();
                tbnazwa.Text = kierunek.nazwa;
                tbwydzial.Text = kierunek.wydzial;

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public kierunek Kierunek
        {
            get
            {
                return kierunek;
            }
            set
            {
                kierunek = value;
            }
        }
        private void pdeKierunkiZapisz_Click(object sender, EventArgs e)
        {
            int v;
            int.TryParse(tbid_kierunek.Text, out v);
            kierunek.id_kierunek = v;

            kierunek.nazwa = tbnazwa.Text;

            kierunek.wydzial = tbwydzial.Text;

            this.Close();
        }
    }
}
