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
    public partial class PracownicyPracownicy : Form
    {

        PlanyEntities3 db = new PlanyEntities3();
        public PracownicyPracownicy()
        {
            InitializeComponent();
        }

        private void PracownicyPracownicy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet31.pracownicy' table. You can move, or remove it, as needed.
            this.pracownicyTableAdapter.Fill(this.planyDataSet31.pracownicy);
        }

        public void OdswiezDane()
        {
            pracownicyBindingSource.DataSource = db.pracownicy.ToList();
        }

        private void zakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            pracownicy ci = pracownicyBindingSource.Current as pracownicy;

            db.pracownicy.Remove(ci);
            db.SaveChanges();
            OdswiezDane();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            PracownicyDEPracownicy de = new PracownicyDEPracownicy(pracownicyBindingSource.Current as pracownicy);
            de.ShowDialog();

            db.SaveChanges();
            OdswiezDane();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            PracownicyDEPracownicy de = new PracownicyDEPracownicy(null);
            de.ShowDialog();

            db.pracownicy.Add(de.Pracownicy);
            db.SaveChanges();
            OdswiezDane();

        }
    }
}
