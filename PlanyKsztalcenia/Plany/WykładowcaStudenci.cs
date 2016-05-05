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
    public partial class WykładowcaStudenci : Form
    {
        public WykładowcaStudenci()
        {
            InitializeComponent();
        }

        private void WykładowcaStudenci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet25.studenci' table. You can move, or remove it, as needed.
            this.studenciTableAdapter.Fill(this.planyDataSet25.studenci);

        }

        private void WykladowcaStudenci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
