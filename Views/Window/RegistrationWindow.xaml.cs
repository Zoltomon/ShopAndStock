using Newtonsoft.Json;
using StockShop.Classes;
using StockShop.Models;
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

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxbEmail.Text == null || TxbLogin.Text == null || TxbPassword.Password == null || TxbTelephone.Text == null)
                {
                    MessageBox.Show("Введите данные в поля ввода");
                }
                else
                {
                    if(TxbPassword.Password == TxbCopyPass.Text)
                    {
                        string hashPass = BCrypt.Net.BCrypt.HashPassword(TxbPassword.Password);
                        UserProfile newUser = new UserProfile()
                        {
                            Login = TxbLogin.Text,
                            Password = hashPass,
                            Email = TxbEmail.Text,
                            Telephone = TxbTelephone.Text,
                            RoleId = 1,
                            StatusId = 1,
                            TypeOrdId = 1
                        };
                        ConnectDB.connect.UserProfiles.Add(newUser);
                        ConnectDB.connect.SaveChanges();
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
