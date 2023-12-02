using StockShop.Classes;
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

namespace StockShop.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private string _role;
        public MainPage(string role)
        {
            InitializeComponent();
            NavigateClass.navigate = FrmMainPage;
            FrmMainPage.Navigate(new HomePage());
            _role = role;
            VisibleButton(role);
        }
        private void VisibleButton(string role)
        {
            switch(role)
            {
                case "Администратор системы":
                    BtnUsers.Visibility = Visibility.Visible;
                    BtnRep.Visibility = Visibility.Visible;
                    BtnMain.Visibility = Visibility.Visible;
                    BtnSupplier.Visibility = Visibility.Visible;
                    BtnIndicators.Visibility = Visibility.Visible;
                    break;
                case "Работник склада":
                    BtnUsers.Visibility = Visibility.Collapsed;
                    BtnRep.Visibility = Visibility.Collapsed;
                    BtnMain.Visibility = Visibility.Visible;
                    BtnSupplier.Visibility = Visibility.Collapsed;
                    BtnIndicators.Visibility = Visibility.Collapsed;
                    break;
                case "Менеджер склада":
                    BtnUsers.Visibility = Visibility.Collapsed;
                    BtnRep.Visibility = Visibility.Visible;
                    BtnMain.Visibility = Visibility.Visible;
                    BtnSupplier.Visibility = Visibility.Visible;
                    BtnIndicators.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            NavigateClass.navigate.Navigate(new HomePage());
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnIndicators_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUsers_Click(object sender, RoutedEventArgs e)
        {
            NavigateClass.navigate.Navigate(new UsersPage());
        }
    }
}
