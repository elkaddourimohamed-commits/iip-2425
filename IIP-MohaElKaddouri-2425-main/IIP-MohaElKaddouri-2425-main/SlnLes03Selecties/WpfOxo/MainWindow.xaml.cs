using System.Windows;
using System.Windows.Controls;

namespace WpfOxo
{
    /// <summary>
    /// 
    /// Hier is de summary
    /// </summary>
    public partial class MainWindow : Window
    {
        bool xeerste = true; // wie moet spelen
        bool klaar = false;  // spel klaar

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // klaar
            if (klaar) 
            { 
                return; 
            }

            // button geklikt
            Button btn = sender as Button;

            // button moet leeg zijn
            if (string.IsNullOrEmpty(btn.Content?.ToString()))
            {
                // x en o
                btn.Content = xeerste ? "X" : "O";

                // veranderen van speler
                xeerste = !xeerste;

                // Vwie is gewonnen
                Winnaar();
            }
        }

        private void Winnaar()
        {
            string[,] bord = new string[3, 3];

            // tabel vullen met btn content
            bord[0, 0] = btn0.Content?.ToString();
            bord[0, 1] = btn1.Content?.ToString();
            bord[0, 2] = btn2.Content?.ToString();
            bord[1, 0] = btn3.Content?.ToString();
            bord[1, 1] = btn4.Content?.ToString();
            bord[1, 2] = btn5.Content?.ToString();
            bord[2, 0] = btn6.Content?.ToString();
            bord[2, 1] = btn7.Content?.ToString();
            bord[2, 2] = btn8.Content?.ToString();

            // welke lijn doet winnen
            if (Lijnen(bord[0, 0], bord[0, 1], bord[0, 2]) || // Ligne 1
                Lijnen(bord[1, 0], bord[1, 1], bord[1, 2]) || // Ligne 2
                Lijnen(bord[2, 0], bord[2, 1], bord[2, 2]) || // Ligne 3
                Lijnen(bord[0, 0], bord[1, 0], bord[2, 0]) || // Colonne 1
                Lijnen(bord[0, 1], bord[1, 1], bord[2, 1]) || // Colonne 2
                Lijnen(bord[0, 2], bord[1, 2], bord[2, 2]) || // Colonne 3
                Lijnen(bord[0, 0], bord[1, 1], bord[2, 2]) || // Diagonale 1
                Lijnen(bord[0, 2], bord[1, 1], bord[2, 0])) // Diagonale 2
            {
                // cspeler 1 of 2 is gewonnen
                txtResultaat.Text = $"{(!xeerste ? "speler 1" : "speler 2")} heeft gewonnen!";
                klaar = true; // klaar
                if (klaar)
                {
                    btn0.IsEnabled = false;
                    btn1.IsEnabled = false;
                    btn2.IsEnabled = false;
                    btn3.IsEnabled = false;
                    btn4.IsEnabled = false;
                    btn5.IsEnabled = false;
                    btn6.IsEnabled = false;
                    btn7.IsEnabled = false;
                    btn8.IsEnabled = false;
                }
}
        }
        private bool Lijnen(string a, string b, string c)
        {
            return !string.IsNullOrEmpty(a) && a == b && b == c;
        }
    }
}
