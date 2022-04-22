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
using kursach_01_01.pages;
using MongoDB.Bson;
using MongoDB.Driver;
using kursach_01_01.BD_class;

namespace kursach_01_01.auth
{
    /// <summary>
    /// Логика взаимодействия для auth_Page.xaml
    /// </summary>
    public partial class auth_Page : Page
    {
        public auth_Page()
        {
            InitializeComponent();
            

        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
           
            var a = DataBaseMethods.Authorizations().Where(z => z.login == txt_login.Text && z.password == txt_password.Password).FirstOrDefault();
            if (a !=null)
            {
                //var b = a.name.FirstOrDefault();
                if (a.name == "Ильназ Алмазович")
                {
                    MessageBox.Show($"Добро пожаловать {a.name}" ,"Вход в личные кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new main_page());
                }
            }
            else
            {
                MessageBox.Show($"Логин и пароль не верный!", "Вход в личный кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
