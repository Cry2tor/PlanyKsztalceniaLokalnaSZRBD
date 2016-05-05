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
    public partial class PracownikSpecjalnosci : Form
    {
        PlanyEntities3 db = new PlanyEntities3();
        public PracownikSpecjalnosci()
        {
            InitializeComponent();
        }

        private void PracownikSpecjalnosci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet29.specjalnosc' table. You can move, or remove it, as needed.
            this.specjalnoscTableAdapter.Fill(this.planyDataSet29.specjalnosc);
        }

        public void OdswiezDane()
        {
            specjalnoscBindingSource.DataSource = db.specjalnosc.ToList();
        }

        private void zakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dod_Click(object sender, EventArgs e)
        {
            PracownikDESpecjalnosci de = new PracownikDESpecjalnosci(null);
            de.ShowDialog();

            db.specjalnosc.Add(de.Specjalnosc);
            db.SaveChanges();
            OdswiezDane();
        }

        private void edytuje_Click(object sender, EventArgs e)
        {
            PracownikDESpecjalnosci de = new PracownikDESpecjalnosci(specjalnoscBindingSource.Current as specjalnosc);
            de.ShowDialog();

            db.SaveChanges();
            OdswiezDane();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            specjalnosc ta = specjalnoscBindingSource.Current as specjalnosc;

            db.specjalnosc.Remove(ta);
            db.SaveChanges();
            OdswiezDane();
        }
    }
}
