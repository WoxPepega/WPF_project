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
    /// Логика взаимодействия для SelectProductWindow.xaml
    /// </summary>
    public partial class SelectProductWindow : Window
    {
        public SelectProductWindow()
        {
            InitializeComponent();
            lv_ProductList.ItemsSource = DB.Product.ToList();
        }

        private void btn_select_Click(object sender, RoutedEventArgs e)
        {
            if (lv_ProductList.SelectedItem is Product product)
            {
                idProduct = product.idProduct;
                this.Close();
            }
            else
            {
                MessageBox.Show("Сначала выберите товар из списка!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
