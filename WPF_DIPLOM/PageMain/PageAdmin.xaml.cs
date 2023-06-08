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
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        public PageAdmin()
        {
            InitializeComponent();
            DtGridTovar.ItemsSource = diplomEntities.GetContext().Cars.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageCarsAdd(null));
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var tovarForRemoning = DtGridTovar.SelectedItems.Cast<Cars>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующее {tovarForRemoning.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    diplomEntities.GetContext().Cars.RemoveRange(tovarForRemoning);
                    diplomEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DtGridTovar.ItemsSource = diplomEntities.GetContext().Cars.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageCarsAdd((sender as Button).DataContext as Cars));
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                diplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DtGridTovar.ItemsSource = diplomEntities.GetContext().Cars.ToList();
            }

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageMain.PagesList());
        }
    }
    }

