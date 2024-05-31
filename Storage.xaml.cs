using FocusStory.База_данных;
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

namespace FocusStory
{

    public partial class Storage : Window
    {
        public Storage()
        {
            InitializeComponent();
            DGStorage.ItemsSource = BaseModelFocusEntities5.GetContext().Item.Where(i => i.place == "Склад").ToList();
        }

        private void inbasket_Click(object sender, RoutedEventArgs e)
        {
            Item basketitem = (Item)DGStorage.SelectedItem;
            if (basketitem == null)
                MessageBox.Show("Выберите товар");
            else
            {
                Basket basket = new Basket();
                basket.idItem = basketitem.idItem;
                BaseModelFocusEntities5.GetContext().Basket.Add(basket);
                BaseModelFocusEntities5.GetContext().SaveChanges();
            }
        }

        private void outmenu(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
