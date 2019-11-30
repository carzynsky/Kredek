using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab2
{
    class Bus : Vehicle
    {
        int gasoilLevel;

        /// <summary>
        /// Konstruktor klasy Bus
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Bus(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;

        }

        /// <summary>
        /// Metoda zwracająca informację o zatankowaniu autobusu
        /// </summary>
        /// <returns></returns>
        public string Refuel()
        {
            gasoilLevel = 100;
            return "Autobus został zatankowany";

        }
        /// <summary>
        /// Implementacja metod odziedziczonych po klasie Vehicle
        /// </summary>
        /// <returns></returns>
        public override string StartVehicle()
        {
            return "Autobus odjeżdza";
        }

        /// <summary>
        /// Implementacja metody odziedziczonej po klasie Vehicle
        /// </summary>
        /// <returns></returns>
        public override string StopVehicle()
        {

            return "Autobus się zatrzymuje";
        }
    }
}
