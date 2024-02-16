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
using WpfApp1.Components;

namespace WpfApp1.MyPages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void StartGameBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text == "")
            {
                MessageBox.Show("Логин должен быть заполнен!");
            }
            else
            {
                Navigations.NextPage(new ChoicePersonPage());
            }
            
        }

        private void Back1Btn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextPage(new MainPage());
        }
    }
}
