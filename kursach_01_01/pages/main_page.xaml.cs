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

namespace kursach_01_01.pages
{
    /// <summary>
    /// Логика взаимодействия для main_page.xaml
    /// </summary>
    /// 
   

    public partial class main_page : Page
    {

       
 
        public main_page()
        {
            InitializeComponent();
            
        }

       
        
        private void pahel_header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void DragMove()
        {
            throw new NotImplementedException();
        }

        private void my_page_Selected(object sender, RoutedEventArgs e)
        {
            
        }

       

        private void stud_page_Selected(object sender, RoutedEventArgs e)
        {
           page.NavigationService.Navigate(new students_page());
            
        }

         public void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheets/d/1ynXHCux3WO-C8L7C9gKhpq4f-HsMLRyq879F8y613mI/edit#gid=2063958257"); //открытие ссылки в браузере


        }
    }
}
