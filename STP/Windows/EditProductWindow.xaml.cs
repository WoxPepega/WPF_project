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
    /// Логика взаимодействия для EditProductWindow.xaml
    /// </summary>
    public partial class EditProductWindow : Window
    {
        public EditProductWindow()
        {
            InitializeComponent();

            var product = DB.Product.Where(i => i.idProduct == idProduct).FirstOrDefault();
            tb_nameProduct.Text = product.nameProduct;
            tb_priceProduct.Text = product.priceProduct.ToString();
            tb_subTerm.Text = product.subTerm.ToString();

            List<ProductType> productTypes = DB.ProductType.ToList();
            cb_typeProduct.ItemsSource = productTypes;
            cb_typeProduct.DisplayMemberPath = "nameType";
        }

        private void cb_typeProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var prodType = cb_typeProduct.SelectedItem as ProductType;
            idType = prodType.idProductType;
        }

        private void btn_EditProduct_Click(object sender, RoutedEventArgs e)
        {
            var Prod = DB.Product.Where(i => i.idProduct == idProduct).FirstOrDefault();
            Prod.nameProduct = tb_nameProduct.Text;
            Prod.priceProduct = decimal.Parse(tb_priceProduct.Text);
            Prod.typeProduct = idType;
            Prod.subTerm = int.Parse(tb_subTerm.Text);
            DB.SaveChanges();
            this.Close();
        }
    }
}
