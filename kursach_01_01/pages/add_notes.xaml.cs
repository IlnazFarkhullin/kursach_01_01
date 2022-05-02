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
    /// Логика взаимодействия для add_notes.xaml
    /// </summary>
    public partial class add_notes : Page
    {
        public add_notes()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

            notes_class notes = new notes_class(txt_name.Text, txt_text.Text, date.DisplayDate);
            DataBaseMethods.AddSNotes(notes);

            MessageBox.Show($"Запись:\n {txt_name.Text} добавлена", "Регистрация студента", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new notes_page());
        }
    }
}
