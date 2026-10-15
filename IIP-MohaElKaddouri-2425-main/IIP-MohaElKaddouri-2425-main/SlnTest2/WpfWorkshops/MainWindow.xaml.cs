using System.Reflection.Metadata.Ecma335;
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

namespace WpfWorkshops
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {    
        public MainWindow()
        {
            string[] namen = { "Koken voor dummies", "Wijnproeven", "Robots programmeren" };
            int[] inschrijvingen = { 10, 12, 15 };
            int[] aantal = { 1, 2, 3, 4, 5 };
            List<int> reservaties = new List<int>() { 0 };
            InitializeComponent();
            namen = cmbWorkshop.Items.Cast<string>().ToArray();
            aantal = cmbAantal.Items.Cast<int>().ToArray();
        }

        private void BtnBevestigen_Click(object sender, RoutedEventArgs e)
        {
            if (cmbWorkshop.SelectedIndex == 0)
            {
                cmbWorkshop.SelectedItem = lstBezetingen.SelectedItem;
                Console.WriteLine("8/10");
            }
            else if (cmbWorkshop.SelectedIndex == 1)
            {
                cmbWorkshop.SelectedItem = lstBezetingen.SelectedItem;
            }
            else
            {
                cmbWorkshop.SelectedItem = lstBezetingen.SelectedItem;
            }
        }
        private void AantalBeschikbarePlaatsen()
        {
            string naam = inpNaam.Text;
            string aantal = ((ComboBoxItem)cmbAantal.SelectedItem)?.Content.ToString();
            }
}
}