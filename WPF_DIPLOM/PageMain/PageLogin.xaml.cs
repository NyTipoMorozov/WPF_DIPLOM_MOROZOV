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
using WPF_DIPLOM.AplicationData;

namespace WPF_DIPLOM.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageMain.PageСreateAcc());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppConnect.modelOdb.Users.FirstOrDefault(x => x.Login == txbLogin.Text && x.Password == psbPassword.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Данные указаны не верно!", "Ошибка авторизации",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userObj.IdRole)
                    {
                        case true:
                            MessageBox.Show("Здраствуйте, Администратор " + userObj.Name + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            NavigationService.Navigate(new PagesList());
                            break;
                        case false:
                            MessageBox.Show("Здраствуйте, Пользователь " + userObj.Name + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            NavigationService.Navigate(new PageUser());
                            break;
                    }

                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая ошибка приложения",
                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageMain.PageGost1());
        }
    }
    }

