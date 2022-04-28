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

        //private void add_Click(object sender, RoutedEventArgs e)
        //{

        //    //students_class clients = new students_class() { Nname = txt_sname.Text, name = txt_name.Text, patronymic = txt_lastname.Text, hp = birthday.SelectedDate, age = Convert.ToInt32(txt_age.Text), diagnosis = txt_diagnozc.Text, id_branches = ((BD.Branches)CombClass.SelectedItem).id_branches, id_ward = ((BD.Ward)CombClass1.SelectedItem).id_ward, id_staff = ((BD.Staff)CombClass2.SelectedItem).id_staff };
        //    //students_class client = new students_class(){ Surname = txt_sname.Text, Name=txt_name};
        //    //BD.connect.conn.Patient.Add(clients);

        //    //DataBaseMethods.AddStudentToDatabase();
        //    //BD.connect.conn.SaveChanges();
        //    students_class stud = new students_class(txt_name.Text, txt_sname.Text, txt_sname.Text, birthday.ToString());
        //    MessageBox.Show($"Сотрудник:\n {txt_sname.Text} {txt_name.Text} {txt_lastname.Text} зарегестрирован", "info", MessageBoxButton.OK, MessageBoxImage.Information);
        //}

        //private void add_Click_1(object sender, RoutedEventArgs e)
        //{

        //}

        private void adddd_Click(object sender, RoutedEventArgs e)
        {
            students_class stud = new students_class(txt_name.Text, txt_sname.Text, txt_sname.Text, birthday.ToString(), phone.Text, medic_polic.Text, innn.Text, seriya.Text, kod.Text, reg.Text, mail.Text);
            DataBaseMethods.AddStudentToDatabase(stud);
            
            MessageBox.Show($"Студент:\n {txt_sname.Text} {txt_name.Text} {txt_lastname.Text} зарегестрирован", "Регистрация студента", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
