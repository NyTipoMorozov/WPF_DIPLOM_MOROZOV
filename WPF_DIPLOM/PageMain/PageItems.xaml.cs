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
    /// Логика взаимодействия для PageItems.xaml
    /// </summary>
    public partial class PageItems : Page
    {
        public PageItems()
        {
            InitializeComponent();
            DtGridTovar.ItemsSource = diplomEntities.GetContext().Items.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageItemsAdd((sender as Button).DataContext as Items));
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var ItemsForRemoning = DtGridTovar.SelectedItems.Cast<Items>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующее {ItemsForRemoning.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    diplomEntities.GetContext().Items.RemoveRange(ItemsForRemoning);
                    diplomEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DtGridTovar.ItemsSource = diplomEntities.GetContext().Items.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageItemsAdd(null));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageMain.PagesList());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                diplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DtGridTovar.ItemsSource = diplomEntities.GetContext().Items.ToList();
            }
        }
    }
}
