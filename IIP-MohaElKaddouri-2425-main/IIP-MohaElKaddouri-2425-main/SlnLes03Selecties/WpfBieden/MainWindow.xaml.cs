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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double hoogstebod = 0;
        string hoogstebieder = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnBod_Click(object sender, RoutedEventArgs e)
        {
            string naam = inpNaam.Text;
            double bodInput = Convert.ToDouble(inpBod.Text);
            if (bodInput > hoogstebod)
            {
                hoogstebod = bodInput;
                hoogstebieder = naam;
                txtCom.Text = $"{hoogstebieder} heeft met {hoogstebod} euro nu het hoogste bod!";
            }
            else
            {
                txtCom.Text = $"Sorry, {hoogstebieder} heeft momenteel het hoogste bod.";
            }
            inpNaam.Text = string.Empty;
            inpBod.Text = string.Empty;
        }
        }
}