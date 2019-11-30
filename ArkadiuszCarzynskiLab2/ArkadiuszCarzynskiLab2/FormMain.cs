using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiLab2
{
    public partial class FormMain : Form
    {
        // Lista pojazdów
        private List<Vehicle> vehiclesList = new List<Vehicle>();
        private int listIndex;
        private Vehicle vehicle;
        public FormMain()
        {
            InitializeComponent();
            listIndex = 0;
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            if(radioButtonBus.Checked)
            {
                // utworzenie obiektu vehicle który będzie tramwajem
                vehicle = new Bus(Int32.Parse(textBoxVehicleNumber.Text),
                    Int32.Parse(textBoxYearOfProduction.Text), textBoxName.Text);

            }
            if(radioButtonTram.Checked)
            {
                // utworzenie obiektu vehicle ktory bedzie autobusem
                vehicle = new Tram(Int32.Parse(textBoxVehicleNumber.Text),
                    Int32.Parse(textBoxYearOfProduction.Text), textBoxName.Text);

            }
            vehiclesList.Add(vehicle);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            vehicle = vehiclesList[Math.Abs(listIndex-- % vehiclesList.Count)];
            labelActualNumberDescription.Text = vehicle.GetVehicleNumber().ToString();
            labelActualYearOfProductionDescription.Text = vehicle.GetYearOfProduction().ToString();
            labelActualModelDescription.Text = vehicle.GetName();
            if(vehicle is Tram)
            {
                labelActualVehicleDescription.Text = "Tramwaj";
            }
            else
            {
                labelActualVehicleDescription.Text = "Autobus";
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            vehicle = vehiclesList[Math.Abs(listIndex++ % vehiclesList.Count)];
            labelActualNumberDescription.Text = vehicle.GetVehicleNumber().ToString();
            labelActualYearOfProductionDescription.Text = vehicle.GetYearOfProduction().ToString();
            labelActualModelDescription.Text = vehicle.GetName();
            if (vehicle is Tram)
            {
                labelActualVehicleDescription.Text = "Tramwaj";
            }
            else
            {
                labelActualVehicleDescription.Text = "Autobus";
            }
        }

        /// <summary>
        /// Ruszenie pojazdem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicle.StartVehicle());
        }

        /// <summary>
        /// Zatrzymanie pojazdu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicle.StopVehicle());
        }

        private void buttonRingBell_Click(object sender, EventArgs e)
        {
            if(vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
                MessageBox.Show(tram.Bell());
            }
            MessageBox.Show("Obiekt nie jest tramwajem!");
        }

        private void buttonRefuel_Click(object sender, EventArgs e)
        {
            if(vehicle is Bus)
            {
                Bus bus = (Bus)vehicle;
                MessageBox.Show(bus.Refuel());
            }
            else
            {
                MessageBox.Show("Wybrany obiekt nie jest autobusem!");
            }
        }

        private void buttonPantographDown_Click(object sender, EventArgs e)
        {
            if(vehicle is Tram)
            {
                Tram t = (Tram)vehicle;
                MessageBox.Show(t.PantographDown());
            }
            else
            {
                MessageBox.Show("Wybrany obiekt nie jest tramwajem!");

            }
        }

        private void buttonPantographUp_Click(object sender, EventArgs e)
        {
            if (vehicle is Tram)
            {
                Tram t = (Tram)vehicle;
                MessageBox.Show(t.PantographUp());
            }
            else
            {
                MessageBox.Show("Wybrany obiekt nie jest tramwajem!");

            }
        }
    }
}
