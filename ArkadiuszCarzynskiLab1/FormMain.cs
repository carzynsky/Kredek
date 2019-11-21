using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiLab1
{
    public partial class FormMain : Form
    {
        
        int counter = 0, number1, number2, crazyButton = 0;
        
        public FormMain()
        {

            InitializeComponent();
        }

        /// <summary>
        /// przycisk zmieniający kolor programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Colour(object sender, EventArgs e)
        {
            // zmiana koloru tła
            BackColor = Color.CadetBlue;
            buttonColour.BackColor = Color.YellowGreen;

        }
        /// <summary>
        /// przycisk zmieniajacy tekst labelu na "!!!" i powracajacy do starych 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTextChange_Click(object sender, EventArgs e)
        {
            // jesli counter jest parzysty to zmien napisy na przyciskach na "!!!"
            // jesli jest nieparzysty to przywroc poczatkowe wartosci
            if(counter % 2 == 0)
            {
                labelName.Text = buttonColour.Text = buttonTextChange.Text = buttonResize.Text = "!!!";
                counter++;
            }
            else
            {
                labelName.Text = "Arkadiusz Carzyński";
                buttonColour.Text = "Kolor";
                buttonTextChange.Text = "Zmiana tekstu";
                buttonResize.Text = "Zmiana rozmiaru";
                counter++;
            }

            
        }

        private void TimerCount_Tick(object sender, EventArgs e)
        {
            
            Random random = new Random();
            // zwiekszenie liczby o 1 przy kazdym ticku
            number1++;
            // wyswietlanie zawartosci zmiennej number
            textBoxCount.Text = number1.ToString();

            // jesli number1 jest parzysty to zmien kolor
            if (number1 % 2 == 0) BackColor = Color.DarkSeaGreen;
            else BackColor = Color.DarkRed;
            
            // losowe wartości współrzędnych przycisku od startu timera
            buttonStartTimer.Top -= number1*random.Next(-1,3);
            buttonStartTimer.Left += number1*random.Next(-1,3);

            // jeśli interwał jest większy od 100 zmniejszaj o 100
            if(timerCount.Interval > 100)
            timerCount.Interval -= 100;

            // instrukcje warunkowe sprawdzajace czy wspolrzedne danego przycisku wychodza poza poczatkowe wartosci okna
            if (buttonStartTimer.Top <= 0 || buttonStartTimer.Top >= this.Height) buttonStartTimer.Top = random.Next(100,500);

            if (buttonStartTimer.Left >= this.Width || buttonStartTimer.Left <= 0) buttonStartTimer.Left = random.Next(100, 500);

            


        }

        /// <summary>
        /// funkcja wyswietlajaca nowe okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            
            FormAbout fa = new FormAbout();
            fa.formName = "Arkadiusz Carzyński";
            fa.Show();
            
        }

        /// <summary>
        /// funkcja uruchamiajaca licznik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            //generator pseudolosowy
            Random random = new Random();

            // jesli counter jest parzysty
            if(crazyButton %2 == 0)
            {
                // ilosc milisekund miedzy zdarzeniami
                timerCount.Interval = 1000;
                timerCount.Start();

                // losowe wartosci wspolrzednych przycisku z przedzialu(100,200)
                buttonStartTimer.Top = random.Next(100, 200);
                buttonStartTimer.Left = random.Next(100, 200);
                crazyButton++;
            }
            else
            {
                // zatrzymanie timera
                timerCount.Stop();  
                crazyButton++;
            }


        }

        /// <summary>
        /// przycisk zmieniajacy rozmiar okienka (losowo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResize_Click(object sender, EventArgs e)
        {
            // generator pseudolosowy
            Random random = new Random();
            if (counter % 2 == 0)
            {
                this.MinimumSize = this.MaximumSize = new Size(random.Next(300,900), random.Next(300,900));
            }
            else
            {
                this.MinimumSize = this.MaximumSize = new Size(500, 500);
            }
                
            
        }

        /// <summary>
        /// funkcja uruchamiająca obliczenia dzielenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount_Click(object sender, EventArgs e)
        {
            
            // obsługa wyjątków
            try
            {
                // zamiana typu zmiennych
                number1 = Int32.Parse(textBoxCount.Text);
                number2 = Int32.Parse(textBoxCount2.Text);

                if (counter % 2 == 0)
                {
                    BackColor = Color.Black;
                    counter++;
                }
                else
                {
                    BackColor = Color.DimGray;
                    counter++;
                }

                MessageBox.Show((number1 / number2).ToString());
            }
            catch(ArithmeticException a)
            {
                MessageBox.Show(a.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
