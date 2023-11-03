using Newtonsoft.Json;
using StockShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow
    {
        public RegistrationWindow()
        {
            InitializeComponent();
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AutorizationWindow autorizationWindow = new AutorizationWindow();
                autorizationWindow.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxbLogin.Text == null || TxbEmail.Text == null || TxbPassword.Password == null)
                {
                    MessageBox.Show("Введите данные в поля ввода");
                }
                else if (TxbPassword.Password != TxbCopyPass.Text)
                {
                    MessageBox.Show("Неверно повторен пароль");
                }
                else
                {
                    string url = $"https://localhost:7089/CreateNote";
                    string pass = TxbPassword.Password;
                    string login = TxbLogin.Text;
                    string telephone = TxbTelephone.Text;
                    string email = TxbEmail.Text;

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        var regData = new UserClass
                        {
                            UserLogin = login,
                            UserPassword = pass,
                            UserEmail = email,
                            UserTelephone = telephone,
                        };

                        string jsonContent = JsonConvert.SerializeObject(regData);
                        HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                        var response = await client.PostAsync(url, content);

                        var responseContent = await response.Content.ReadAsStringAsync();

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            MessageBox.Show("Успешно");
                        }
                        else
                        {
                            MessageBox.Show("плохо");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
