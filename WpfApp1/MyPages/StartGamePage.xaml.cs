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
using WpfApp1.Components;

namespace WpfApp1.MyPages
{
    /// <summary>
    /// Логика взаимодействия для StartGamePage.xaml
    /// </summary>
    public partial class StartGamePage : Page
    {
        public StartGamePage()
        {
            InitializeComponent();
            DefinitionPerson.gamePage = this;
            DefinitionPerson.StartInfo(App.Role);
        }

        private void BackExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextPage(new MainPage());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
