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

namespace kursach_01_01.pages
{
    /// <summary>
    /// Логика взаимодействия для my_page.xaml
    /// </summary>
    public partial class my_page : Page
    {
        public my_page()
        {
            InitializeComponent();
        }

        private void BtnNavigation_Click(object sender, RoutedEventArgs e)
        {
            string KeuPress = BtnNavigation.Content.ToString();
            if (KeuPress == "→")
            {
                ColumnBtn.Width = new GridLength(250);
                BtnNavigation.Content = "←";
                StackButton.Visibility = Visibility.Visible;
            }
            else
            if (KeuPress == "←")
            {
                ColumnBtn.Width = new GridLength(50);
                BtnNavigation.Content = "→";
                StackButton.Visibility = Visibility.Hidden;
            }
        }

        private void BtnShowPeople_Click(object sender, RoutedEventArgs e)
        {
            //ListDataPeople.ItemsSource = BdConnection.connection.user.ToList();
            //ListDataPeople.ItemsSource = BdConnection.connection.user.ToList();
        }

        private void ListDataPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
