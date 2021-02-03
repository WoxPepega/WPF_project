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
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public AddProductWindow()
        {
            InitializeComponent();

            List<ProductType> productTypes = DB.ProductType.ToList();
            cb_typeProduct.ItemsSource = productTypes;
            cb_typeProduct.DisplayMemberPath = "nameType";
        }

        private void btn_AddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (idType == 1)
            {
                DB.Product.Add(new Product
                {
                    nameProduct = tb_nameProduct.Text,
                    priceProduct = decimal.Parse(tb_priceProduct.Text),
                    typeProduct = idType,
                    subTerm = int.Parse(tb_subTerm.Text)
                });
            }
            else
            {
                DB.Product.Add(new Product
                {
                    nameProduct = tb_nameProduct.Text,
                    priceProduct = decimal.Parse(tb_priceProduct.Text),
                    typeProduct = idType
                });
            }
            DB.SaveChanges();
            this.Close();

        }

        private void cb_typeProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var prodType = cb_typeProduct.SelectedItem as ProductType;
            idType = prodType.idProductType;
        }
    }
}
