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
    public partial class StudentLogin : Form
    {
        PlanyEntities3 db = new PlanyEntities3();

        public StudentLogin()
        {
            InitializeComponent();
        }

        private studenci Student
        {
            get{
                return Student;
            }
            set{
                Student = value;
            }
        }

        private void StudentLoginZaloguj_Click(object sender, EventArgs e)
        {
            /* foreach (var student in db.studenci)
             {
                 if(student.login == tbLogin.Text)
                 {
                     if(student.haslo == tbHaslo.Text)
                     {
                         this.Close();
                     }
                     else
                     {
                         MessageBox.Show("Podałeś złe hasło","Wstecz");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Użytkownik o takim loginie nie istnieje.","Wstecz");
                 }
             }
             */
             if(tbLogin.Text == "admin")
            {
                if(tbHaslo.Text == "admin")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podałeś złe hasło", "Wstecz");
                }
            }
            else
            {
                MessageBox.Show("Użytkownik o takim loginie nie istnieje.", "Wstecz");
            }
        }
    }
}
