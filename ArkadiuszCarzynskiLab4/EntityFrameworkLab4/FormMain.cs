using EntityFrameworkLab4.Models;
using EntityFrameworkLab4.Repositories;
using System;
using System.Windows.Forms;

namespace EntityFrameworkLab4
{
    public partial class FormMain : Form
    {

        private readonly ISkiJumpingGeneric<Jumper> _jumpers;
        private readonly ISkiJumpingGeneric<Country> _countries;
        public FormMain()
        {
            InitializeComponent();
            _jumpers = new SkiJumperGeneric<Jumper>();
            _countries = new SkiJumperGeneric<Country>();
            LoadJumpers();
            LoadCountries();
        }

        private void LoadJumpers()
        {
            dataGridViewJumpers.DataSource = _jumpers.GetAll();
        }

        private void LoadCountries()
        {
            dataGridViewCountries.DataSource = _countries.GetAll();
        }

        /// <summary>
        /// Edycja danych skoczka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperUpdate_Click(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// Usunięcie skoczka z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperDelete_Click(object sender, EventArgs e)
        {
            _jumpers.DeleteById(Int32.Parse(dataGridViewJumpers.SelectedRows[0].Cells[0].Value.ToString()));
            _jumpers.Save();
            LoadJumpers();
        }

        /// <summary>
        /// Wyświetlenie informacji o skoczku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperShow_Click(object sender, EventArgs e)
        {
            var selectedJumperIndex = Int32.Parse(dataGridViewJumpers.SelectedRows[0].Cells[0].Value.ToString());
            var showJumper = _jumpers.GetById(selectedJumperIndex);

            showJumper.Country = _countries.GetById(showJumper.CountryId);
            MessageBox.Show("Kraj skoczka: " + showJumper.Country.Name);
        }

        /// <summary>
        /// Usunięcie kraju z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryDelete_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Edycja danych kraju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryUpdate_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Wyświetlenie informacji o kraju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryShow_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Dodanie nowego skoczka do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperAdd_Click(object sender, EventArgs e)
        {
            var jumperFirstName = textBoxJumperFirstName.Text;
            var jumperLastName = textBoxJumperLastName.Text;
            var jumperBirthdate = dateTimePickerJumper.Text;
            var countryId = textBoxJumperCountryId.Text;

            Jumper newJumper = new Jumper
            {
                FirstName = jumperFirstName,
                LastName = jumperLastName,
                Birthdate = Convert.ToDateTime(jumperBirthdate),
                CountryId = Int32.Parse(countryId)
            };

            _jumpers.Create(newJumper);
            _jumpers.Save();
            LoadJumpers();
        }

        /// <summary>
        /// Dodanie nowego kraju do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryAdd_Click(object sender, EventArgs e)
        {
            var countryName = textBoxCountryName.Text;
            var countryRecord = textBoxCountryRecord.Text;


        }

        /// <summary>
        /// Zapis zmian danych skoczka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperSaveChanges_Click(object sender, EventArgs e)
        {
            int jumperUpdatedId = Int32.Parse(textBoxUpdateJumperId.Text);
            var jumperUpdatedFirstName = textBoxUpdateJumperFirstName.Text;
            var jumperUpdatedLastName = textBoxUpdateJumperLastName.Text;
            var jumperUpdatedBirthdate = dateTimePickerUpdateJumper.Text;
            var jumperUpdatedCountryId = textBoxUpdateCountryId.Text;


        }
    }
}
