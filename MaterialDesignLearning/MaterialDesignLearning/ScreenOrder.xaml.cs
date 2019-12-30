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
    /// Interaction logic for ScreenOrder.xaml
    /// </summary>
    public partial class ScreenOrder : Window
    {
        public ScreenOrder()
        {
            InitializeComponent();
        }

        private void getOrder(object sender, RoutedEventArgs e)
        {
            Window scrOrderFormTable = new OrderScreen();
            scrOrderFormTable.ShowDialog();
        }
    }
}
