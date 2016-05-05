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
    public partial class PracownicyDEStypendium : Form
    {
        private stypendium stypendium;
        public PracownicyDEStypendium(stypendium sty)
        {
            InitializeComponent();
            this.stypendium = sty;
            if(stypendium == null)
            {
                stypendium = new stypendium();
            }
            else
            {
                tbid_stypendium.Text = stypendium.id_stypendum.ToString();
                tbkwota.Text = stypendium.kwota.ToString();
                tbrodzaj.Text = stypendium.rodzaj;
            }
        }


        public stypendium Stypendium
        {
            get
            {
                return stypendium;
            }
            set
            {
                stypendium = value;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            decimal v;
            decimal.TryParse(tbid_stypendium.Text, out v);
            stypendium.id_stypendum = v;

            decimal.TryParse(tbkwota.Text, out v);
            stypendium.kwota = v;

            stypendium.rodzaj = tbrodzaj.Text;

            this.Close();
        }
    }
}
