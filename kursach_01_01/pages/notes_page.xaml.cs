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
using MongoDB.Bson;
using MongoDB.Driver;
using kursach_01_01.BD_class;

namespace kursach_01_01.pages
{
    public partial class notes_page : Page
    {
        public notes_page()
        {
            InitializeComponent();
            not.ItemsSource = DataBaseMethods.ShowNotes().ToList();
        }
        private void not_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (not.SelectedIndex == -1)
                return;
            else
            {
                name.Text = ((notes_class)not.SelectedItem).Name_notes;
                text.Text = ((notes_class)not.SelectedItem).Text;
            }
        }
        private void add_notes_Click(object sender, RoutedEventArgs e) // добавление
        {
            NavigationService.Navigate(new add_notes());
        }
        private void delete_Click(object sender, RoutedEventArgs e) // удаление
        {
            
            var z = not.SelectedItem as notes_class;
            if (z != null)
            {
                DataBaseMethods.RemoveNotes(z._id);
                not.ItemsSource = null;
                not.ItemsSource = DataBaseMethods.ShowNotes().ToList();
                name.Text = null;
                text.Text = null;
            }
            else
            {
                MessageBox.Show("Выберите запись");
            }
        }
    }
}
