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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelStartbtnZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pStartbtnStudent_Click(object sender, EventArgs e)
        {
            new StudentLogin().Show();       

            panel2.Visible = true;
        }

        private void pStartbtnWykladowca_Click(object sender, EventArgs e)
        {
            new WykladowcaLogin().Show();

            panelWykladowca.Visible = true;
        }

        private void pStartbtnPracownik_Click(object sender, EventArgs e)
        {
            new PracownikLogin().Show();

            panel1.Visible = false;
            pPracownik.Visible = true;
        }

        private void pStartbtnZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pStudentWykladowcy_Click(object sender, EventArgs e)
        {
            new StudentWykladowcy().Show();
        }

        private void pStudentManu_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void pStudentZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pStudentPrzedmioty_Click(object sender, EventArgs e)
        {
            new StudentPrzedmioty().Show();
        }

        private void pStudentSpecjalizacja_Click(object sender, EventArgs e)
        {
            new StudentSpecjalizacja().Show();
        }

        private void pStudentGrupa_Click(object sender, EventArgs e)
        {
            new StudentGrupa().Show();
        }

        private void pStudentStypendium_Click(object sender, EventArgs e)
        {
            new StudentStypendium().Show();
        }

        private void wykladowcaMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelWykladowca.Visible = false;
        }

        private void wykladowcaZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wykladowcaPrzedmioty_Click(object sender, EventArgs e)
        {
            WykladowcaPrzedmioty wp = new WykladowcaPrzedmioty();
            wp.Show();
        }



        private void wykladowcaStudenci_Click(object sender, EventArgs e)
        {
            WykładowcaStudenci student = new WykładowcaStudenci();
            student.ShowDialog();
        }

        private void wykladowcaSpecjalnosci_Click(object sender, EventArgs e)
        {
            WykladowcySpecjalizacje spec = new WykladowcySpecjalizacje();
            spec.ShowDialog();
        }

        private void pracownikZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pracownikMenu_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pPracownik.Visible = false;
        }

        private void pracownikKierunek_Click(object sender, EventArgs e)
        {
            PracownikKierunki kier = new PracownikKierunki();
            kier.ShowDialog();

        }

        private void pracownikKatedra_Click(object sender, EventArgs e)
        {
            PracownikKatedry kat = new PracownikKatedry();
            kat.ShowDialog();
        }

        private void pracownikSpecjalnosc_Click(object sender, EventArgs e)
        {
            PracownikSpecjalnosci spec = new PracownikSpecjalnosci();
            spec.ShowDialog();
        }

        private void pracownikPrzedmioty_Click(object sender, EventArgs e)
        {
            PracownikPrzedmioty prz = new PracownikPrzedmioty();
            prz.ShowDialog();
        }

        private void pracownikStudenci_Click(object sender, EventArgs e)
        {
            PracownicyStudenci stu = new PracownicyStudenci();
            stu.ShowDialog();
        }

        private void pracownikPracownicy_Click(object sender, EventArgs e)
        {
            PracownicyPracownicy prac = new PracownicyPracownicy();
            prac.ShowDialog();
        }

        private void pracownikStypendia_Click(object sender, EventArgs e)
        {
            PracownikStypendium styp = new PracownikStypendium();
            styp.ShowDialog();
        }
    }
}
