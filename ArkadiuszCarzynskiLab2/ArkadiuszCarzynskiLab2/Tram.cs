using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab2
{
    public class Tram : Vehicle, IPantograph
    {
        bool pantographIsDown;
        /// <summary>
        /// Konstruktor klasy Tram
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Tram(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;
            pantographIsDown = false;
        }

        /// <summary>
        /// Zaimplementowanie funkcji odziedziczonej po interfejsie IPantoGraph
        /// </summary>
        /// <returns></returns>
        public string PantographDown()
        {
            if(pantographIsDown == false)
            {
                pantographIsDown = true;
                return "Opuszczono pantograf";
            }
            else
            {
                return "Pantograf jest juz opuszczony!";
            }
        }


        /// <summary>
        /// Metoda implementująca metode odziedziczonej po interfejsie IPantoGraph
        /// </summary>
        /// <returns></returns>
        public string PantographUp()
        {
            if(pantographIsDown == true)
            {
                pantographIsDown = false;
                return "Podniesiono pantograf";
            }
            else
            {
                return "Pantograf jest juz podniesiony!";
            }
        }

        /// <summary>
        /// Dzwonienie tramwajem
        /// </summary>
        /// <returns></returns>
        public string Bell()
        {
            return "Tramwaj dzwoni!";
        }

        /// <summary>
        /// Implementacja metod odziedziczonych po klasie Vehicle
        /// </summary>
        /// <returns></returns>
        public override string StartVehicle()
        {
            if(pantographIsDown == false)
            {
                return "Tramwaj odjeżdza";
            }
            else
            {
                return "Pantograf jest opuszczony! Nie można ruszyć tramwajem";
            }
        }

        /// <summary>
        /// Implementacja metody odziedziczonej po klasie Vehicle
        /// </summary>
        /// <returns></returns>
        public override string StopVehicle()
        {
            return "Tramwaj się zarzymuje";

        }
    }
}
