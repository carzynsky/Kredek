using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiLab4Zadanie
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Kontruktor klasy FormMain
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja pozwalająca na przeglądanie i wykonywanie operacji na bazie danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormInterface fi = new FormInterface();
            this.Hide();
            fi.Show();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie informacji o programie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja pozwala na przeglądanie, dodawanie i " +
                "usuwanie danych z bazy danych dotyczącej Piłki nożnej. Relacyjna baza danych składa się z 5 tabel:" +
                "\n* Footballers," +
                "\n* Stadiums," +
                "\n* Coaches," +
                "\n* Clubs," +
                "\n* Countries.\n" +
                "\nDodatkowo w bazie dostępne są przykładowe dane początkowe.\n" +
                "Autor: Arkadiusz Carzyński");
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za zakończenie działania programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
