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
    public partial class StudentSpecjalizacja : Form
    {
        public StudentSpecjalizacja()
        {
            InitializeComponent();
        }

        private void StudentSpecjalizacja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet24.specjalnosc' table. You can move, or remove it, as needed.
            this.specjalnoscTableAdapter.Fill(this.planyDataSet24.specjalnosc);

        }

        private void StudentSpecjalizacjaZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
