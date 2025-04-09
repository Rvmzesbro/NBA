using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NBA.Pages
{
    /// <summary>
    /// Логика взаимодействия для PlayersMain.xaml
    /// </summary>
    public partial class PlayersMain : Page
    {
        ToggleButton currentToggle;
        public PlayersMain()
        {
            InitializeComponent();
            GenerateFilterButtons();
        }

        private void GenerateFilterButtons()
        {
            string chars = "qwertyuiopasdfghjklzxcvbnm";
            foreach (char c in chars.OrderBy(x => x))
            {
                var toggleButton = new ToggleButton();
                toggleButton.Content = c;
                toggleButton.Click += ToggleButton_Click;
                SPFilterButtons.Children.Add(toggleButton);
            }
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentToggle != null)
                currentToggle.IsChecked = false;
            currentToggle = (sender as ToggleButton);

            var v = (char)currentToggle.Content;
        }

        private void BTBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TeamDetail());
        }

        private void TBSearchName_GotFocus(object sender, RoutedEventArgs e)
        {
            if(TBSearchName.Text == "Name")
            {
                TBSearchName.Text = "";
            }
        }

        private void TBSearchName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBSearchName.Text))
            {
                TBSearchName.Text = "Name";
            }
        }

        private void DGPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new PlayerDetail());
        }

        private void DGPlayers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PlayerDetail());
        }
    }
}
