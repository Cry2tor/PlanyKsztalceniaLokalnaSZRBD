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
    public partial class StudentStypendium : Form
    {
        public StudentStypendium()
        {
            InitializeComponent();
        }

        private void StudentStypendium_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet4.stypendium' table. You can move, or remove it, as needed.
            this.stypendiumTableAdapter.Fill(this.planyDataSet4.stypendium);

        }

        private void StudentStypendiumZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
