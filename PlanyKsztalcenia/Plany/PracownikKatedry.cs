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
    public partial class PracownikKatedry : Form
    {
        PlanyEntities3 db = new PlanyEntities3();

        public PracownikKatedry()
        {
            InitializeComponent();

        }

        private void PracownikKatedry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet28.katedra' table. You can move, or remove it, as needed.
            this.katedraTableAdapter.Fill(this.planyDataSet28.katedra);
        }

        private void pracownikKatedraZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OdswiezDane()
        {
            katedraBindingSource.DataSource = db.katedra.ToList();
        }

        private void pracownikKatedraDodaj_Click(object sender, EventArgs e)
        {
            PracownikDEKatedry de = new PracownikDEKatedry(null);
            de.ShowDialog();

            db.katedra.Add(de.Katedra);
            db.SaveChanges();
            OdswiezDane();
        }

        private void pracownikKatedraEdytuj_Click(object sender, EventArgs e)
        {
            PracownikDEKatedry de = new PracownikDEKatedry(katedraBindingSource.Current as katedra);
            de.ShowDialog();

            db.SaveChanges();
            OdswiezDane();
        }

        private void pracownikKatedraUsun_Click(object sender, EventArgs e)
        {
            katedra ta = katedraBindingSource.Current as katedra;

            db.katedra.Remove(ta);
            db.SaveChanges();
            OdswiezDane();

        }
    }
}
