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
    /// <summary>
    /// Логика взаимодействия для notes_page.xaml
    /// </summary>
    public partial class notes_page : Page
    {
        public notes_page()
        {
            InitializeComponent();
            //name.Text = datastud.Name_notes;
            //text.Text = datastud.Text;
            not.ItemsSource = DataBaseMethods.ShowNotes().ToList(); 
        }

        private void not_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var datastud = ((sender as ListView).SelectedItem as notes_class);
            name.Text = datastud.Name_notes;
            text.Text = datastud.Text;
        }

        private void add_notes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new add_notes());
        }
    }
}
