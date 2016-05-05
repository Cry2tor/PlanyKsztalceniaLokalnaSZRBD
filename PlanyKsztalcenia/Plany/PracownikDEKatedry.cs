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
    public partial class PracownikDEKatedry : Form
    {
        private katedra katedra;
        public PracownikDEKatedry(katedra kat)
        {
            InitializeComponent();
            this.katedra = kat;

            if(katedra == null)
            {
                katedra = new katedra();
            }
            else
            {
                tbid_katedra.Text = katedra.id_katedra.ToString();
                tbnazwa.Text = katedra.nazwa;
                tbid_kierunku.Text = katedra.id_kierunek.ToString();
            }

        }

        public katedra Katedra
        {
            get
            {
                return katedra;
            }
            set
            {
                katedra = value;
            }
        }

        private void pdeKatedraZapisz_Click(object sender, EventArgs e)
        {
            decimal v;
            decimal.TryParse(tbid_katedra.Text, out v);
            katedra.id_katedra = v;

            katedra.nazwa = tbnazwa.Text;

            decimal.TryParse(tbid_kierunku.Text, out v);
            katedra.id_kierunek = v;

            this.Close();
        }
    }
}
