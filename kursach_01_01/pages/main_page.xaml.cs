using System;
using System.Collections.Generic;
using System.Diagnostics;// нужен для открытия браузера(Process.Start)
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
using System.Windows.Threading;
using kursach_01_01.BD_class;

namespace kursach_01_01.pages
{
    public partial class main_page : Page
    {
        public main_page()
        {
            InitializeComponent();
            page.NavigationService.Navigate(new my_page());
        }
        private void my_page_Selected(object sender, RoutedEventArgs e)
        {
            page.Navigate(new my_page()); // открытие на Frame page страницы my_page
        }
        private void stud_page_Selected(object sender, RoutedEventArgs e)
        {
           page.Navigate(new students_page()); //открытие на Frame page страницы student_page
        }
         public void Hyperlink_Click(object sender, RoutedEventArgs e)
         {
            Process.Start("https://docs.google.com/spreadsheets/d/1ynXHCux3WO-C8L7C9gKhpq4f-HsMLRyq879F8y613mI/edit#gid=2063958257"); //открытие ссылки в браузере
         }
        private void notes_Selected(object sender, RoutedEventArgs e)
        {
            page.Navigate(new notes_page()); // открытие на Frame page страницы notes_page
        }
        private void exit_Selected(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new auth.auth_Page());
        }
        private void timetable_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheets/d/1kQxBMF9mOxY4Ct82Wz1BWZ1FdxegJb_h/edit#gid=122381148");
        }
    }
}
