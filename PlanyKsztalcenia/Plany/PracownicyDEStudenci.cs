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
    public partial class PracownicyDEStudenci : Form
    {
        private studenci studenci;
        public PracownicyDEStudenci(studenci stu)
        {
            InitializeComponent();
            this.studenci = stu;
            if(studenci == null)
            {
                studenci = new studenci();
            }
            else
            {
                tbid_katedry.Text = studenci.id_katedra.ToString();
                tbid_kierunek.Text = studenci.id_kierunek.ToString();
                tbid_specjalnosc.Text = studenci.id_specjalnosc.ToString();
                tbid_studenta.Text = studenci.id_studenci.ToString();
                tbid_stypendium.Text = studenci.id_stypendum.ToString();
                tbimie.Text = studenci.imie;
                tbnazwisko.Text = studenci.nazwisko;
                tbplec.Text = studenci.plec;
                tbdzieci.Text = studenci.obecnosc_dzieci.ToString();
                tbile_dzieci.Text = studenci.ile_dzieci.ToString();
                tblogin.Text = studenci.login;
                tbhaslo.Text = studenci.haslo;
                tbgrupa.Text = studenci.grupa;
                tbrok.Text = studenci.rok_urodzenia.ToString();
            }
        }

        public studenci Student
        {
            get
            {
                return studenci;
            }
            set
            {
                studenci = value;
            }
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            decimal v;
            decimal.TryParse(tbid_katedry.Text, out v);
            studenci.id_katedra = v;

            decimal.TryParse(tbid_kierunek.Text, out v);
            studenci.id_kierunek = v;

            decimal.TryParse(tbid_specjalnosc.Text, out v);
            studenci.id_specjalnosc = v;

            decimal.TryParse(tbid_studenta.Text, out v);
            studenci.id_studenci = v;

            decimal.TryParse(tbid_stypendium.Text, out v);
            studenci.id_stypendum = v;

            studenci.grupa = tbgrupa.Text;

            studenci.haslo = tbhaslo.Text;

            int h;
            int.TryParse(tbile_dzieci.Text, out h);
            studenci.ile_dzieci = h;

            studenci.imie = tbimie.Text;

            studenci.login = tblogin.Text;

            studenci.nazwisko = tbnazwisko.Text;

            short s;
            short.TryParse(tbdzieci.Text, out s);
            studenci.obecnosc_dzieci = s;

            studenci.plec = tbplec.Text;

            int.TryParse(tbrok.Text, out h);
            studenci.rok_urodzenia = h;

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
