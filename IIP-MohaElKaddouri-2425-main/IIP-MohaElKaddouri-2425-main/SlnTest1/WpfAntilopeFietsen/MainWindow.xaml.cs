using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAntilopeFietsen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double Fiets1 = 1399;
        const double Fiets2 = 1349;
        const double Fiets3 = 2299;
        double finalprijs = 0;
        public MainWindow()
        {
            InitializeComponent();
            if (cmbCargo.IsSelected)
            {
                finalprijs = 1399;
                imgFiets1.Visibility = Visibility.Visible;
                imgFiets2.Visibility = Visibility.Collapsed;
                imgFiets3.Visibility = Visibility.Collapsed;
            }
            else if (cmbTrans.IsSelected)
            {
                finalprijs = 1349;
                imgFiets1.Visibility = Visibility.Collapsed;
                imgFiets2.Visibility = Visibility.Visible;
                imgFiets3.Visibility = Visibility.Collapsed;
            }
            else if (cmbElek.IsSelected)
            {
                finalprijs = 2299;
                imgFiets1.Visibility = Visibility.Collapsed;
                imgFiets2.Visibility = Visibility.Collapsed;
                imgFiets3.Visibility = Visibility.Visible;
            }
}

        private void BtnPrijs_Click(object sender, RoutedEventArgs e)
        {
            if (rdoStandaard.IsChecked == true)
            {
                finalprijs = finalprijs + 0;
            }
            else if (rdoGroot.IsChecked == true)
            {
                finalprijs = finalprijs + 50;
            }
            if (chxBel.IsChecked == true)
            {
                finalprijs = finalprijs + 25;
            }
            else if (chxZacht.IsChecked == true)
            {
                finalprijs = finalprijs + 30;
            }
            else if (chxBagage.IsChecked == true)
            {
                finalprijs = finalprijs + 50;
            }
            txtPrijs.Text = $"{finalprijs:C}";
        }
    }
    }