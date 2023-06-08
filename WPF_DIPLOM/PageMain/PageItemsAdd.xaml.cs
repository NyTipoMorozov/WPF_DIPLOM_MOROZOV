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
    /// Логика взаимодействия для PageItemsAdd.xaml
    /// </summary>
    public partial class PageItemsAdd : Page
    {
        private Items _currentItems= new Items();
        public PageItemsAdd(Items selectedItems)
        {
            InitializeComponent();
            if (selectedItems != null)
                _currentItems = selectedItems;


            DataContext = _currentItems;
        }

        private void bSave_Click_1(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentItems.Name))
                errors.AppendLine("Укажите название аксессуара");
            if (_currentItems.Quantity <= 0)
                errors.AppendLine("Количество не может быть меньше или равно 0");
            if (_currentItems.Price <= 0)
                errors.AppendLine("Цена не может быть меньше или равно 0");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentItems.ItemID == 0)
                diplomEntities.GetContext().Items.Add(_currentItems);
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
        private void bBack_Click_1(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.GoBack();
        }
    }
    
}
