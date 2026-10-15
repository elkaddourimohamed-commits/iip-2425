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

namespace WpfSliderKleur
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

        private void SldKleur_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int waarde = Convert.ToInt32(Math.Round(sldKleur.Value));
            txtCijfer.Text = waarde.ToString();
            if (waarde <= 30)
            {
                txtCijfer.Foreground = new SolidColorBrush(Colors.Green);
            }
            else if (waarde > 30 && waarde <= 50)
            {
                txtCijfer.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else if (waarde > 50 && waarde <= 80)
            {
                txtCijfer.Foreground = new SolidColorBrush(Colors.DarkOrange);
            }
            else if (waarde > 80)
            {
                txtCijfer.Foreground = new SolidColorBrush(Colors.DarkRed);
            }
        }
    }
}