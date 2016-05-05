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
    public partial class PracownikDEPrzedmioty : Form
    {
        private przedmiot przedmiot;

        public PracownikDEPrzedmioty(przedmiot prz)
        {
            InitializeComponent();
            this.przedmiot = prz;
            if(przedmiot == null)
            {
                przedmiot = new przedmiot();
            }
            else
            {
                tbnazwa.Text = Przedmiot.nazwa;
                tbid_przedmiotu.Text = Przedmiot.id_przedmiot.ToString();
                tbile_godzin.Text = przedmiot.ile_godzin.ToString();
                tbtyp_zajec.Text = przedmiot.typ_zajec;
                tbsemestr.Text = przedmiot.semestr.ToString();
                tbid_specjalnosc.Text = przedmiot.id_specjalnosc.ToString();
                tbid_pracownik.Text = przedmiot.id_przedmiot.ToString();
                tbid_katedra.Text = przedmiot.id_katedra.ToString();
            }
        }

        public przedmiot Przedmiot
        {
            get
            {
                return przedmiot;
            }
            set
            {
                przedmiot = value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            przedmiot.nazwa = tbnazwa.Text;

            decimal v;
            decimal.TryParse(tbid_przedmiotu.Text, out v);
            przedmiot.id_przedmiot = v;

            int h;
            int.TryParse(tbile_godzin.Text, out h);
            przedmiot.ile_godzin = h;

            przedmiot.typ_zajec = tbtyp_zajec.Text;

            int.TryParse(tbsemestr.Text, out h);
            przedmiot.semestr = h;

            decimal.TryParse(tbid_specjalnosc.Text, out v);
            przedmiot.id_specjalnosc = v;

            decimal.TryParse(tbid_katedra.Text, out v);
            przedmiot.id_katedra = v;

            decimal.TryParse(tbid_pracownik.Text, out v);
            przedmiot.id_pracownik = v;
            this.Close();
        }
    }
}
