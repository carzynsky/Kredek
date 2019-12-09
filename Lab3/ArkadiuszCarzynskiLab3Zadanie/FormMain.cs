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
    public partial class FormMain : Form
    {
        /// <summary>
        /// Konstruktor klasy FormMain
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyjście z programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie okna z logowaniem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            FormSignIn fSignIn = new FormSignIn();
            fSignIn.Show();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie informacji o programie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja pozwalająca pracownikowi zarządzać bazą danych firmy zajmującej się wypożyczaniem samochodów." +
                "\nAby dostać się do bazy należy się zalogować. Zalogować mogą się tylko pracownicy. Muszą oni podać swoje ID oraz hasło." +
                "\nDla ułatwienia dostępu do bazy dodany został pracownik o ID równym 7 i haśle = TEST.");
        }
    }
}
