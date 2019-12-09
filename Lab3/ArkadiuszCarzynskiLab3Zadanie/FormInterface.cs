using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiLab3Zadanie
{
    public partial class FormInterface : Form
    {
        /// <summary>
        /// Configuration Manager potrzebuje, aby dodac do referencji biblioteki System.Config
        /// </summary>
        private readonly Func<SqlConnection> dbConnectionCarRental= () => new SqlConnection(ConfigurationManager.ConnectionStrings["CarRental"].ConnectionString);
       
        /// <summary>
        /// Kontruktor klasy FormInterface
        /// </summary>
        public FormInterface()
        {
            InitializeComponent();
            groupBoxAddClient.Visible = groupBoxAddClient.Enabled = false;

        }


        /// <summary>
        /// Metoda połączy dane z dataGridView
        /// </summary>
        public void GetDataFromTable()
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("select * from Rent ", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie wypożyczeń
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowRent_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("select r.ClientId as 'ID Klienta', c.FirstName as 'Imię'," +
                    " c.LastName as 'Nazwisko', cr.CarBrand as 'Model samochodu', cr.Color as 'Kolor samochodu', " +
                    "r.RentDate as 'Data wypożyczenia', r.DayCost as 'Dzienny koszt wypożyczenia [zł]' from Rent as r " +
                    "join Clients as c on c.ClientId = r.ClientId join Cars as cr on cr.CarId = r.CarId ", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }

        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie klientów w bazie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowClients_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("select c.ClientId as 'ID Klienta', c.FirstName as 'Imię', " +
                    "c.LastName as 'Nazwisko', c.City as 'Miasto', c.PhoneNumber as 'Numer telefonu' from Clients as c ", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }
        }

        /// <summary>
        /// Metoda wczytywana podczas załadowania FormInterface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInterface_Load(object sender, EventArgs e)
        {
            GetDataFromTable();
            groupBoxAddClient.Visible = groupBoxAddClient.Enabled = false;
            groupBoxCar.Visible = groupBoxCar.Enabled = false;
            groupBoxPlace.Visible = groupBoxPlace.Enabled = false;
            groupBoxRent.Visible = groupBoxRent.Enabled = false;
            groupBoxWorker.Visible = groupBoxWorker.Enabled = false;

        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie pracowników w bazie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowWorkers_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("select w.WorkerId as 'ID Pracownika', " +
                    "w.FirstName as 'Imię', w.LastName as 'Nazwisko', w.Password as 'Hasło do systemu', " +
                    "p.City as 'Miejsce pracy(miasto)', p.StreetName as 'Miejsce pracy(ulica)', w.HireDate as " +
                    "'Data zatrudnienia', w.Salary as 'Pensja [zł]' from Workers as w join Places as p on w.PlaceId = p.PlaceId ", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }

        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie samochodów w bazie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowCars_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("select cr.CarId as 'Id Samochodu', cr.CarBrand as 'Marka'," +
                    "cr.CarType as 'Typ', cr.Color as 'Kolor', cr.YearOfProduction as 'Rok produkcji', cr.Mileage as 'Przebieg [km]'," +
                    "r.Bail as 'Kaucja [zł]', r.DayCost as 'Dzienny koszt wypożyczenia [zł]' from Cars as cr join Rent as r on cr.CarId = r.CarId", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }

        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za wyświetlenie miejsc pracy w bazie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowPlaces_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("select p.PlaceId as 'Id Miejsca', p.City as 'Miasto', " +
                    "p.StreetName as 'Ulica'" +
                    " from Places as p ", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }
        }

        /// <summary>
        /// Funkcja obsługująca kliknięcie na item w menu dotyczący dodanie/usunięcie klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxAddClient.Visible = groupBoxAddClient.Enabled = true;

            groupBoxWorker.Enabled = groupBoxWorker.Visible = false;
            groupBoxRent.Enabled = groupBoxRent.Visible = false;
            groupBoxCar.Enabled = groupBoxCar.Visible = false;
            groupBoxPlace.Enabled = groupBoxPlace.Visible = false;
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za dodanie klienta do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SET IDENTITY_INSERT Clients ON;" +
                    "insert into Clients(ClientId, FirstName, LastName, " +
                    "PhoneNumber, City) values (" + textBoxClientId.Text +", N'"+ textBoxClientFirstName.Text+ "'," +
                    " N'"+ textBoxClientLastName.Text + "', " + textBoxClientPhoneNumber.Text+", N'" + textBoxClientCity.Text +"')"+
                    "SET IDENTITY_INSERT Clients OFF", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }
            buttonShowClients_Click(sender, e);
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za usunięcie klienta z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if(textBoxClientId.Text == "")
            {
                MessageBox.Show("Niepoprawne dane!");
            }
            else
            {
                using (var connection = dbConnectionCarRental())
                {
                    // Połączenia
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(
                        "delete from Clients where ClientId = " + textBoxClientId.Text, connection))
                    {
                        // Wynik zapytania do tabeli
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewCarRental.DataSource = table;
                    }
                }
                buttonShowClients_Click(sender, e);
            }

        }

        /// <summary>
        /// Funkcja kliknięcie na item w menu dotyczący dodanie/usunięcie pracownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pracownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxWorker.Enabled = groupBoxWorker.Visible = true;

            groupBoxCar.Enabled = groupBoxCar.Visible = false;
            groupBoxRent.Enabled = groupBoxRent.Visible = false;
            groupBoxAddClient.Enabled = groupBoxAddClient.Visible = false;
            groupBoxPlace.Enabled = groupBoxPlace.Visible = false;
        }


        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za dodanie pracownika w bazie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SET IDENTITY_INSERT Workers ON;" +
                    "insert into Workers(WorkerId, Password, FirstName, " +
                    "LastName, HireDate, Salary, PlaceId) values (" + textBoxWorkerId.Text + ", N'" + textBoxWorkerPassword.Text + "'," +
                    " N'" + textBoxWorkerFirstName.Text + "', N'" + textBoxWorkerLastName.Text + "', cast(N'" + textBoxWorkerHireDate.Text + "' as date)," +
                    ""+ textBoxWorkerSalary.Text+ ", "+ textBoxWorkerPlaceId.Text+ ")" +
                    "SET IDENTITY_INSERT Workers OFF", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }
            buttonShowWorkers_Click(sender, e);
            groupBoxWorker.Enabled = groupBoxWorker.Visible = false;

        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za usunięcie pracownika z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteWorker_Click(object sender, EventArgs e)
        {
            if (textBoxWorkerId.Text == "")
            {
                MessageBox.Show("Niepoprawne dane!");
            }
            else
            {
                using (var connection = dbConnectionCarRental())
                {
                    // Połączenia
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(
                        "delete from Workers where WorkerId = " + textBoxWorkerId.Text, connection))
                    {
                        // Wynik zapytania do tabeli
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewCarRental.DataSource = table;
                    }
                }
                buttonShowWorkers_Click(sender, e);
                groupBoxWorker.Enabled = groupBoxWorker.Visible = false;
            }

        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za dodanie miejsca pracy do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPlace_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SET IDENTITY_INSERT Places ON;" +
                    "insert into Places(PlaceId, StreetName, City) values (" + textBoxPlaceId.Text + 
                    ", N'" + textBoxPlaceStreetName.Text + "'," +
                    " N'" + textBoxPlaceCity.Text + "')" +
                    "SET IDENTITY_INSERT Places OFF", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }
            buttonShowPlaces_Click(sender, e);
            groupBoxPlace.Enabled = groupBoxPlace.Visible = false;

        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za usunięcie miejsca pracy z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeletePlace_Click(object sender, EventArgs e)
        {
            if (textBoxPlaceId.Text == "")
            {
                MessageBox.Show("Niepoprawne dane!");
            }
            else
            {
                using (var connection = dbConnectionCarRental())
                {
                    // Połączenia
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(
                        "delete from Places where PlaceId = " + textBoxPlaceId.Text, connection))
                    {
                        // Wynik zapytania do tabeli
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewCarRental.DataSource = table;
                    }
                }
                buttonShowPlaces_Click(sender, e);
                groupBoxPlace.Enabled = groupBoxPlace.Visible = false;
            }

        }

        /// <summary>
        /// Funkcja obsługująca kliknięcie na item w menu dotyczący dodanie/usunięcie miejsca pracy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miejsceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxPlace.Visible = groupBoxPlace.Enabled = true;

            groupBoxWorker.Enabled = groupBoxWorker.Visible = false;
            groupBoxRent.Enabled = groupBoxRent.Visible = false;
            groupBoxAddClient.Enabled = groupBoxAddClient.Visible = false;
            groupBoxCar.Enabled = groupBoxCar.Visible = false;
        }

        /// <summary>
        /// Funkcja obsługująca kliknięcie na item w menu dotyczący wyjścia z programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wyjścieZProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za dodanie samochodu do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCarAdd_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SET IDENTITY_INSERT Cars ON;" +
                    "insert into Cars(CarId, CarBrand, CarType, YearOfProduction, Color, Mileage)" +
                    " values (" + textBoxCarId.Text +
                    ", N'" + textBoxCarBrand.Text + "'," +
                    " N'" + textBoxCarType.Text + "', " +
                    ""+ textBoxCarYearOfProduction.Text+", N'"+textBoxCarColor.Text +"', " + textBoxCarMileage.Text+")" +
                    "SET IDENTITY_INSERT Cars OFF", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }
            buttonShowCars_Click(sender, e);
            groupBoxCar.Enabled = groupBoxCar.Visible = false;
        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za usunięcie samochodu z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCarDelete_Click(object sender, EventArgs e)
        {
            if (textBoxCarId.Text == "")
            {
                MessageBox.Show("Niepoprawne dane!");
            }
            else
            {
                using (var connection = dbConnectionCarRental())
                {
                    // Połączenia
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(
                        "delete from Cars where CarId = " + textBoxCarId.Text, connection))
                    {
                        // Wynik zapytania do tabeli
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewCarRental.DataSource = table;
                    }
                }
                buttonShowCars_Click(sender, e);
                groupBoxCar.Enabled = groupBoxCar.Visible = false;
            }

        }

        /// <summary>
        /// Funkcja obsługująca kliknięcie na item w menu dotyczący dodanie/usunięcie samochodu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void samochódToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxCar.Enabled = groupBoxCar.Visible = true;

            groupBoxWorker.Enabled = groupBoxWorker.Visible = false;
            groupBoxRent.Enabled = groupBoxRent.Visible = false;
            groupBoxAddClient.Enabled = groupBoxAddClient.Visible = false;
            groupBoxPlace.Enabled = groupBoxPlace.Visible = false;
        }

        /// <summary>
        /// Funkcja obsługująca kliknięcie na item w menu dotyczący dodanie/usunięcie wypożyczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wypożyczenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxRent.Enabled = groupBoxRent.Visible = true;

            groupBoxWorker.Enabled = groupBoxWorker.Visible = false;
            groupBoxCar.Enabled = groupBoxCar.Visible = false;
            groupBoxAddClient.Enabled = groupBoxAddClient.Visible = false;
            groupBoxPlace.Enabled = groupBoxPlace.Visible = false;

        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za dodanie wypożyczenia do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddRent_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionCarRental())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SET IDENTITY_INSERT Rent ON;" +
                    "insert into Rent(RentId, ClientId, CarId, PlaceId, RentDate, Bail, DayCost) values (" + textBoxRentId.Text +
                    ", " + textBoxRentClientId.Text + ", " +
                    textBoxRentCarId.Text + ", " + textBoxRentPlaceId.Text + ", "
                    + "cast(N'"+ textBoxRentDate.Text+ "' as date), "+ textBoxRentBail.Text + ", " + textBoxRentDayCost.Text + ")"+
                    "SET IDENTITY_INSERT Rent OFF", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCarRental.DataSource = table;
                }
            }
            buttonShowRent_Click(sender, e);
            groupBoxRent.Enabled = groupBoxRent.Visible = false;

        }

        /// <summary>
        /// Funkcja obsługująca przycisk odpowiedzialny za usunięcie wypożyczenia z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteRent_Click(object sender, EventArgs e)
        {
            if (textBoxRentId.Text == "")
            {
                MessageBox.Show("Niepoprawne dane!");
            }
            else
            {
                using (var connection = dbConnectionCarRental())
                {
                    // Połączenia
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(
                        "delete from Rent where RentId = " + textBoxRentId.Text, connection))
                    {
                        // Wynik zapytania do tabeli
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewCarRental.DataSource = table;
                    }
                }
                buttonShowRent_Click(sender, e);
                groupBoxRent.Enabled = groupBoxRent.Visible = false;
            }
        }

        /// <summary>
        /// Funkcja obsługująca kliknięcie na item w menu dotyczący informacji o programie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wyświetlaj odpowiednie tabele, aby poprawnie wpisywać dane. \nFormat daty: RRRR-MM-DD.");
        }
    }
}
