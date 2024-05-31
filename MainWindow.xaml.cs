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

namespace FocusStory
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Hall_Selected(object sender, RoutedEventArgs e)
        {
            Hall hall = new Hall();
            hall.Show();
            this.Close();
        }

        private void Storage_Selected(object sender, RoutedEventArgs e)
        {
            Storage storage = new Storage();
            storage.Show();
            this.Close();
        }

        private void Control_Selected(object sender, RoutedEventArgs e)
        {
            Control control = new Control();
            control.Show();
            this.Close();
        }

        private void Basket_Selected(object sender, RoutedEventArgs e)
        {
            BasketWindow basket = new BasketWindow();
            basket.Show();
            this.Close();
        }
    }
}
