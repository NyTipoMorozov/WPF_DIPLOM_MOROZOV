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
    /// Логика взаимодействия для PageGost1.xaml
    /// </summary>
    public partial class PageGost1 : Page
    {
        public PageGost1()
        {
            InitializeComponent();
            DtGridTovar.ItemsSource = diplomEntities.GetContext().Cars.ToList();
        }

        private void btnItem_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageMain.PageGost2());

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageMain.PageLogin());
        }
    }
}
