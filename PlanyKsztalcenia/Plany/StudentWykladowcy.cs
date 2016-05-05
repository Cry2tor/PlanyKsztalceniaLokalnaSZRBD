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
    public partial class StudentWykladowcy : Form
    {
        public StudentWykladowcy()
        {
            InitializeComponent();
        }

        private void StudentWykladowcy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'planyDataSet23.pracownicy' table. You can move, or remove it, as needed.
            this.pracownicyTableAdapter.Fill(this.planyDataSet23.pracownicy);

        }

        private void fStudentWykladowcaZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
