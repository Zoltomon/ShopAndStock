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
        public MainPage()
        {
            InitializeComponent();
            NavigateClass.navigate = FrmMainPage;
            FrmMainPage.Navigate(new HomePage());
        }

        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            NavigateClass.navigate.Navigate(new HomePage());
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
