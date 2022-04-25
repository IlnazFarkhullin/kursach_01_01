﻿using System;
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
            std.ItemsSource= DataBaseMethods.ShowStudents();
        }

        private void std_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            stud_info _Info = new stud_info();
            _Info.Show();
        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            //std.ItemsSource = conn.entities.info.ToList().Where(z => z.name.Contains(search.Text)); //поиск по имени
            std.ItemsSource = DataBaseMethods.ShowStudents().ToList().Where(z => z.Name.Contains(serach_tb.Text));
        }
    }
}
