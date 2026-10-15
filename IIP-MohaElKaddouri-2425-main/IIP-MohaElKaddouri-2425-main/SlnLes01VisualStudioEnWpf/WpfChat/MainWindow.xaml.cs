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

namespace WpfChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnVerzend_Click(object sender, RoutedEventArgs e)
        { // waarden
            string naam = inpNaam.Text.Trim();
            string bericht = inpBericht.Text.Trim();

            // mag niet leeg zijn
            if (!string.IsNullOrEmpty(naam) && !string.IsNullOrEmpty(bericht))
            {
                // verplaatsing
                txtChat.Text += $"{naam} says:\n {bericht}\n";

                // verwijderen text
                inpNaam.Text = string.Empty;
                inpBericht.Text = string.Empty;
            }
        }
    }
}