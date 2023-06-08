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
    /// Логика взаимодействия для PageCarsAdd.xaml
    /// </summary>
    public partial class PageCarsAdd : Page
    {
        private Cars _currentCars = new Cars();
        public PageCarsAdd(Cars selectedCars)
        {
            InitializeComponent();
            if (selectedCars != null)
                _currentCars = selectedCars;


            DataContext = _currentCars;
        }

        private void btnSave_Click_1(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentCars.Model))
                errors.AppendLine("Укажите название модели");
            if (_currentCars.Quantity <= 0)
                errors.AppendLine("Количество не может быть меньше или равно 0");
            if (_currentCars.Price <= 0)
                errors.AppendLine("Цена не может быть меньше или равно 0");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentCars.CarID == 0)
                diplomEntities.GetContext().Cars.Add(_currentCars);
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
