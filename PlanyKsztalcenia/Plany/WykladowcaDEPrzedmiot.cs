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
    public partial class WykladowcaDEPrzedmiot : Form
    {
        private przedmiot przedmiot;


        public WykladowcaDEPrzedmiot(przedmiot przed)
        {
            InitializeComponent();
            this.przedmiot = przed;
            if (przedmiot == null)
            {
                // tworzymy nowego

                przedmiot = new przedmiot();

            }
            else
            {
                // edytujemy
                tbnazwa.Text = Przedmiot.nazwa;
                tbid_przedmiot.Text = Przedmiot.id_przedmiot.ToString();
                tbile_godzin.Text = przedmiot.ile_godzin.ToString();
                tbRodzajZajec.Text = przedmiot.typ_zajec;
                tbSemestr.Text = przedmiot.semestr.ToString();
                tbId_specjalnosc.Text = przedmiot.id_specjalnosc.ToString();
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

        private void dePZapisz_Click(object sender, EventArgs e)
        {
            przedmiot.nazwa = tbnazwa.Text;

            decimal v;
            decimal.TryParse(tbid_przedmiot.Text,out v);
            przedmiot.id_przedmiot = v;

            int h;
            int.TryParse(tbile_godzin.Text, out h);
            przedmiot.ile_godzin = h;

            przedmiot.typ_zajec = tbRodzajZajec.Text;

            int.TryParse(tbSemestr.Text, out h);
            przedmiot.semestr = h;

            decimal.TryParse(tbId_specjalnosc.Text, out v);
            przedmiot.id_specjalnosc = v;

            decimal.TryParse(tbid_katedra.Text, out v);
            przedmiot.id_katedra = v;

            decimal.TryParse(tbid_pracownik.Text, out v);
            przedmiot.id_pracownik = v;

            this.Close();
        }
    }
}
