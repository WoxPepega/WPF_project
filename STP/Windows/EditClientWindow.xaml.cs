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
using static STP.AppData.DataFrame;

namespace STP.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditClientWindow.xaml
    /// </summary>
    public partial class EditClientWindow : Window
    {
        public EditClientWindow()
        {
            InitializeComponent();

            idProduct = -1;

            var client = DB.Client.Where(i => i.idClient == idClient).FirstOrDefault();
            tb_nameClient.Text = client.nameClient;

            List<ClientStatus> clStatus = DB.ClientStatus.ToList();
            cb_Status.ItemsSource = clStatus;
            cb_Status.DisplayMemberPath = "nameStatus";

            List<Manager> manager = DB.Manager.ToList();
            cb_Manager.ItemsSource = manager;
            cb_Manager.DisplayMemberPath = "nameManager";

            var clientProd = DB.ClientProduct.Where(i => i.idClient == idClient).ToList();
            lv_ClientProducts.ItemsSource = clientProd;
        }

        private void cb_Status_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var clStatus = cb_Status.SelectedItem as ClientStatus;
            idStatus = clStatus.idStatus;
        }

        private void cb_Manager_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var mngr = cb_Manager.SelectedItem as Manager;
            idManager = mngr.idManager;
        }

        private void btn_AddClient_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_addProduct_Click(object sender, RoutedEventArgs e)
        {
            if (tb_nameClient.Text.Length > 0 && cb_Manager.SelectedIndex > -1 && cb_Status.SelectedIndex > -1)
            {
                SelectProductWindow selectProductWindow = new SelectProductWindow();
                selectProductWindow.ShowDialog();
                if (idProduct != -1)
                {
                    DB.ClientProduct.Add(new ClientProduct
                    {
                        idClient = idClient,
                        idProduct = idProduct
                    });
                    DB.SaveChanges();
                    var clProd = DB.ClientProduct.Where(i => i.idClient == idClient).ToList();
                    lv_ClientProducts.ItemsSource = clProd;
                }
            }
            else
            {
                MessageBox.Show("Сначала введите имя клиента, выберите менеджера и установите статус!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_delProduct_Click(object sender, RoutedEventArgs e)
        {
            if (lv_ClientProducts.SelectedItem is ClientProduct clientProduct)
            {
                idProduct = clientProduct.idProduct;
                DB.ClientProduct.Remove(DB.ClientProduct.Where(i => i.idProduct == idProduct && i.idClient == idClient).FirstOrDefault());
                DB.SaveChanges();
                var client = DB.Client.Where(i => i.idClient == idClient).FirstOrDefault();
                var prod = client.ClientProduct.ToList();
                lv_ClientProducts.ItemsSource = prod;
            }
            else
            {
                MessageBox.Show("Сначала выберите товар из списка!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
