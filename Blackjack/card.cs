using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

/* Welcher Random value ergibt welche Karte
 * 2 = 2
 * 3 = 3
 * 4 = 4
 * 5 = 5
 * 6 = 6
 * 7 = 7
 * 8 = 8
 * 9 = 9
 * 10 = 10
 * 11 = Junge
 * 12 = Dame
 * 13 = König
 * 14 = Ass
*/


namespace Blackjack
{
    class card
    {
        Random rand = new Random();
        /// <summary>
        /// string der Kartenname Beispiels König, zwei
        /// </summary>
        public string name;

        /// <summary>
        /// Der Wert dieser Karte achtung Ass ist eine Sonderregeln
        /// </summary>
        public int value;

        /// <summary>
        /// Falls es ein Ass darunter hat gibt dieser boolean true. Braucht man für die Sonderregel
        /// </summary>
        public Boolean ass;
        /// <summary>
        /// Konstruktor für Karte
        /// </summary>
        public card()
        {
            int temp1 = rand.Next(2, 15);
            switch (temp1)
            {
                case 2:
                    name = "zwei";
                    value = 2;
                    break;
                case 3:
                    name = "drei";
                    value = 3;
                    break;
                case 4:
                    name = "vier";
                    value = 4;
                    break;
                case 5:
                    name = "fünf";
                    value = 5;
                    break;
                case 6:
                    name = "sechs";
                    value = 6;
                    break;
                case 7:
                    name = "sieben";
                    value = 7;
                    break;
                case 8:
                    name = "acht";
                    value = 8;
                    break;
                case 9:
                    name = "neun";
                    value = 9;
                    break;
                case 10:
                    name = "zehn";
                    value = 10;
                    break;
                case 11:
                    name = "Junge";
                    value = 10;
                    break;
                case 12:
                    name = "Dame";
                    value = 10;
                    break;
                case 13:
                    name = "König";
                    value = 10;
                    break;
                case 14:
                    name = "Ass";
                    value = 1;
                    ass = true;
                    break;
                default:
                    MessageBox.Show("Unerwarteter Fehler ist aufgetreten!", "Error", MessageBoxButton.OK);
                    break;
            }
        }


    }
}
