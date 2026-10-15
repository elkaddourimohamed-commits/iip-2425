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

namespace WpfPrijsVraag
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
        private void Rbtn_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtn4.IsChecked == true)
            {
                txtJuist.Visibility = Visibility.Visible;
                txtFout.Visibility = Visibility.Collapsed;

                rbtnP1.IsEnabled = true;
                rbtnP2.IsEnabled = true;
                rbtnP3.IsEnabled = true;

                imgCadeau.Opacity = 1;
            }
            else
            {
                txtJuist.Visibility = Visibility.Collapsed;
                txtFout.Visibility = Visibility.Visible;

                rbtnP1.IsEnabled = false;
                rbtnP2.IsEnabled = false;
                rbtnP3.IsEnabled = false;
            }
        }
        private void RbtnP_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtnP1.IsChecked == true)
            {
                imgSlijp.Visibility = Visibility.Visible;
                imgStoon.Visibility = Visibility.Collapsed;
                imgTand.Visibility = Visibility.Collapsed;
                txtSlijp.Visibility = Visibility.Visible;
                txtStoon.Visibility = Visibility.Collapsed;
                txtTand.Visibility = Visibility.Collapsed;
            }
            if (rbtnP2.IsChecked == true)
            {
                imgStoon.Visibility = Visibility.Visible;
                imgSlijp.Visibility = Visibility.Collapsed;
                imgTand.Visibility = Visibility.Collapsed;
                txtStoon.Visibility = Visibility.Visible;
                txtSlijp.Visibility = Visibility.Collapsed;
                txtTand.Visibility = Visibility.Collapsed;
            }
            if (rbtnP3.IsChecked == true)
            {
                imgTand.Visibility = Visibility.Visible;
                imgSlijp.Visibility = Visibility.Collapsed;
                imgStoon.Visibility = Visibility.Collapsed;
                txtTand.Visibility = Visibility.Visible;
                txtSlijp.Visibility = Visibility.Collapsed;
                txtStoon.Visibility = Visibility.Collapsed;
            }
            rbtnP1.IsEnabled = false;
            rbtnP2.IsEnabled = false;
            rbtnP3.IsEnabled = false;
        }
    }
}