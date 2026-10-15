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

namespace WpfNamenFilter
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

        private void InpZoeken_TextChanged(object sender, TextChangedEventArgs e)
        {
            string zoekenn = inpZoeken.Text.ToLower();
            int aantalmatches = 0;

            foreach (ListBoxItem item in lstNamen.Items)
            {
                string naam = item.Content.ToString().ToLower();

                if (!string.IsNullOrEmpty(zoekenn) && naam.Contains(zoekenn))
                {
                    item.Background = Brushes.DarkRed;
                    aantalmatches++;
                }
                else
                {
                    item.Background = Brushes.White;
                }
            }
            txtMatches.Text = aantalmatches.ToString();
        }
    }
}