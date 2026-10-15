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

namespace WpfBmi
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

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            string lengte = inpLengte.Text;
            int lengtecm = Convert.ToInt32(lengte);            

            string gewicht = inpGewicht.Text;
            int gewichtkg = Convert.ToInt32(gewicht);            

            try
            {
                double lengtefinal = (lengtecm / 100) * (lengtecm / 100);
                double bmi = gewichtkg / lengtefinal;
                bmi = Math.Round(bmi, 2);
                txtAntwoord.Text = $"{bmi:F1}";
            }
            catch 
            { 
            }
        }
}
    }