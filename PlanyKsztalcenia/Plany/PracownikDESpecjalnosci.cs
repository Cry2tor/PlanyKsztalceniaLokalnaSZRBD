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
    public partial class PracownikDESpecjalnosci : Form
    {
        private specjalnosc specjalnosc;

        public PracownikDESpecjalnosci(specjalnosc spec)
        {
            InitializeComponent();
            this.specjalnosc = spec;
            if(specjalnosc == null)
            {
                specjalnosc = new specjalnosc();
            }
            else
            {
                tbid_specjalnosc.Text = specjalnosc.id_specjalnosc.ToString();
                tbid_katedra.Text = specjalnosc.id_katedra.ToString();
                tbnazwa.Text = specjalnosc.nazwa;
                tbstopien.Text = specjalnosc.stopien.ToString();
            }
        }

        public specjalnosc Specjalnosc
        {
            get
            {
                return specjalnosc;
            }
            set
            {
                specjalnosc = value;
            }
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            decimal v;
            decimal.TryParse(tbid_katedra.Text, out v);
            specjalnosc.id_katedra = v;

            decimal.TryParse(tbid_specjalnosc.Text, out v);
            specjalnosc.id_specjalnosc = v;

            specjalnosc.nazwa = tbnazwa.Text;

            decimal.TryParse(tbstopien.Text, out v);
            specjalnosc.stopien = v;

            this.Close();
        }
    }
}
