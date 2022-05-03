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
using kursach_01_01.pages;
using MongoDB.Bson;
using MongoDB.Driver;

 namespace kursach_01_01.pages
{
    /// <summary>
    /// Логика взаимодействия для regestration_page.xaml
    /// </summary>
    public partial class regestration_page : Page
    {
        public regestration_page()
        {
            InitializeComponent();
        }


        private void adddd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_sname.Text)) //проверка на пустое значение
            {
                MessageBox.Show("Запоните поля Имя  и Фамилия !!!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
               students_class stud = new students_class(txt_sname.Text, txt_name.Text, txt_lastname.Text, birthday.ToString(), phone.Text,   mail.Text, medic_polic.Text, innn.Text, seriya.Text, kod.Text, reg.Text);
               DataBaseMethods.AddStudentToDatabase(stud);
               MessageBox.Show($"Студент:\n {txt_sname.Text} {txt_name.Text} {txt_lastname.Text} зарегестрирован", "Регистрация студента", MessageBoxButton.OK, MessageBoxImage.Information);
            }
           
            
        }

      

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new students_page());
        }

        
        
    }
}
