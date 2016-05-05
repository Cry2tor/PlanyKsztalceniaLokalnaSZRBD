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
    public partial class PracownikStypendium : Form
    {
        PlanyEntities3 db = new PlanyEntities3();
        public PracownikStypendium()
        {
            InitializeComponent();
        }

        private void PracownikStypendium_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet36.stypendium' table. You can move, or remove it, as needed.
            this.stypendiumTableAdapter.Fill(this.planyDataSet36.stypendium);

        }

        private void OdswiezDane()
        {
            stypendiumBindingSource.DataSource = db.stypendium.ToList();
        }

        private void zakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            PracownicyDEStypendium de = new PracownicyDEStypendium(null);
            de.ShowDialog();

            db.stypendium.Add(de.Stypendium);
            db.SaveChanges();
            OdswiezDane();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            PracownicyDEStypendium de = new PracownicyDEStypendium(stypendiumBindingSource.Current as stypendium);
            de.ShowDialog();

            db.SaveChanges();
            OdswiezDane();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            stypendium to = stypendiumBindingSource.Current as stypendium;

            db.stypendium.Remove(to);
            db.SaveChanges();
            OdswiezDane();
        }
    }
}
