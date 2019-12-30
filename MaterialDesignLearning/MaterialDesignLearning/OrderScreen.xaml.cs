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
using System.Windows.Shapes;

namespace MaterialDesignLearning
{
    /// <summary>
    /// Interaction logic for OrderScreen.xaml
    /// </summary>
    public partial class OrderScreen : Window
    {
        public OrderScreen()
        {
            InitializeComponent();
        }

        private void Click_Order(object sender, RoutedEventArgs e)
        {
            Window srcDialogOrder = new CustomDialog();
            srcDialogOrder.ShowDialog();
        }

        private void Click_seeMyStore(object sender, MouseButtonEventArgs e)
        {
            Window srcStore = new StoreScreen();
            srcStore.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window srcListOrder = new ScreenOrderList();
            srcListOrder.ShowDialog();
        }
    }
}
