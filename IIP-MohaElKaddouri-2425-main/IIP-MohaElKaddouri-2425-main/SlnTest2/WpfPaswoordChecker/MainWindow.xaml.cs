using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPaswoordChecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int minLengte = 8;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void txtPasw_TextChanged(object sender, TextChangedEventArgs e)
        {
            BtnControleer.IsEnabled = true;
        }

        private void BtnControleer_Click(object sender, RoutedEventArgs e)
        {
            string paswoord = txtPasw.Text;
            bool minimumLengte = paswoord.Length >= minLengte;
            bool kleineLetters = paswoord.Any(char.IsLower);
            bool groteLetters = paswoord.Any(char.IsUpper);
            bool cijfers = paswoord.Any(char.IsNumber);
            bool speciaalKarakter = paswoord.Any(char.IsLetterOrDigit);

            txtAcht.Foreground = minimumLengte ? Brushes.Green : Brushes.Red;
            txtKlein.Foreground = kleineLetters ? Brushes.Green : Brushes.Red;
            txtGroot.Foreground = groteLetters ? Brushes.Green : Brushes.Red;
            txtCijfer.Foreground = cijfers ? Brushes.Green : Brushes.Red;
            txtVreemd.Foreground = speciaalKarakter ? Brushes.Green : Brushes.Red;

            int sterkte = WeergevenSterkte(paswoord, kleineLetters,groteLetters,cijfers,speciaalKarakter);
            BalkSterkte(sterkte);


        }
        private int WeergevenSterkte (string paswoord, bool kleineLetters,  bool groteLetters, bool cijfers, bool speciaalKarakter)
        {
            int L = paswoord.Length;
            int k = kleineLetters ? 1 : 0;
            int H = groteLetters ? 1 : 0;
            int S = speciaalKarakter ? 1 : 0;

            int sterkte = L * (k + H + S);
            
            return Math.Min (sterkte, 50);
        }
       private void BalkSterkte(int sterkte)
        {
            rctSterkte.Width = sterkte;
            if ( sterkte < 10)
            {
                txtSterkte.Text = "Zeer zwak";
                rctSterkte.Fill = Brushes.DarkRed;
            }
            else if (sterkte < 20)
            {
                txtSterkte.Text = "Zwak";
                rctSterkte.Fill = Brushes.Orange;
            }
            else if (sterkte < 30)
            {
                txtSterkte.Text = "Redelijk";
                rctSterkte.Fill = Brushes.Yellow;
            }
            else if (sterkte < 40)
            {
                txtSterkte.Text = "Goed";
                rctSterkte.Fill = Brushes.Green;
            }
            else
            {
                txtSterkte.Text = "Zeer geod";
                rctSterkte.Fill = Brushes.DarkGreen;
            }
        }
    }
}