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
using System.Windows.Shapes;
using kursach_01_01.BD_class;
using kursach_01_01.pages;

namespace kursach_01_01.pages
{
    /// <summary>
    /// Логика взаимодействия для stud_info.xaml
    /// </summary>
    public partial class stud_info : Window
    {
        students_class postStudent;
        public stud_info(students_class datastud)//приём данных из одной формы на данную форму
        {
            InitializeComponent();
            postStudent = datastud;
            this.DataContext = postStudent;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            //var selectedStudent = dann.SelectedItem as students_class;
            DataBaseMethods.EditStudent(postStudent.Surname, postStudent.Name, postStudent.Lname, postStudent.email, postStudent.Phone, postStudent.Registration, txt_surname.Text, txt_name.Text, txt_lname.Text, email.Text, phone_number.Text, regis.Text);
            MessageBox.Show("Изменения сохранены");
        }
    }
}
