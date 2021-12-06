using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
// Eine erwähnenswerte Quelle
// https://www.istockphoto.com/de/grafiken/blackjack-table-background
// Bild für den Hintergrund
namespace Blackjack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Eigenschaften
        //Falls man zweimal hintereinander passt dann hört es auf
        int passcount = 0;
        //True = Spieler 1 false = Spieler 2
        Boolean whois = true;
        //Instanzierung
        Runde testround = new Runde();
        /// <summary>
        /// Falls gerade eine Runde bevorsteht False = man ist einer Runde true = die Runde wurde abgeschlossen man ist in keiner Runde
        /// </summary>
        Boolean roundfinished = false;

        /// <summary>
        /// Eine liste von den vergangenen Runden
        /// </summary>
        List<Runde> rundenlist = new List<Runde>();

        public MainWindow()
        {

            InitializeComponent();

        }

        private void passenbut_Click(object sender, RoutedEventArgs e)
        {
            passcount++;
            if (passcount >= 2)
            {
                finishround();
            }
            wechseln();
        }

        private void karteaufnehmenbut_Click(object sender, RoutedEventArgs e)
        {
            card newcard = new card();
            MessageBox.Show(newcard.name, "Your card");
            if (whois)
            {
                testround.cardcollection1.Add(newcard);
            }
            else
            {
                testround.cardcollection2.Add(newcard);
            }
            passcount = 0;
            wechseln();
        }
        /// <summary>
        /// Methode zum Spieler wechseln
        /// </summary>
        public void wechseln()
        {
            spielerwechsel.Visibility = Visibility.Visible;
            spielerwechsel.IsEnabled = true;
            if (whois)
            {
                spielerwechsel.Content = "Spieler2 ist dran";
                whois = false;
                valuelabel.Content = $"Der gesamtwert: {testround.value2()} \n Keine Angst das Ass passt sich an \n {testround.showcards2()}";
            }
            else
            {
                spielerwechsel.Content = "Spieler1 ist dran";
                whois = true;
                valuelabel.Content = $"Der gesamtwert: {testround.value1()} \n Keine Angst das Ass passt sich an \n {testround.showcards1()}";

            }

        }
        /// <summary>
        /// Void zum abschliessen der Runde. Macht eine neue Instanz wechselt den Content ab und ruft whowon und finishround auf
        /// </summary>
        public void finishround()
        {
            testround.whowon();
            roundfinished = true;
            spielerwechsel.Content = "Neue Runde starten";
            rundenlist.Add(testround);
            testround = new Runde();
        }
        /// <summary>
        /// Ruft das Pausenmenu auf
        /// </summary>
        public void pausemenu()
        {

        }

        /// <summary>
        /// Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spielerwechsel_Click(object sender, RoutedEventArgs e)
        {

            spielerwechsel.Visibility = Visibility.Hidden;
            spielerwechsel.IsEnabled = false;
        }
    }
}
