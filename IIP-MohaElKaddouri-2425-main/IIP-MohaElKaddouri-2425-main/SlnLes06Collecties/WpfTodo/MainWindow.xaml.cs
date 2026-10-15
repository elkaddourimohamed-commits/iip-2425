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

namespace WpfTodo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // lijst van taken
        private List<ListBoxItem> tasks = new List<ListBoxItem>();

        // lijst van verwijderde taken (stack voor het terugzetten)
        private Stack<ListBoxItem> removedTasks = new Stack<ListBoxItem>();

        // Kleurarray voor prioriteiten
        private SolidColorBrush[] priorityColors = new SolidColorBrush[]
        {
            new SolidColorBrush(Colors.DarkGreen),   // Laag
            new SolidColorBrush(Colors.DarkOrange),  // Gemiddeld
            new SolidColorBrush(Colors.DarkRed) // Hoog
        };
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string taskDescription = txtTaak.Text;
            string priority = ((ComboBoxItem)cmbPrioriteit.SelectedItem)?.Content.ToString();

            // nieuwe ListBoxItem
            ListBoxItem newTask = new ListBoxItem
            {
                Content = taskDescription,
                Foreground = GetPriorityColor(priority)
            };

            tasks.Add(newTask);
            lstTaak.Items.Add(newTask);
            txtTaak.Clear();
            cmbPrioriteit.SelectedIndex = -1;

            // verwijder knoppen uitschakelen
            btnVerwijderen.IsEnabled = true;
            btnTerugzetten.IsEnabled = false;
        }

        private SolidColorBrush GetPriorityColor(string priority)
        {
            switch (priority.ToLower())
            {
                case "laag":
                    return priorityColors[0];
                case "gemiddeld":
                    return priorityColors[1];
                case "hoog":
                    return priorityColors[2];
                default:
                    return new SolidColorBrush(Colors.Black); // defaultkleur (voor het geval)
            }
        }

        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            if (lstTaak.SelectedItem != null)
            {
                ListBoxItem selectedItem = (ListBoxItem)lstTaak.SelectedItem;
                tasks.Remove(selectedItem);
                removedTasks.Push(selectedItem);
                lstTaak.Items.Remove(selectedItem);

                // inschakelen van de Terugzetten knop
                btnTerugzetten.IsEnabled = true;

                // uitschakelen van de Verwijder knop als geen taak is geselecteerd
                btnVerwijderen.IsEnabled = lstTaak.SelectedItems.Count > 0;
            }
        }

        private void BtnTerugzetten_Click(object sender, RoutedEventArgs e)
        {
            if (removedTasks.Count > 0)
            {
                ListBoxItem lastRemovedTask = removedTasks.Pop();
                tasks.Add(lastRemovedTask);
                lstTaak.Items.Add(lastRemovedTask);

                // als er geen verwijderde taken meer zijn, uitschakelen van de Terugzetten knop
                if (removedTasks.Count == 0)
                {
                    btnTerugzetten.IsEnabled = false;
                }
            }
        }
    }
}