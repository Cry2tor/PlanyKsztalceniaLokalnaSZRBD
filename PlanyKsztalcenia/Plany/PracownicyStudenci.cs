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
    public partial class PracownicyStudenci : Form
    {
        PlanyEntities3 db = new PlanyEntities3();
        public PracownicyStudenci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PracownicyDEStudenci de = new PracownicyDEStudenci(null);
            de.ShowDialog();

            db.studenci.Add(de.Student);
            db.SaveChanges();
            OdswiezDane();
        }

        public void OdswiezDane()
        {
            studenciBindingSource.DataSource = db.studenci.ToList();
        }

        private void PracownicyStudenci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet30.studenci' table. You can move, or remove it, as needed.
            this.studenciTableAdapter.Fill(this.planyDataSet30.studenci);
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            PracownicyDEStudenci de = new PracownicyDEStudenci(studenciBindingSource.Current as studenci);
            de.ShowDialog();

            db.SaveChanges();
            OdswiezDane();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            studenci ci = studenciBindingSource.Current as studenci;

            db.studenci.Remove(ci);
            db.SaveChanges();
            OdswiezDane();
        }

        private void zakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
