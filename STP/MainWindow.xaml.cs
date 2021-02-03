using STP.Pages;
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

namespace STP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FRMain.Navigate(new StartPage());
        }

        private void btn_Manager_Click(object sender, RoutedEventArgs e)
        {
            FRMain.Navigate(new Uri("/Pages/ManagerPage.xaml", UriKind.Relative));
        }

        private void btn_Client_Click(object sender, RoutedEventArgs e)
        {
            FRMain.Navigate(new Uri("/Pages/ClientPage.xaml", UriKind.Relative));
        }

        private void btn_Product_Click(object sender, RoutedEventArgs e)
        {
            FRMain.Navigate(new Uri("/Pages/ProductPage.xaml", UriKind.Relative));
        }
    }
}
