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
    /// Interaction logic for ScreenCenter.xaml
    /// </summary>
    public partial class ScreenCenter : Window
    {
        public ScreenCenter()
        {
            InitializeComponent();
        }

        private void Click_order(object sender, MouseButtonEventArgs e)
        {
            Window srcOrder = new ScreenOrder();
            srcOrder.ShowDialog();
        }

        private void Mouse_down_left_exit(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Click_transfer(object sender, MouseButtonEventArgs e)
        {
            Window srcTransfer = new TransferScreen();
            srcTransfer.ShowDialog();
        }

        private void Click_setting(object sender, MouseButtonEventArgs e)
        {
            Window srcSetting = new SettingScreen();
            srcSetting.ShowDialog();
        }

        private void toExitApplication(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
