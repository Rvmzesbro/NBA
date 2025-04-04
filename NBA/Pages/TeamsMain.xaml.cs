using System;
using System.Collections.Generic;
using System.Linq;
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

namespace NBA.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeamsMain.xaml
    /// </summary>
    public partial class TeamsMain : Page
    {
        public TeamsMain()
        {
            InitializeComponent();
        }

        private void BTBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisitorMenu());
        }

        private void DGAtlantic_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if(DGAtlantic.SelectedItem is ....)
            //{
            //    NavigationService.Navigate(new TeamDetail(....));
            //}

            NavigationService.Navigate(new TeamDetail());
        }

        private void DGCentral_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if(DGCentral.SelectedItem is ....)
            //{
            //    NavigationService.Navigate(new TeamDetail(....));
            //}

            NavigationService.Navigate(new TeamDetail());
        }

        private void DGSoutheast_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if(DGSoutheast.SelectedItem is ....)
            //{
            //    NavigationService.Navigate(new TeamDetail(....));
            //}

            NavigationService.Navigate(new TeamDetail());
        }

        private void DGNorthwest_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if(DGNorthwest.SelectedItem is ....)
            //{
            //    NavigationService.Navigate(new TeamDetail(....));
            //}

            NavigationService.Navigate(new TeamDetail());
        }

        private void DGPacific_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if(DGPacific.SelectedItem is ....)
            //{
            //    NavigationService.Navigate(new TeamDetail(....));
            //}

            NavigationService.Navigate(new TeamDetail());
        }

        private void DGSouthwest_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if(DGSouthwest.SelectedItem is ....)
            //{
            //    NavigationService.Navigate(new TeamDetail(....));
            //}

            NavigationService.Navigate(new TeamDetail());
        }
    }
}
