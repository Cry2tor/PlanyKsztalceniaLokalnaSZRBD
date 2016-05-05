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
    public partial class PracownikKierunki : Form
    {
        PlanyEntities3 db = new PlanyEntities3();
        public PracownikKierunki()
        {
            InitializeComponent();
        }

        private void PracownikKierunki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet27.kierunek' table. You can move, or remove it, as needed.
            this.kierunekTableAdapter.Fill(this.planyDataSet27.kierunek);
        }

        private void OdswiezDane()
        {
            kierunekBindingSource.DataSource = db.kierunek.ToList();
        }

        private void pracownikierunekZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pracownikKierunekDodaj_Click(object sender, EventArgs e)
        {
            PracownikDEKierunki de = new PracownikDEKierunki(null);
            de.ShowDialog();

            db.kierunek.Add(de.Kierunek);
            db.SaveChanges();
            OdswiezDane();
        }

        private void pracownikKierunekEdytuj_Click(object sender, EventArgs e)
        {
            PracownikDEKierunki de = new PracownikDEKierunki(kierunekBindingSource.Current as kierunek);
            de.ShowDialog();

            db.SaveChanges();
            OdswiezDane();
        }

        private void pracownikKierunekUsun_Click(object sender, EventArgs e)
        {

            kierunek ten = kierunekBindingSource.Current as kierunek;
            db.kierunek.Remove(ten);
            db.SaveChanges();
            OdswiezDane();
        }
    }
}
