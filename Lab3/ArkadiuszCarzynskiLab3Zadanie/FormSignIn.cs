using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiLab3Zadanie
{
    public partial class FormSignIn : Form
    {
        /// <summary>
        /// Konstruktor klasy FormSignIN
        /// </summary>
        public FormSignIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za zalogowanie się do bazy i wyświetlenie interfejsu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            SignIn sI = new SignIn(textBoxId.Text, textBoxPassword.Text);
            if(sI.SignInCarRental())
            {
                MessageBox.Show("Udało się zalogować");
                FormInterface fI = new FormInterface();
                fI.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nie udało się zalogować");
            }
        }
    }
}
