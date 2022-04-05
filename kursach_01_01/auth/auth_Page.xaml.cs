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
using kursach_01_01.pages;

namespace kursach_01_01.auth
{
    /// <summary>
    /// Логика взаимодействия для auth_Page.xaml
    /// </summary>
    public partial class auth_Page : Page
    {
        public auth_Page()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new main_page());
        }
    }
}
