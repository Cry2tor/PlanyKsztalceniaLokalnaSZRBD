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
    public partial class WykladowcySpecjalizacje : Form
    {
        PlanyEntities3 db = new PlanyEntities3();
        public WykladowcySpecjalizacje()
        {
            InitializeComponent();
        }

        private void WykladowcyGrupy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet26.specjalnosc' table. You can move, or remove it, as needed.
            this.specjalnoscTableAdapter.Fill(this.planyDataSet26.specjalnosc);

        }

        public void OdswiezDane()
        {
            specjalnoscBindingSource.DataSource = db.specjalnosc.ToList();
        }

        private void wykladowcaGrupaZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
