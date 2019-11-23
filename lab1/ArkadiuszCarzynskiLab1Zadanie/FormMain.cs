using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
namespace ArkadiuszCarzynskiLab1Zadanie
{
    public partial class FormMain : Form
    {
        // zmienne przechowujące informacje o godzinie, minucie i indeksie dnia(potrzebne do tablicy)
        private int hour = 12, minutes = 0, dayIndex = 0;
        // zmienne przechwujace poziom kazdego budynku
        private int powerGeneratorLevel = 1, kitchenLevel, waterTreatmentLevel, scienceRoomLevel;
        // zmienne przechowujace liczbe pracownikow w kazdym budynku
        private int powerGeneratorWorkers = 1, kitchenWorkers, waterTreatmentWorkers, scienceRoomWorkers;
        // zmienne przechowujace koszt zatrudnienia pracownika i rozbudowy w danym budynku
        private double powerGeneratorCurrentPrice = 500, powerGeneratorWorkerPrice = 500;
        private int kitchenBuildPrice = 10000, waterTreatmentBuildPrice = 25000, scienceRoomBuildPrice = 50000;
        // zmienna przechowująca ilość monet
        private double coins = 300;
        // zmienna typu bool (prawda lub falsz) przechowująca informację czy trwa przerwa od pracy
        private bool breakTime = false;
        private double kitchenCurrentPrice = 1000, kitchenWorkerPrice = 1000;
        private double scienceRoomCurrentPrice = 2000, scienceRoomWorkerPrice = 2000;
        private double waterTreatmentCurrentPrice = 1500, waterTreatmentWorkerPrice = 1500;
        // tablica przechowujace informacje czy dany budynek jest wybudowany
        private bool[] buildings = new bool[4];
        // tablica przechowujące nazwy budynków
        private string[] buildingsName = { "Elektrownia", "Kuchnia", "Hydrofornia", "Pokój naukowców" };
        // tablica przechowująca nazwy dni tygodnia
        private string[] day = { "Poniedzialek", "Wtorek", "Sroda", "Czwartek", "Piatek", "Sobota", "Niedziela" };
        
        /// <summary>
        /// konstruktor klasy FormMain
        /// </summary>
        /// <param name="userName"></param>
        public FormMain(string userName)
        {
            InitializeComponent();
            
            labelUserName.Text = userName;
            timerMain.Start();
            
            // wszystkie budynki oprocz elektrownii sa niewybudowane
            for(int i=1; i<4; i++)
            {
                buildings[i] = false;
            }
            // elektrownia jest wybudowana na start
            buildings[0] = true;
            labelDay.Text = day[dayIndex];
            labelHour.Text = hour.ToString();

            // ustawienie interwalu zegara obslugujacego czas w grze
            timerTimeInGame.Interval = 5;
            timerMain.Interval = 5;
            timerTimeInGame.Start();

            labelKitchenLevel.Visible = labelKitchenPace.Visible = labelKitchenWorkers.Visible = false;
            labelWaterTreatmentLevel.Visible = labelWaterTreatmentWorkers.Visible = labelWaterTreatmentPace.Visible = false;
            labelScienceRoomLevel.Visible = labelScienceRoomPace.Visible = labelScienceRoomWorkers.Visible = false;

            // ustawienie kroku dla wszystkich pasków postępu na 5
            progressBarPower.Step = progressBarFood.Step = progressBarWater.Step = progressBarScience.Step = 5;
            progressBarPower.ForeColor = progressBarFood.ForeColor = progressBarWater.ForeColor = progressBarScience.ForeColor = Color.Yellow;
            progressBarPower.BackColor = progressBarFood.BackColor = progressBarWater.BackColor = progressBarScience.BackColor = Color.Black;
            timerPower.Start();           

        }
        /// <summary>
        /// funkcja dla ticku timera obslugujacego czas w grze (dzien, godzina, minuta)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTimeInGame_Tick(object sender, EventArgs e)
        {
            minutes++;
            if(minutes == 60)
            {
                hour++;
                minutes = 0;
                if (hour <= 9)
                {
                    labelHour.Text = "0" + hour.ToString();
                }
                else if(hour == 24)
                {
                    hour = 0;                   
                    dayIndex++;
                    if(dayIndex == 7)
                    {
                        dayIndex = 0;
                    }
                    labelDay.Text = day[dayIndex];
                    labelHour.Text = "0" + hour.ToString();
                }

                else
                {
                    labelHour.Text = hour.ToString();
                }

            }
           
            if(minutes <= 9)
            {
                labelMinute.Text = "0" + minutes.ToString();
            }
            else
            {
                labelMinute.Text = minutes.ToString();
            }

        }

        /// <summary>
        /// funkcja obslugujaca zatrudnienie pracownika w hydrofornii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWaterTreatmentAddWorker_Click(object sender, EventArgs e)
        {
            if(coins >= waterTreatmentWorkerPrice && waterTreatmentWorkers < 10)
            {
                waterTreatmentWorkers++;
                coins -= waterTreatmentWorkerPrice;
                waterTreatmentWorkerPrice *= 4;
                progressBarWater.Step++;
                labelWaterTreatmentWorkers.Text = "Liczba pracowników: " + waterTreatmentWorkers;
                buttonWaterTreatmentAddWorker.Text = "Zatrudnij (" + waterTreatmentWorkerPrice + ")";

            }
        }
        /// <summary>
        /// funkcja obsługująca zatrudnienie pracownika w pokoju naukowców
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScienceRoomAddWorker_Click(object sender, EventArgs e)
        {
            if (coins >= scienceRoomWorkerPrice && scienceRoomWorkers < 10)
            {
                scienceRoomWorkers++;
                coins -= scienceRoomWorkerPrice;
                scienceRoomWorkerPrice *= 4;
                progressBarScience.Step++;
                labelScienceRoomWorkers.Text = "Liczba pracowników: " + scienceRoomWorkers;
                buttonScienceRoomAddWorker.Text = "Zatrudnij (" + scienceRoomWorkerPrice + ")";
            }
        }

        /// <summary>
        /// funkcja obsługująca zebranie energii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxPower2_Click(object sender, EventArgs e)
        {
            if (progressBarPower.Value == 100)
            {
                coins += 250 * powerGeneratorLevel * powerGeneratorLevel * powerGeneratorLevel;
                pictureBoxPower2.BackgroundImage = ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.energy;
                progressBarPower.Value = 0;
                progressBarPower.ForeColor = Color.Yellow;
                timerPower.Start();

            }
        }
        /// <summary>
        /// funkcja obsługująca zebranie jedzenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxFood2_Click(object sender, EventArgs e)
        {
            if (progressBarFood.Value == 100)
            {
                coins += 250 * kitchenLevel * kitchenLevel * kitchenLevel;
                pictureBoxFood2.BackgroundImage = ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.food;
                progressBarFood.Value = 0;
                progressBarFood.ForeColor = Color.Yellow;
                timerFood.Start();
            }
        }

        /// <summary>
        /// funkcja obsługująca zebranie wody
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxWater2_Click(object sender, EventArgs e)
        {
            if (progressBarWater.Value == 100)
            {
                coins += 150 * waterTreatmentLevel * waterTreatmentLevel * waterTreatmentLevel;
                pictureBoxWater2.BackgroundImage = ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.water;
                progressBarWater.Value = 0;
                progressBarWater.ForeColor = Color.Yellow;
                timerWater.Start();
            }
        }

        /// <summary>
        /// funkcja obsługująca zebranie nauki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxScience2_Click(object sender, EventArgs e)
        {
            if (progressBarScience.Value == 100)
            {
                coins += 150 * scienceRoomLevel * scienceRoomLevel * scienceRoomLevel;
                pictureBoxScience2.BackgroundImage = ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.science;
                progressBarScience.Value = 0;
                progressBarScience.ForeColor = Color.Yellow;
                timerScience.Start();
            }
        }

        /// <summary>
        /// funkcja obsługująca zwiększenie poziomu pokoju naukowców
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScienceRoomUpgrade_Click(object sender, EventArgs e)
        {
            if(coins >= scienceRoomCurrentPrice && scienceRoomLevel < 10)
            {
                scienceRoomLevel++;
                coins -= scienceRoomCurrentPrice;
                scienceRoomCurrentPrice *= 3;
                timerScience.Interval -= 80;
                labelScienceRoomLevel.Text = "Poziom " + scienceRoomLevel;
                buttonScienceRoomUpgrade.Text = "Ulepsz (" + scienceRoomCurrentPrice + ")";

            }
        }

        /// <summary>
        /// funkcja obsługująca zwiększenie poziomu hydrofornii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWaterTreatmentUpgrade_Click(object sender, EventArgs e)
        {
            if(coins >= waterTreatmentCurrentPrice && waterTreatmentLevel < 10)
            {
                waterTreatmentLevel++;
                coins -= waterTreatmentCurrentPrice;
                waterTreatmentCurrentPrice *= 3;
                timerWater.Interval -= 80;
                labelWaterTreatmentLevel.Text = "Poziom " + waterTreatmentLevel;
                buttonWaterTreatmentUpgrade.Text = "Ulepsz (" + waterTreatmentCurrentPrice + ")";

            }
        }

        /// <summary>
        /// funkcja wywołana przy załadowaniu głównego okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // włączenie muzyki
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "itShelter.wav";
            sp.PlayLooping();
        }

        /// <summary>
        /// funkcja obsługująca kliknięcie w swoje imię
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelUserName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Juz nie mozesz zmienic imienia....");
        }

        /// <summary>
        /// funkcja pokazująca informacje o programie po kliknięciu na pictureBoxInfo2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxInfo2_Click(object sender, EventArgs e)
        {
            timerMain.Stop();
            MessageBox.Show("Prosty clicker wzorujący się na znanym tytule Fallout Shelter.\nKlikaj na ikony zasobów aby zwalniać bufor i dostawać monety.Buduj \ni rozbudowuj kolejne budynki.Zatrudniaj nowych pracowników \ni zwiększaj efektywność pracy! \nGodziny pracy w budynkach: \n * elektrownia i hydroforania (cały tydzień), \n * kuchnia i pokój naukowców (codziennie od 6.00 do 23.00). \nAutor: Arkadiusz Carzyński");
            timerMain.Start();
        }

        /// <summary>
        /// funkcja obsługująca przycisk kończący działanie programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// funkcja obsługująca tick zegara produkcji energii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPower_Tick(object sender, EventArgs e)
        {          
            progressBarPower.PerformStep();
            if (progressBarPower.Value == 100)
            {
                progressBarPower.ForeColor = Color.Green;
                pictureBoxPower2.BackgroundImage = ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.energyFull;
                timerPower.Stop();
            }
        }

        /// <summary>
        /// funkcja obsługująca zwiększenie poziomu elektrownii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPowerGeneratorUpgrade_Click(object sender, EventArgs e)
        {
            if(coins >= powerGeneratorCurrentPrice && powerGeneratorLevel < 10)
            {
                powerGeneratorLevel++;
                timerPower.Interval -= 80;
                coins -= powerGeneratorCurrentPrice;
                powerGeneratorCurrentPrice *= 3;
                labelPowerGeneratorLevel.Text = "Poziom " + powerGeneratorLevel;
                buttonPowerGeneratorUpgrade.Text = "Ulepsz (" + powerGeneratorCurrentPrice + ")";               
            }           
        }

        /// <summary>
        /// funkcja obsługująca zwiększenie poziomu kuchnii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKitchenUpgrade_Click(object sender, EventArgs e)
        {
            if (coins >= kitchenCurrentPrice && kitchenLevel < 10)
            {
                kitchenLevel++;
                timerFood.Interval -= 80;
                coins -= kitchenCurrentPrice;
                kitchenCurrentPrice *= 3;
                labelKitchenLevel.Text = "Poziom " + kitchenLevel;
                buttonKitchenUpgrade.Text = "Ulepsz (" + kitchenCurrentPrice + ")";
            }
        }

        /// <summary>
        /// funkcja obsługująca zatrudnienie pracownika w kuchnii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKitchenAddWorker_Click(object sender, EventArgs e)
        {
            if(coins >= kitchenWorkerPrice && kitchenWorkers < 10)
            {
                coins -= kitchenWorkerPrice;
                kitchenWorkerPrice *= 4;
                kitchenWorkers++;
                progressBarFood.Step++;
                labelKitchenWorkers.Text = "Liczba pracownikow " + kitchenWorkers;
                buttonKitchenAddWorker.Text = "Zatrudnij (" + kitchenWorkerPrice + ")";
            }
        }

        /// <summary>
        /// funkcja obsługująca tick zegara głównego gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            labelCoins.Text = coins.ToString();
           
            labelPowerGeneratorPace.Text = "Tempo pracy: " + progressBarPower.Step.ToString() + "/" + timerPower.Interval.ToString() + " [j/ms]";
            labelWaterTreatmentPace.Text = "Tempo pracy: " + progressBarWater.Step.ToString() + "/" + timerWater.Interval.ToString() + " [j/ms]";
            labelKitchenPace.Text = "Tempo pracy: " + progressBarFood.Step.ToString() + "/" + timerFood.Interval.ToString() + " [j/ms]";
            labelScienceRoomPace.Text = "Tempo pracy: " + progressBarScience.Step.ToString() + "/" + timerScience.Interval.ToString() + " [j/ms]";

            if (powerGeneratorLevel == 10)
            {
                buttonPowerGeneratorUpgrade.Text = "MAX";
                buttonPowerGeneratorUpgrade.ForeColor = Color.Green;
            }
            if(powerGeneratorLevel < 10)
            {
                if (coins >= powerGeneratorCurrentPrice) buttonPowerGeneratorUpgrade.ForeColor = Color.Yellow;
                else buttonPowerGeneratorUpgrade.ForeColor = Color.Red;
            }

            if (powerGeneratorWorkers == 10)
            {
                buttonPowerGeneratorAddWorker.Text = "MAX";
                buttonPowerGeneratorAddWorker.ForeColor = Color.Green;
            }
            if(powerGeneratorWorkers < 10)
            {
                if (coins >= powerGeneratorWorkerPrice) buttonPowerGeneratorAddWorker.ForeColor = Color.Yellow;
                else buttonPowerGeneratorAddWorker.ForeColor = Color.Red;
            }

            if(buildings[1])
            {
                if(kitchenLevel == 10)
                {
                    buttonKitchenUpgrade.Text = "MAX";
                    buttonKitchenUpgrade.ForeColor = Color.Green;
                }
                else if(kitchenLevel < 10)
                {
                    if (coins >= kitchenCurrentPrice) buttonKitchenUpgrade.ForeColor = Color.Yellow;
                    else buttonKitchenUpgrade.ForeColor = Color.Red;
                }
                if(kitchenWorkers == 10)
                {
                    buttonKitchenAddWorker.Text = "MAX";
                    buttonKitchenAddWorker.ForeColor = Color.Green;
                }
                else
                {
                    if (coins >= kitchenWorkerPrice) buttonKitchenAddWorker.ForeColor = Color.Yellow;
                    else buttonKitchenAddWorker.ForeColor = Color.Red;
                }
            }
            if(buildings[2])
            {
                if(waterTreatmentLevel == 10)
                {
                    buttonWaterTreatmentUpgrade.Text = "MAX";
                    buttonWaterTreatmentUpgrade.ForeColor = Color.Green;
                }
                else if(waterTreatmentLevel < 10)
                {
                    if (coins >= waterTreatmentCurrentPrice) buttonWaterTreatmentUpgrade.ForeColor = Color.Yellow;
                    else buttonWaterTreatmentUpgrade.ForeColor = Color.Red;
                }
                if(waterTreatmentWorkers == 10)
                {
                    buttonWaterTreatmentAddWorker.Text = "MAX";
                    buttonWaterTreatmentAddWorker.ForeColor = Color.Green;
                }
                else
                {
                    if (coins >= waterTreatmentWorkerPrice) buttonWaterTreatmentAddWorker.ForeColor = Color.Yellow;
                    else buttonWaterTreatmentAddWorker.ForeColor = Color.Red;

                }

            }
            if(buildings[3])
            {
                if(scienceRoomLevel == 10)
                {
                    buttonScienceRoomUpgrade.Text = "MAX";
                    buttonScienceRoomUpgrade.ForeColor = Color.Green;
                }
                else if (scienceRoomLevel < 10)
                {
                    if (coins >= scienceRoomCurrentPrice) buttonScienceRoomUpgrade.ForeColor = Color.Yellow;
                    else buttonScienceRoomUpgrade.ForeColor = Color.Red;
                }
                if(scienceRoomWorkers == 10)
                {
                    buttonScienceRoomAddWorker.Text = "MAX";
                    buttonScienceRoomAddWorker.ForeColor = Color.Green;
                }
                else
                {
                    if (coins >= scienceRoomWorkerPrice) buttonScienceRoomAddWorker.ForeColor = Color.Yellow;
                    else buttonScienceRoomAddWorker.ForeColor = Color.Red;
                }

            }

            if (coins >= kitchenBuildPrice) buttonKitchen.BackColor = Color.LightGreen;
            if (coins >= waterTreatmentBuildPrice) buttonWaterTreatment.BackColor = Color.LightGreen;
            if (coins >= scienceRoomBuildPrice) buttonScienceRoom.BackColor = Color.LightGreen;
            if (coins < kitchenBuildPrice)
            {
                buttonKitchen.BackColor = Color.Red;
                buttonWaterTreatment.BackColor = Color.Red;
                buttonScienceRoom.BackColor = Color.Red;
            }
            

            // obsługa godzin pracy dla niektórych budynków
            if (hour >= 23 || hour < 6)
            {
                if(buildings[3])
                timerScience.Stop();
                if(buildings[1])
                timerFood.Stop();
                breakTime = true;
            }
                

            if(breakTime == true &&(hour >= 6 || hour <23))
            {
                if (buildings[3])
                    timerScience.Start();
                if (buildings[1])
                    timerFood.Start();
                breakTime = false;
            }

            // awaria
            // obiekt klasy Random, potrzebny do generowanie liczb pseudolowosych
            Random rand = new Random();
            if(rand.Next(0,1000000) >= 100 & rand.Next(0, 1000000) <= 800)
            {
                // zmienna przechowująca informację, który wylosowany budynek bedzie mial awarie
                int buildingIndex = rand.Next(0, 4);

                // sprawdzenie czy wylosowany budynek jest zbudowany
                if(buildings[buildingIndex])
                {
                    // zatrzymanie wszystkich clockow
                    timerMain.Stop();
                    timerPower.Stop();
                    timerFood.Stop();
                    timerScience.Stop();
                    timerTimeInGame.Stop();
                    timerWater.Stop();

                    //wyswietlenie okienka o awarii
                    
                    string message = "Awaria budynku " + buildingsName[buildingIndex];
                    MessageBox.Show(message + ". Musisz zaplacic za naprawe! Koszt naprawy: " + 100*(buildingIndex*2+1));
                    coins -= 100 * (buildingIndex*2+1);
                }

                timerMain.Start();
                timerPower.Start();
                if(buildings[1])
                timerFood.Start();
                if(buildings[2])
                timerScience.Start();
                timerTimeInGame.Start();
                if(buildings[3])
                timerWater.Start();
            }
            // sprawdzenie wygranej
            if (powerGeneratorLevel == 10 && kitchenLevel == 10 && waterTreatmentLevel == 10 && scienceRoomLevel == 10 && powerGeneratorWorkers == 10 && kitchenWorkers == 10 && waterTreatmentWorkers == 10 && scienceRoomWorkers == 10)
            {
                timerMain.Stop();
                timerPower.Stop();
                timerFood.Stop();
                timerScience.Stop();
                timerWater.Stop();
                timerTimeInGame.Stop();
                MessageBox.Show("Gratulacje!! Ukończyłeś grę!");
                Application.Exit();
            }

            // sprawdzenie przegranej
            {
                if (coins < 0)
                {
                    timerMain.Stop();
                    timerPower.Stop();
                    timerFood.Stop();
                    timerScience.Stop();
                    timerWater.Stop();
                    timerTimeInGame.Stop();
                    MessageBox.Show("Nie masz wystarczających środków na pokrycie kosztów na naprawę. Koniec gry!");
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// funkcja obsługująca tick zegara dla produkcji jedzenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFood_Tick(object sender, EventArgs e)
        {
            progressBarFood.PerformStep();
            if (progressBarFood.Value == 100)
            {
                progressBarFood.ForeColor = Color.Green;
                pictureBoxFood2.BackgroundImage = ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.foodFull;
                timerFood.Stop();
            }
        }

        /// <summary>
        /// funkcja obsługująca tick zegara dla produkcji wody
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWater_Tick(object sender, EventArgs e)
        {
            progressBarWater.PerformStep();
            if (progressBarWater.Value == 100)
            {
                progressBarWater.ForeColor = Color.Green;
                pictureBoxWater2.BackgroundImage = ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.waterFull;
                timerWater.Stop();
            }
        }

        /// <summary>
        /// funkcja obsługująca przycisk wybudowania hydrofornii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWaterTreatment_Click(object sender, EventArgs e)
        {
            if(coins >= waterTreatmentBuildPrice)
            {
                buildings[2] = true;
                waterTreatmentWorkers = 1;
                coins -= waterTreatmentBuildPrice;
                buttonWaterTreatment.Visible = buttonWaterTreatment.Enabled = false;
                labelWaterTreatmentLevel.Visible = labelWaterTreatmentPace.Visible = labelWaterTreatmentWorkers.Visible = true;
                timerWater.Interval = 1000;
                timerWater.Start();
            }
        }

        /// <summary>
        /// funkcja obsługująca przycisk wybudowania pokoju naukowców
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScienceRoom_Click(object sender, EventArgs e)
        {
            if(coins >= scienceRoomBuildPrice)
            {
                buildings[3]= true;
                coins -= scienceRoomBuildPrice;
                scienceRoomWorkers = 1;
                buttonScienceRoom.Visible = buttonScienceRoom.Enabled = false;
                labelScienceRoomLevel.Visible = labelScienceRoomPace.Visible = labelScienceRoomWorkers.Visible = true;
                timerScience.Interval = 1000;
                timerScience.Start();
            }
        }

        /// <summary>
        /// funkcja obsługująca przycisk wybudowania kuchnii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKitchen_Click(object sender, EventArgs e)
        {
            if(coins >= kitchenBuildPrice)
            {
                buildings[1] = true;
                kitchenWorkers = 1;
                coins -= kitchenBuildPrice;
                labelKitchenLevel.Visible = labelKitchenPace.Visible = labelKitchenWorkers.Visible = true;
                buttonKitchen.Visible = buttonKitchen.Enabled = false;
                timerFood.Interval = 1000;
                timerFood.Start();                
            }
        }

        /// <summary>
        /// funkcja obsługująca tick zegara dla produkcji nauki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerScience_Tick(object sender, EventArgs e)
        {
            progressBarScience.PerformStep();
            if (progressBarScience.Value == 100)
            {
                progressBarScience.ForeColor = Color.Green;
                pictureBoxScience2.BackgroundImage = ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.scienceFull;
                timerScience.Stop();
            }
        }

        /// <summary>
        /// funkcja obsługująca zatrudnienie pracownika w elektrownii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPowerGeneratorAddWorker_Click(object sender, EventArgs e)
        {
            if(powerGeneratorWorkers <10 && coins >= powerGeneratorWorkerPrice)
            {
                coins -= powerGeneratorWorkerPrice;            
                powerGeneratorWorkerPrice *= 4;
                powerGeneratorWorkers++;
                progressBarPower.Step++;
                labelPowerGeneratorWorkers.Text = "Liczba pracowników: " + powerGeneratorWorkers;
                buttonPowerGeneratorAddWorker.Text = "Zatrudnij (" + powerGeneratorWorkerPrice + ")";
            }           
        }
    }
}
