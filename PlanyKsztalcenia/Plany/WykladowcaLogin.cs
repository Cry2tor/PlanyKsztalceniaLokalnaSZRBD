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
    public partial class WykladowcaLogin : Form
    {
        PlanyEntities3 db = new PlanyEntities3();

        public WykladowcaLogin()
        {
            InitializeComponent();
        }

        private void WykladocaZaloguj_Click(object sender, EventArgs e)
        {
            /* foreach (var wykladowca in db.pracownicy)
             {
                 if (wykladowca.login == tbLogin.Text)
                 {
                     if (wykladowca.haslo == tbHaslo.Text)
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
             */
            if (tbLogin.Text == "login")
            {
                if (tbHaslo.Text == "pass")
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
