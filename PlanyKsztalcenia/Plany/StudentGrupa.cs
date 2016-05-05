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
    public partial class StudentGrupa : Form
    {
        public StudentGrupa()
        {
            InitializeComponent();
        }

        private void StudentGrupa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet3.studenci' table. You can move, or remove it, as needed.
            this.studenciTableAdapter.Fill(this.planyDataSet3.studenci);

        }

        private void StudentGrupaZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
