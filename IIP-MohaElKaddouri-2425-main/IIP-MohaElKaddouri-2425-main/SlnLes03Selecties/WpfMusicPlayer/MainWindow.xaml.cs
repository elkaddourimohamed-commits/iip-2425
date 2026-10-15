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

namespace WpfMusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer mediaPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LstMuziek_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstMuziek.SelectedItem is ListBoxItem selectedItem)
            {
                string muziekgeselecteerd = selectedItem.Content.ToString();
                txtMuziek.Text = selectedItem.Content.ToString();
                string doculink = selectedItem.Tag.ToString();

                try
                {    
                    mediaPlayer.Open(new Uri(doculink, UriKind.Relative));
                    mediaPlayer.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : Impossible de lire le fichier.\n{ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void SldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtVolume.Text = $"{(int)sldVolume.Value}%";
            mediaPlayer.Volume = sldVolume.Value / 100;
        }
        private void LstThema_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {    
            if (lstThema.SelectedItem is ListBoxItem selectedItem)
            {
                if (selectedItem == lstStandaard)
                {
                    this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E8E8E8"));
                }
                else if (selectedItem == lstGeel)
                {
                    this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFD1"));
                }
                else if (selectedItem == lstBlauw)
                {
                    this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ACE7FF"));
                }
                else if (selectedItem == lstRood)
                {
                    this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBEBC"));
                }
                else if (selectedItem == lstGroen)
                {
                    this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DBFFD6"));
                }
            }
        }
}
}