using STP.Windows;
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
using static STP.AppData.DataFrame;

namespace STP.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            lv_ProductList.ItemsSource = DB.Product.ToList();

            List<Client> client = DB.Client.ToList();
            client.Insert(0, new Client() { nameClient = "Имя клиента" });
            cb_Client.ItemsSource = client;
            cb_Client.DisplayMemberPath = "nameClient";
            cb_Client.SelectedIndex = 0;
        }

        private void cb_Client_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void btn_addProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow();
            addProductWindow.ShowDialog();
            lv_ProductList.ItemsSource = DB.Product.ToList();
        }

        private void btn_editProduct_Click(object sender, RoutedEventArgs e)
        {
            if (lv_ProductList.SelectedItem is Product product)
            {
                idProduct = product.idProduct;
                EditProductWindow editProductWindow = new EditProductWindow();
                editProductWindow.ShowDialog();
                lv_ProductList.ItemsSource = DB.Product.ToList();
                Filter();
            }
            else
            {
                MessageBox.Show("Выберите товар из списка!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_deleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (lv_ProductList.SelectedItem is Product product)
            {
                var result = MessageBox.Show("Вы действительно хотите удалить товар из базы?", "Удаление товара", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    DB.Product.Remove(DB.Product.Where(i => i.idProduct == product.idProduct).FirstOrDefault());
                    DB.SaveChanges();
                    lv_ProductList.ItemsSource = DB.Product.ToList();
                    Filter();
                }
            }
            else
            {
                MessageBox.Show("Выберите товара из списка!", "Удаление товара", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void Filter()
        {
            var list = DB.Product.ToList();
            lv_ProductList.ItemsSource = list;

            if (cb_Client.SelectedIndex <= 0)
            {
                lv_ProductList.ItemsSource = list;
            }
            else
            {
                var client = cb_Client.SelectedItem as Client;
                var ClientList = DB.ClientProduct.Where(i => i.idClient == client.idClient).ToList();
                list = list.Where(i => ClientList.Find(j => j.idProduct == i.idProduct) != null).ToList();
                lv_ProductList.ItemsSource = list;
            }
        }
    }
}
