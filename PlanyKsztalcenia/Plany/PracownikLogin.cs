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
    public partial class PracownikLogin : Form
    {
        PlanyEntities3 db = new PlanyEntities3();
        public PracownikLogin()
        {
            InitializeComponent();
        }

        private void PracownikZaloguj_Click(object sender, EventArgs e)
        {
            /* foreach (var pracownik in db.pracownicy)
             {
                 if (pracownik.login == tbLogin.Text)
                 {
                     if (pracownik.haslo == tbHaslo.Text)
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
            if (tbLogin.Text == "wladca")
            {
                if (tbHaslo.Text == "haslo")
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
