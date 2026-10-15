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

namespace WpfIngredienten
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

        private void BtnBoodschap_Click(object sender, RoutedEventArgs e)
        {
            string aantalpersonen = txtAantalpersonen.Text;
            double aantalpersoon = Convert.ToDouble(aantalpersonen);

            string hvl1 = txtHvl1.Text;
            int hoeveelheid1 = Convert.ToInt32(hvl1);

            string hvl2 = txtHvl2.Text;
            double hoeveelheid2 = Convert.ToDouble(hvl2);

            string hvl3 = txtHvl3.Text;
            double hoeveelheid3 = Convert.ToDouble(hvl3);

            string hvl4 = txtHvl4.Text;
            double hoeveelheid4 = Convert.ToDouble(hvl4);

            string eenheid1 = txtEenheid1.Text;
            string eenheid2 = txtEenheid2.Text;
            string eenheid3 = txtEenheid3.Text;
            string eenheid4 = txtEenheid4.Text;

            string ingredient1 = txtIngredient1.Text;
            string ingredient2 = txtIngredient2.Text;
            string ingredient3 = txtIngredient3.Text;
            string ingredient4 = txtIngredient4.Text;

            double finalhoeveelheid1 = aantalpersoon * hoeveelheid1;
            double finalhoeveelheid2 = aantalpersoon * hoeveelheid2;
            double finalhoeveelheid3 = aantalpersoon * hoeveelheid3;
            double finalhoeveelheid4 = aantalpersoon * hoeveelheid4;

            txtFinal.Text += $@"
-{finalhoeveelheid1} {eenheid1} {ingredient1}
-{finalhoeveelheid2} {eenheid2} {ingredient2}
-{finalhoeveelheid3} {eenheid3} {ingredient3}
-{finalhoeveelheid4} {eenheid4} {ingredient4}";
}
    }
}