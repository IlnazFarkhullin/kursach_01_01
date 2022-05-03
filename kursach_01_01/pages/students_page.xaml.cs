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
using kursach_01_01.BD_class;
namespace kursach_01_01.pages
{
    /// <summary>
    /// Логика взаимодействия для students_page.xaml
    /// </summary>
    public partial class students_page : Page
    {
        public students_page()
        {
            InitializeComponent();
            std.ItemsSource= DataBaseMethods.ShowStudents(); // std - это ListView
                                                             // DataBaseMethods -это класс где хранятся всякие методы
                                                             //ShowStudents(); - это метод из класса DataBaseMethods. Этот метод выводит студентов
        }

        private void std_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var datastud = ((sender as ListView).SelectedItem as students_class);// передача данных на другую форму
            
            stud_info _Info = new stud_info(datastud);// передача данных на другую форму
            _Info.Show();// открытие окна при нажатии на элемент ListView
            

           
            
        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            std.ItemsSource = DataBaseMethods.ShowStudents().ToList().Where(z => z.Surname.Contains(serach_tb.Text));//поиск о фамилии
        }

        private void add_students_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new regestration_page());
        }

        private void delete_Click(object sender, RoutedEventArgs e) //Удаление студента
        {
            var a = std.SelectedItem as students_class;
           DataBaseMethods.RemoveStudentToDatabase(a._id);
          MessageBox.Show("Запись удалена", "Регистрация студента", MessageBoxButton.OK, MessageBoxImage.Information);
          
        }

        private void sort_az_Click(object sender, RoutedEventArgs e)
        {
            std.ItemsSource = DataBaseMethods.ShowStudents().ToList().OrderBy(z => z.Surname);//Сортировка по алфавиту от А до Я
        }

        //private void edit_Click(object sender, RoutedEventArgs e)
        //{
        //    var datastud = std.SelectedItem as students_class;
        //   // DataBaseMethods.EditStudent(datastud.Surname, datastud.Name, datastud.Lname, datastud.email, datastud.Phone, datastud.Registration, txt_surname.Text, txt_name.Text, txt_lname.Text, email.Text, phone_number.Text, regis.Text);
        //    MessageBox.Show("Изменения сохранены", "Сохранение изменений", MessageBoxButton.OK, MessageBoxImage.Information);

        //}
    }
}
