using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfWinkel
{
    /// <summary>
    /// WpfWinkel
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        const double PRICEART1 = 2.2;
        const double PRICEART2 = 3.05;
        const double PRICEART3 = 2.75;

        int stock1, stock2, stock3;

        public MainWindow()
        {
            InitializeComponent();
            ResetStore();
        }
        
        private void ResetStore()
        {
            Random rnd = new Random();
            stock1 = rnd.Next(5, 41);
            stock2 = rnd.Next(5, 41);
            stock3 = rnd.Next(5, 41);

            UpdateStockDisplay();
            lstBox.Items.Clear();
            txtTotaal.Text = "";
        }
       
        private void UpdateStockDisplay()
        {
            txtStock1.Text = $"{stock1} over";
            txtStock2.Text = $"{stock2} over";
            txtStock3.Text = $"{stock3} over";
        }
        
        private void BtnOpt1_Click(object sender, RoutedEventArgs e)
        {
            if (stock1 > 0)
            {
                stock1--;
                lstBox.Items.Add($" 2,2 - 1 tros bananen");
                UpdateStockDisplay();
            }
        }
        
        private void BtnOpt2_Click(object sender, RoutedEventArgs e)
        {
            if (stock2 > 0)
            {
                stock2--;
                lstBox.Items.Add("3,05 - 1 pak boter");
                UpdateStockDisplay();
            }
        }
        
        private void BtnOpt3_Click(object sender, RoutedEventArgs e)
        {
            if (stock3 > 0)
            {
                stock3--;
                lstBox.Items.Add("2,75 - 1 doos eieren");
                UpdateStockDisplay();
            }
        }
        
        private void BtnAfrekenen_Click(object sender, RoutedEventArgs e)
        {
            double total = 0;
            btnAfrekenen.IsEnabled = lstBox.Items.Count > 0;

            foreach (string item in lstBox.Items)
            {
                if (item.Contains("2,2"))
                {
                    total += PRICEART1;
                }
                else if (item.Contains("3,05"))
                {
                    total += PRICEART2;
                }
                else if (item.Contains("2,75")) 
                { 
                    total += PRICEART3;
                }
                txtTotaal.Text = $"{total:F1} euro";
            }
        }
        
        private void BtnHerstartWinkel_Click(object sender, RoutedEventArgs e)
        {
            ResetStore();
        }
    }
}
