using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Blackjack
{
    class Runde
    {
        public List<card> cardcollection1 = new List<card>();
        public List<card> cardcollection2 = new List<card>();




        public Runde()
        {
            cardcollection1 = new List<card>();
            cardcollection2 = new List<card>();
        }


        public bool hatass1()
        {

            foreach (card item in cardcollection1)
            {
                if (item.ass)
                {
                    return true;
                }
            }
            return false;
        }

        public bool hatass2()
        {

            foreach (card item in cardcollection1)
            {
                if (item.ass)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Methode für Spieler1 gibt den Wert der Karten das Ass passt sich an
        /// </summary>
        /// <returns>Den Wert der Karten das Ass passt sich an</returns>
        public int value1()
        {
            if (hatass1())
            {
                int temp1 = 0;
                foreach (card item in cardcollection1)
                {
                    temp1 += item.value;
                }
                if (temp1 + 10 <= 21)
                {
                    //Es ist unter 21 also das Ass könnte man als 10 gelten lassen
                    temp1 += 10;
                }
                return temp1;
            }
            else
            {
                int temp2 = 0;
                foreach (card item in cardcollection1)
                {
                    temp2 += item.value;
                }
                return temp2;
            }

        }
        /// <summary>
        /// Methode für Spieler2 gibt den Wert der Karten das Ass passt sich an 
        /// </summary>
        /// <returns>Den Wert der Karten das Ass passt sich an</returns>
        public int value2()
        {
            if (hatass2())
            {
                int temp1 = 0;
                foreach (card item in cardcollection2)
                {
                    temp1 += item.value;
                }
                if (temp1 + 10 <= 21)
                {
                    //Es ist unter 21 also das Ass könnte man als 10 gelten lassen
                    temp1 += 10;
                }
                return temp1;
            }
            else
            {
                int temp2 = 0;
                foreach (card item in cardcollection2)
                {
                    temp2 += item.value;
                }
                return temp2;
            }

        }

        /// <summary>
        /// Wertet es aus
        /// </summary>
        /// <returns>1 = Spieler 1 hat gewonnen 2 = Spieler 2 hat gewonnen 0 = es ist unentschieden</returns>
        public int whowon()
        {
            if (value1() > 21 && value2() > 21)
            {
                //Beide sind über 21 Unentschieden
                MessageBox.Show("Unentschieden", "Unentschieden", MessageBoxButton.OK);
                return 0;
            }
            else
            {
                if (value1() > 21)
                {
                    //Spieler 2 hat gewonnen
                    MessageBox.Show("Spieler 2 hat gewonnen", "win", MessageBoxButton.OK);
                    return 2;
                }
                else if (value2() > 21)
                {
                    MessageBox.Show("Spieler 1 hat gewonnen", "win", MessageBoxButton.OK);
                    return 1;
                }
                else if (value1() > value2())
                {
                    MessageBox.Show("Spieler 1 hat gewonnen", "win", MessageBoxButton.OK);
                    return 1;
                }
                else
                {
                    MessageBox.Show("Spieler 2 hat gewonnen", "win", MessageBoxButton.OK);
                    return 2;
                }

            }

        }

        public string showcards1()
        {
            string temp1 = "Du hast folgende Karten: \n";
            foreach (card item in cardcollection1)
            {
                temp1 += $"{item.name} \n";
            }
            return temp1;
        }


        public string showcards2()
        {
            string temp1 = "Du hast folgende Karten: \n";
            foreach (card item in cardcollection2)
            {
                temp1 += $"{item.name} \n";
            }
            return temp1;
        }
        /// <summary>
        /// 
        /// </summary>
        public void finishround()
        {

        }


    }
}
