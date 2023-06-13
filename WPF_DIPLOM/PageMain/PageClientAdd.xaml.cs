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
    /// Логика взаимодействия для PageClientAdd.xaml
    /// </summary>
    public partial class PageClientAdd : Page

    {
        private Client _currentClient = new Client();
        public PageClientAdd(Client selectedClient)

        {
            InitializeComponent();
            if (selectedClient != null)
                _currentClient = selectedClient;
            DataContext = _currentClient;
        }
        private void btnSave_Click_1(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentClient.SecondName))
                errors.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_currentClient.Name))
                errors.AppendLine("Укажите Имя");
            if (string.IsNullOrWhiteSpace(_currentClient.ThirdName))
                errors.AppendLine("Укажите Отчество");
            if (string.IsNullOrWhiteSpace(_currentClient.PhoneNumber))
                errors.AppendLine("Укажите номер телефона");
            if (string.IsNullOrWhiteSpace(_currentClient.email))
                errors.AppendLine("Укажите действующий email или gmail");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentClient.ClientID == 0)
                diplomEntities.GetContext().Client.Add(_currentClient);
            try
            {
                diplomEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                AppFrame.FrameMain.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnBack_Click_1(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.GoBack();
        }
    }
    
}
