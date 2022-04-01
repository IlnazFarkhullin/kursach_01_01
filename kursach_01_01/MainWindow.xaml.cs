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
using kursach_01_01.auth;//подключение к папке

namespace kursach_01_01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //autorization.Navigate(new auth_Page());
            studentgrid.ItemsSource = ShowStudent(null);
        }

        public static List<student> ShowStudent(string std)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("test");
            //var collection = database.GetCollection<students>(std);

            IMongoCollection<student> collection = database.GetCollection<student>(std);
            return collection.Find(x => true).ToList();
        }
    }
}
