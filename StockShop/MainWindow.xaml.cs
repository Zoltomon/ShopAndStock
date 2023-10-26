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
using StockShop.Views.Pages;
namespace StockShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigateClass.navigate.Navigate(new MainPage());
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void BtnDashWndw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMaxWndw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnExtWndw_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
