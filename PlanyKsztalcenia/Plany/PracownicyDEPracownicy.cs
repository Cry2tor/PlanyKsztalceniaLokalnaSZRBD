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
    public partial class PracownicyDEPracownicy : Form
    {
        private pracownicy pracownicy;
        public PracownicyDEPracownicy(pracownicy prac)
        {
            InitializeComponent();
            this.pracownicy = prac;
            if(pracownicy == null)
            {
                pracownicy = new pracownicy();
            }
            else
            {
                tbid_katedry.Text = pracownicy.id_katedra.ToString();
                tbid_pracownika.Text = pracownicy.id_pracownik.ToString();
                tbid_wykladowcy.Text = pracownicy.id_wykladowcy.ToString();
                tbkategoria.Text = pracownicy.kategoria;
                tbstopien.Text = pracownicy.stopien.ToString();
                tbimie.Text = pracownicy.imie;
                tbnazwisko.Text = pracownicy.nazwisko;
                tbplec.Text = pracownicy.plec;
                tbdzieci.Text = pracownicy.obecnosc_dzieci.ToString();
                tbile_dzieci.Text = pracownicy.ile_dzieci.ToString();
                tbLogin.Text = pracownicy.login;
                tbHaslo.Text = pracownicy.haslo;
                tbpokoj.Text = pracownicy.rok_urodzenia.ToString();
                tbrok.Text = pracownicy.rok_urodzenia.ToString();
                tbczy_wykladowca.Text = pracownicy.czy_wykladowca;
            }
        }

        public pracownicy Pracownicy
        {
            get
            {
                return pracownicy;
            }
            set
            {
                pracownicy = value;
            }
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {

            decimal v;
            decimal.TryParse(tbid_katedry.Text, out v);
            pracownicy.id_katedra = v;

            decimal.TryParse(tbid_pracownika.Text, out v);
            pracownicy.id_pracownik = v;

            decimal.TryParse(tbid_wykladowcy.Text, out v);
            pracownicy.id_wykladowcy = v;

            pracownicy.kategoria = tbkategoria.Text;

            pracownicy.stopien = tbstopien.Text;

            int h;
            int.TryParse(tbpokoj.Text, out h);
            pracownicy.pokój = h;

            pracownicy.haslo = tbHaslo.Text;

            int.TryParse(tbile_dzieci.Text, out h);
            pracownicy.ile_dzieci = h;

            pracownicy.imie = tbimie.Text;

            pracownicy.login = tbLogin.Text;

            pracownicy.nazwisko = tbnazwisko.Text;

            short s;
            short.TryParse(tbdzieci.Text, out s);
            pracownicy.obecnosc_dzieci = s;

            pracownicy.plec = tbplec.Text;

            int.TryParse(tbrok.Text, out h);
            pracownicy.rok_urodzenia = h;

            pracownicy.czy_wykladowca = tbczy_wykladowca.Text;
            this.Close();
        }
    }
}
