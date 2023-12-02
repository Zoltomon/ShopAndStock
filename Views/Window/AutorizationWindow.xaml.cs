using Newtonsoft.Json;
using StockShop.Classes;
using StockShop.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace StockShop.Views.Window
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void BtnExtWndw_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnDashWndw_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void BtnMaxWndw_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void BtnAuto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(TxbLog.Text ==null || TxbPass.Password == null)
                {
                    MessageBox.Show("Введите данные в поля ввода");
                }
                else
                {
                    var connection = ConnectDB.connect.UserProfiles.FirstOrDefault(x => x.Login == TxbLog.Text);
                    bool verifyPass = BCrypt.Net.BCrypt.Verify(TxbPass.Password, connection.Password);
                    if (verifyPass != null || connection != null)
                    {
                        switch(connection.Status.Name)
                        {
                            case "Аккаунт активен":
                                switch (connection.Role.Name)
                                {
                                    case "Администратор системы":
                                        MainWindow mainWindow = new MainWindow(connection.Role.Name);
                                        MessageBox.Show($"Добро пожаловать \nваша роль {connection.Role.Name}");
                                        mainWindow.Show();
                                        break;
                                    case "Менеджер склада":
                                        MainWindow mainWindow2= new MainWindow(connection.Role.Name);
                                        MessageBox.Show($"Добро пожаловать \nваша роль {connection.Role.Name}");
                                        mainWindow2.Show();
                                        break;
                                }
                                break;
                            case "Аккаунт неактивен":
                                MessageBox.Show($"Ваш аккаунт {connection.Status.Name}\nОбратитесь к администратору системы");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RegistrationWindow registrationWindow = new RegistrationWindow();
                registrationWindow.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
