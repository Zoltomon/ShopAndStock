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

        private async void BtnAuto_Click(object sender, RoutedEventArgs e)
        {
                try
                {
                    if (TxbLog.Text == null || TxbPass.Password == null)
                    {
                        MessageBox.Show("Введите данные");
                    }
                    else
                    {
                        string url = $"https://localhost:7089/api/User?UserLogin={TxbLog.Text}&UserPassword={TxbPass.Password}";
                        HttpClient client = new HttpClient();
                        var response = await client.GetAsync(url);
                        var responseContent = await response.Content.ReadAsStringAsync();
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            var userResponseList = JsonConvert.DeserializeObject<List<UserClass>>(responseContent);
                            if (userResponseList.Count > 0)
                            {
                                var userStatus = userResponseList[0].UserStatus;
                                var userRole = userResponseList[0].UserRole;
                                switch (userStatus)
                                {
                                    case "Аккаунт активен":
                                        switch (userRole)
                                        {
                                            case "Администратор системы":
                                                MainWindow mainWindow = new MainWindow(userRole);
                                                mainWindow.Show();
                                                this.Close();
                                                break;
                                            case "Работник склада":
                                                break;
                                            case "Менеджер склада":
                                                break;
                                        }
                                        break;
                                    case "Аккаунт неактивен":
                                        MessageBox.Show("Ваш аккаунт заблокирован\nОбратитесь к администратору вашей системы");
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден");
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
