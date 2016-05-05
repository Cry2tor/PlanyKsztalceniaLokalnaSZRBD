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
    public partial class StudentPrzedmioty : Form
    {
        public StudentPrzedmioty()
        {
            InitializeComponent();
        }

        private void StudentPrzedmioty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet22.przedmiot' table. You can move, or remove it, as needed.
            this.przedmiotTableAdapter.Fill(this.planyDataSet22.przedmiot);
  

        }

        private void StudentPrzedmiotyZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
