using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfEllipsen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private int aantalEllipsen;
        private int minRadius;
        private int maxRadius;

        private int currentEllipseIndex = 0; 
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();

            sliderAantal.ValueChanged += Slider_ValueChanged;
            sliderMinRadius.ValueChanged += Slider_ValueChanged;
            sliderMaxRadius.ValueChanged += Slider_ValueChanged;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100); 
            timer.Tick += Timer_Tick;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblAantal.Content = sliderAantal.Value.ToString("0");
            lblMinRadius.Content = sliderMinRadius.Value.ToString("0");
            lblMaxRadius.Content = sliderMaxRadius.Value.ToString("0");

            if (sliderMinRadius.Value > sliderMaxRadius.Value)
            {
                txtError.Text = "Minimum mag niet groter zijn dan Maximum!";
                btnTekenen.IsEnabled = false;
            }
            else
            {
                txtError.Text = "";
                btnTekenen.IsEnabled = true;
            }
        }
        private void BtnTekenen_Click(object sender, RoutedEventArgs e)
        {
            canvas1.Children.Clear();
            currentEllipseIndex = 0;

            aantalEllipsen = (int)sliderAantal.Value;
            minRadius = (int)sliderMinRadius.Value;
            maxRadius = (int)sliderMaxRadius.Value;

            timer.Start();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (currentEllipseIndex >= aantalEllipsen)
            {
                timer.Stop(); 
                return;
            }

            int taille = random.Next(minRadius, maxRadius);
            byte r = (byte)random.Next(0, 256);
            byte g = (byte)random.Next(0, 256);
            byte b = (byte)random.Next(0, 256);

            double xPos = random.Next(0, (int)(canvas1.ActualWidth - taille));
            double yPos = random.Next(0, (int)(canvas1.ActualHeight - taille));

            Ellipse ellipse = new Ellipse()
            {
                Width = taille,
                Height = taille,
                Fill = new SolidColorBrush(Color.FromRgb(r, g, b))
            };

            Canvas.SetLeft(ellipse, xPos);
            Canvas.SetTop(ellipse, yPos);

            canvas1.Children.Add(ellipse);
            currentEllipseIndex++; 
        }
    }
}
