using ArkadiuszCarzynskiLab4Zadanie.Models;
using ArkadiuszCarzynskiLab4Zadanie.Repositories;
using System;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiLab4Zadanie
{
    public partial class FormInterface : Form
    {
        /// <summary>
        /// Zmienne tylko do odczytu dla obietkow klasy generycznej
        /// </summary>
        private readonly IFootballGeneric<Footballer> _footballers;
        private readonly IFootballGeneric<Country> _countries;
        private readonly IFootballGeneric<Coach> _coaches;
        private readonly IFootballGeneric<Club> _clubs;
        private readonly IFootballGeneric<Stadium> _stadiums;

        /// <summary>
        /// Konstruktor klasy FormInterface
        /// </summary>
        public FormInterface()
        {
            InitializeComponent();
            _footballers = new FootballGeneric<Footballer>();
            _countries = new FootballGeneric<Country>();
            _coaches = new FootballGeneric<Coach>();
            _clubs = new FootballGeneric<Club>();
            _stadiums = new FootballGeneric<Stadium>();
            LoadFootballers();
            LoadCountries();
            LoadClubs();
            LoadStadiums();
            LoadCoaches();
        }

        /// <summary>
        /// Funkcja wyświetlająca piłkarzy z bazy na interfejs
        /// </summary>
        private void LoadFootballers()
        {
            dataGridViewFootballers.DataSource = _footballers.GetAll();
        }

        /// <summary>
        /// Funkcja wyświetlająca kraje z bazy na interfejs
        /// </summary>
        private void LoadCountries()
        {
            dataGridViewCountries.DataSource = _countries.GetAll();
        }

        /// <summary>
        /// Funkcja wyświetlająca trenerów z  bazy na interfejs
        /// </summary>
        private void LoadCoaches()
        {
            dataGridViewCoaches.DataSource = _coaches.GetAll();
        }

        /// <summary>
        /// Funkcja wyświetlająca kluby z bazy na interfejs
        /// </summary>
        private void LoadClubs()
        {
            dataGridViewClubs.DataSource = _clubs.GetAll();
        }

        /// <summary>
        /// Funkcja wyświetlająca stadiony z bazy na interfejs
        /// </summary>
        private void LoadStadiums()
        {
            dataGridViewStadiums.DataSource = _stadiums.GetAll();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie informacji o zaznaczonym piłkarzu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFootballerShow_Click(object sender, EventArgs e)
        {
            var selectedFootballerIndex = Int32.Parse(dataGridViewFootballers.SelectedRows[0].Cells[0].Value.ToString());
            var selectedFootballer = _footballers.GetById(selectedFootballerIndex);

            selectedFootballer.Country = _countries.GetById(selectedFootballer.CountryId);
            MessageBox.Show("Zaznaczony piłkarz: "+ selectedFootballer.FirstName + " " + selectedFootballer.LastName  + "\nKraj piłkarza: " + selectedFootballer.Country.CountryName);
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za usunięcie piłkarza z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveFootballer_Click(object sender, EventArgs e)
        {
            _footballers.DeleteById(Int32.Parse(dataGridViewFootballers.SelectedRows[0].Cells[0].Value.ToString()));
            _footballers.Save();
            LoadFootballers();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za zamknięcie aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za usunięcie zaznaczonego kraju z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveCountry_Click(object sender, EventArgs e)
        {
            _countries.DeleteById(Int32.Parse(dataGridViewCountries.SelectedRows[0].Cells[0].Value.ToString()));
            _countries.Save();
            LoadCountries();

        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za usunięcie klubu z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveClub_Click(object sender, EventArgs e)
        {
            _clubs.DeleteById(Int32.Parse(dataGridViewClubs.SelectedRows[0].Cells[0].Value.ToString()));
            _clubs.Save();
            LoadClubs();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za usuniecie stadionu z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveStadium_Click(object sender, EventArgs e)
        {
            _stadiums.DeleteById(Int32.Parse(dataGridViewStadiums.SelectedRows[0].Cells[0].Value.ToString()));
            _stadiums.Save();
            LoadStadiums();
        }

        /// <summary>
        /// Funkcja oobsługująca przycisk odpowiedzialny za usunięcie trenera z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveCoach_Click(object sender, EventArgs e)
        {
            _coaches.DeleteById(Int32.Parse(dataGridViewCoaches.SelectedRows[0].Cells[0].Value.ToString()));
            _coaches.Save();
            LoadCoaches();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za dodanie piłkarza do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNewFootballer_Click(object sender, EventArgs e)
        {
            var firstNameFootballer = textBoxFootballerFirstName.Text;
            var lastNameFootballer = textBoxFootballerLastName.Text;
            var birthdateFootballer = dateTimePickerFootballer.Text;
            var clubIdFootballer = textBoxFootballerClubId.Text;
            var countryIdFootballer = textBoxFootballerCountryId.Text;

            if((firstNameFootballer != "") && (lastNameFootballer != "") && (birthdateFootballer != "") 
                && (clubIdFootballer != "") && (countryIdFootballer != ""))
            {
                Footballer footballer = new Footballer
                {
                    FirstName = firstNameFootballer,
                    LastName = lastNameFootballer,
                    Birthdate = Convert.ToDateTime(birthdateFootballer),
                    ClubId = Int32.Parse(clubIdFootballer),
                    CountryId = Int32.Parse(countryIdFootballer)
                };
                _footballers.Create(footballer);
                _footballers.Save();
                LoadFootballers();
                textBoxFootballerFirstName.Text = textBoxFootballerLastName.Text = dateTimePickerFootballer.Text
                    = textBoxFootballerClubId.Text = textBoxFootballerCountryId.Text = "";

            }
            else
            {
                MessageBox.Show("Niepoprawne dane!");
            }
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za dodanie kraju do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNewCountry_Click(object sender, EventArgs e)
        {
            var nameCountry = textBoxCountryName.Text;
            if(nameCountry != "")
            {
                Country country = new Country
                {
                    CountryName = nameCountry
                };
                _countries.Create(country);
                _countries.Save();
                LoadCountries();
                textBoxCountryName.Text = "";
            }
            else
            {
                MessageBox.Show("Niepoprawne dane!");
            }
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za dodanie klubu do bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddClub_Click(object sender, EventArgs e)
        {
            var nameClub = textBoxClubName.Text;
            var foundYearClub = textBoxClubFoundYear.Text;
            var kitsClub = textBoxClubKits.Text;
            var stadiumIdClub = textBoxClubStadiumId.Text;
            var coachIdClub = textBoxClubCoachId.Text;
            if(nameClub != "" && foundYearClub != "" && kitsClub != "" && stadiumIdClub != "" && coachIdClub != "")
            {
                Club club = new Club
                {
                    Name = nameClub,
                    FoundYear = Int32.Parse(foundYearClub),
                    Kits = kitsClub,
                    StadiumId = Int32.Parse(stadiumIdClub),
                    CoachId = Int32.Parse(coachIdClub)
                };
                _clubs.Create(club);
                _clubs.Save();
                LoadClubs();
                textBoxClubName.Text = textBoxClubFoundYear.Text = textBoxClubKits.Text
                    = textBoxClubStadiumId.Text = textBoxClubCoachId.Text = "";
            }
            else
            {
                MessageBox.Show("Niepoprawne dane!");
            }
        }

        /// <summary>
        /// FUnkcja obsługująca przycisk odpowiedzialny za dodanie stadionu do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddStadium_Click(object sender, EventArgs e)
        {
            var nameStadium = textBoxStadiumName.Text;
            var capacityStadium = textBoxStadiumCapacity.Text;

            if(nameStadium != "" && capacityStadium != "")
            {
                Stadium stadium = new Stadium
                {
                    StadiumName = nameStadium,
                    Capacity = Int32.Parse(capacityStadium)
                };
                _stadiums.Create(stadium);
                _stadiums.Save();
                LoadStadiums();
                textBoxStadiumName.Text = textBoxStadiumCapacity.Text = "";
            }
            else
            {
                MessageBox.Show("Niepoprawne dane!");
            }
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie informacji o trenerze, który trenuje zaznaczony klub
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCoachInfo_Click(object sender, EventArgs e)
        {
            var selectedIndex = Int32.Parse(dataGridViewClubs.SelectedRows[0].Cells[0].Value.ToString());
            var selectedClub = _clubs.GetById(selectedIndex);

            selectedClub.Coach = _coaches.GetById(selectedClub.CoachId);
            MessageBox.Show("Wybrany klub: " + selectedClub.Name + "\nTrener: " + selectedClub.Coach.FirstName + " " + selectedClub.Coach.LastName);
        }


        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za dodanie trenera do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCoach_Click(object sender, EventArgs e)
        {
            var firstNameCoach = textBoxCoachFIrstName.Text;
            var lastNameCoach = textBoxCoachLastName.Text;
            var birthdateCoach = dateTimePickerCoachBirthdate.Text;

            if(firstNameCoach != "" && lastNameCoach != "" && birthdateCoach != "")
            {
                Coach coach = new Coach
                {
                    FirstName = firstNameCoach,
                    LastName = lastNameCoach,
                    Birthdate = Convert.ToDateTime(birthdateCoach)
                };
                _coaches.Create(coach);
                _coaches.Save();
                LoadCoaches();

                textBoxCoachFIrstName.Text = textBoxCoachLastName.Text = dateTimePickerCoachBirthdate.Text = "";
            }
            else
            {
                MessageBox.Show("Niepoprawne dane!");
            }
        }


    }
}
