using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiLab1Zadanie
{
    public partial class FormMenu : Form
    {
        /// <summary>
        /// konstruktor klasy FormMeny
        /// </summary>
        public FormMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// funkcja obsługująca przycisk rozpoczynający grę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Trim() != string.Empty)
            {
                // utworzenie obiektu, ktorym bedzie nasze okno z grą
                FormMain fM = new FormMain(textBoxUserName.Text);
                fM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie podałeś imienia!");
            }
        }
    }
}
