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
    public partial class WykladowcaPrzedmioty : Form
    {
        PlanyEntities3 db = new PlanyEntities3();
        public WykladowcaPrzedmioty()
        {
            InitializeComponent();
            OdswiezDane();
        }

        private void WykladowcaPrzedmioty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet12.przedmiot' table. You can move, or remove it, as needed.
            this.przedmiotTableAdapter.Fill(this.planyDataSet12.przedmiot);

        }

        private void WykladowcaPrzedmiotZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OdswiezDane()
        {
            przedmiotBindingSource.DataSource = db.przedmiot.ToList();

        }
        private void wykladowcaPrzedmiotDodaj_Click(object sender, EventArgs e)
        {
            WykladowcaDEPrzedmiot de = new WykladowcaDEPrzedmiot(null);
            de.ShowDialog();

            db.przedmiot.Add(de.Przedmiot);
            db.SaveChanges();
            OdswiezDane();
        }

        private void wykladowcaPrzedmiotEdytuj_Click(object sender, EventArgs e)
        {
            WykladowcaDEPrzedmiot de = new WykladowcaDEPrzedmiot(przedmiotBindingSource.Current as przedmiot);
            de.ShowDialog();

            db.SaveChanges();
            OdswiezDane();
        }

        private void wykladowcaPrzedmiotUsun_Click(object sender, EventArgs e)
        {
            przedmiot ten = przedmiotBindingSource.Current as przedmiot;
            db.przedmiot.Remove(ten);
            db.SaveChanges();
            OdswiezDane();
        }
    }
}
