using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiA
{
    public partial class FormMain : Form
    {
        // licznik przechowujący niepoprawną liczbę zalogowań
        int wrongCounter = 0;

        /// <summary>
        /// Konstruktor klasy FormMain
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za sprawdzenie poprawności logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonnSignin_Click(object sender, EventArgs e)
        {
            if(wrongCounter < 3)
            {
                if(textBoxLogin.Text == "admin" && textBoxPassword.Text == "test")
                {
                    labelSignStatus.Text = "Zalogowano!";
                    labelSignStatus.ForeColor = Color.Green;

                }
                else
                {
                    wrongCounter++;
                    if(wrongCounter == 3)
                    {
                        textBoxLogin.Enabled = textBoxLogin.Visible = false;
                        textBoxPassword.Enabled = textBoxPassword.Visible = false;
                        labelSignStatus.Text = "Zablokowano dostęp do systemu!";
                        labelSignStatus.ForeColor = Color.Red;
                    }
                    textBoxLogin.Text = textBoxPassword.Text = "";
                    labelSignStatus.ForeColor = Color.Black;
                    labelSignStatus.Text = "Niepoprawne dane";
                }
            }
        }
        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za rozpoczęcie timera przesuwającego przycisk, uruchamia timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerButtonPosition.Start();
        }

        /// <summary>
        /// Funkcja odpowiedzialna za tick zegara, przesuwa przycisk o 5 px do gory i w prawo co 3 sekundy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerButtonPosition_Tick(object sender, EventArgs e)
        {
            buttonStart.Top -= 5;
            buttonStart.Left += 5;
        }

        /// <summary>
        /// Funkcja wyświetlająca nowe okno z pracownikami z bazy, których imiona zaczynają się na literę 'm'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            FormDatabase fd = new FormDatabase(1);
            fd.Show();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie nowego okna z produktami o określonym filtrze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            FormDatabase fd = new FormDatabase(2);
            fd.Show();
        }
    }
}
