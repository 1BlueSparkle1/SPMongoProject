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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AuthorizationSp.Visibility = Visibility.Collapsed;
            ChoiceSp.Visibility = Visibility.Collapsed;
        }

        private void EntranceBtn_Click(object sender, RoutedEventArgs e)
        {
            StartMenuSp.Visibility = Visibility.Collapsed;
            AuthorizationSp.Visibility = Visibility.Visible;
            ChoiceSp.Visibility = Visibility.Collapsed;
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Настройки временно недоступны.");
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Back1Btn_Click(object sender, RoutedEventArgs e)
        {
            StartMenuSp.Visibility= Visibility.Visible;
            AuthorizationSp.Visibility= Visibility.Collapsed;
            ChoiceSp.Visibility= Visibility.Collapsed;
            LoginTb.Text = "";
        }

        private void Back2Btn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationSp.Visibility= Visibility.Visible;
            StartMenuSp.Visibility = Visibility.Collapsed;
            ChoiceSp.Visibility= Visibility.Collapsed;
        }

        private void StartGameBtn_Click(object sender, RoutedEventArgs e)
        {
            ChoiceSp.Visibility = Visibility.Visible;
            StartMenuSp.Visibility = Visibility.Collapsed;
            AuthorizationSp.Visibility = Visibility.Collapsed;
            LoginTb.Text = "";
        }

        private void RogueBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WarriorBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WizardBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
