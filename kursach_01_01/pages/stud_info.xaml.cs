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
using System.Windows.Shapes;
using kursach_01_01.BD_class;

namespace kursach_01_01.pages
{
    /// <summary>
    /// Логика взаимодействия для stud_info.xaml
    /// </summary>
    public partial class stud_info : Window
    {
        public static students_class currentSrudent;
       
        public stud_info(students_class datastud)
        {
            InitializeComponent();
            this 
            txt_surname.Text = datastud.Surname;
            txt_name.Text = datastud.Name;
            txt_lname.Text = datastud.Lname;
        }
    }
}
