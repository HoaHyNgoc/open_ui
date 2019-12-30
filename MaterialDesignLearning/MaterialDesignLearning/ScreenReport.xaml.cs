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
    /// Interaction logic for ScreenReport.xaml
    /// </summary>
    public partial class ScreenReport : Window
    {
        public ScreenReport()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "Pizza A", IdBill = "B001", Date = "12-12-2019", Price = 250});
            items.Add(new User() { Name = "Pizza B", IdBill = "B002", Date = "12-11-2019", Price = 150 });
            items.Add(new User() { Name = "Pizza C", IdBill = "B003", Date = "12-10-2019", Price = 200 });
            lvUsers.ItemsSource = items;
        }

        public class User
        {
            public string Name { get; set; }

            public string IdBill { get; set; }

            public string Date { get; set; }

            public decimal Price { get; set; }
        }

    }
}
