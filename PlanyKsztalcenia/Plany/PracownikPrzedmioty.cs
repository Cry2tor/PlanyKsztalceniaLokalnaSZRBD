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
    public partial class PracownikPrzedmioty : Form
    {
        PlanyEntities3 db = new PlanyEntities3();
        public PracownikPrzedmioty()
        {
            InitializeComponent();
        }

        public void OdswiezDane()
        {
            przedmiotBindingSource.DataSource = db.przedmiot.ToList();
        }

        private void PracownikPrzedmioty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet19.przedmiot' table. You can move, or remove it, as needed.
            this.przedmiotTableAdapter.Fill(this.planyDataSet19.przedmiot);

        }

        private void Zakoncz_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            PracownikDEPrzedmioty de = new PracownikDEPrzedmioty(null);
            de.ShowDialog();

            db.przedmiot.Add(de.Przedmiot);
            db.SaveChanges();
            OdswiezDane();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            PracownikDEPrzedmioty de = new PracownikDEPrzedmioty(przedmiotBindingSource.Current as przedmiot);
            de.ShowDialog();

            db.SaveChanges();
            OdswiezDane();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            przedmiot ten = przedmiotBindingSource.Current as przedmiot;

            db.przedmiot.Remove(ten);
            db.SaveChanges();
            OdswiezDane();
        }
    }
}
