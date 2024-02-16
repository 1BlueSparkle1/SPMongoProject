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
    /// Логика взаимодействия для ChoicePersonPage.xaml
    /// </summary>
    public partial class ChoicePersonPage : Page
    {
        public ChoicePersonPage()
        {
            InitializeComponent();
        }

        private void WarriorBtn_Click(object sender, RoutedEventArgs e)
        {
            App.Role = "Warrior";
            Navigations.NextPage(new StartGamePage());
        }

        private void RogueBtn_Click(object sender, RoutedEventArgs e)
        {
            App.Role = "Rogue";
            Navigations.NextPage(new StartGamePage());
        }

        private void WizardBtn_Click(object sender, RoutedEventArgs e)
        {
            App.Role = "Wizard";
            Navigations.NextPage(new StartGamePage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextPage(new AuthorizationPage());
        }
    }
}
