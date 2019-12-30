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
    /// Interaction logic for SettingScreen.xaml
    /// </summary>
    public partial class SettingScreen : Window
    {
        public SettingScreen()
        {
            InitializeComponent();
        }

        private void addNewPizza(object sender, RoutedEventArgs e)
        {
            Window scrAddPizza = new ScreenAddPizza();
            scrAddPizza.ShowDialog();
        }

        private void editPizza(object sender, RoutedEventArgs e)
        {
            Window scrEditPizza = new ScreenEditPizza();
            scrEditPizza.ShowDialog();
        }

        private void createReport(object sender, RoutedEventArgs e)
        {
            Window scrGetReport = new ScreenReport();
            scrGetReport.ShowDialog();
        }
    }
}
