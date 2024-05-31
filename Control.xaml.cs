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
    /// <summary>
    /// Логика взаимодействия для Control.xaml
    /// </summary>
    public partial class Control : Window
    {
        public Control()
        {
            InitializeComponent();
            DGControl.ItemsSource = BaseModelFocusEntities5.GetContext().Item.ToList();
        }

        private void outmenu(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {
            AddItem addItem = new AddItem((sender as Button).DataContext as Item);
            addItem.Show();
            this.Close();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            AddItem addItem = new AddItem(null);
            addItem.Show();
            this.Close();
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            Item selectitem = (Item)DGControl.SelectedItem;

            if (selectitem == null)
            {
                MessageBox.Show("Выберите товар.");
            }
            else
            {
                List<Item> u = BaseModelFocusEntities5.GetContext().Item.Where(us => us.idItem == selectitem.idItem).ToList();
                BaseModelFocusEntities5.GetContext().Item.Remove(u[0]);
                BaseModelFocusEntities5.GetContext().SaveChanges();

                DGControl.ItemsSource = null;
                DGControl.ItemsSource = BaseModelFocusEntities5.GetContext().Item.ToList();
            }
        }
    }
}
