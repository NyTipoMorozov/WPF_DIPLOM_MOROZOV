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
    /// Логика взаимодействия для PageGost2.xaml
    /// </summary>
    public partial class PageGost2 : Page
    {
        public PageGost2()
        {
            InitializeComponent();
            DtGridTovar.ItemsSource = diplomEntities.GetContext().Items.ToList();
        }

        private void btnCars_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageMain.PageGost1());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageMain.PageLogin());
        }
    }
}
