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
    /// Логика взаимодействия для ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        public ManagerPage()
        {
            InitializeComponent();
            lv_ManagerList.ItemsSource = DB.Manager.ToList();
        }

        private void btn_addManager_Click(object sender, RoutedEventArgs e)
        {
            AddManagerWindow addManagerWindow = new AddManagerWindow();
            addManagerWindow.ShowDialog();
            lv_ManagerList.ItemsSource = DB.Manager.ToList();
        }

        private void btn_editManager_Click(object sender, RoutedEventArgs e)
        {
            if (lv_ManagerList.SelectedItem is Manager manager)
            {
                idManager = manager.idManager;
                EditManagerWindow editManagerWindow = new EditManagerWindow();
                editManagerWindow.ShowDialog();
                lv_ManagerList.ItemsSource = DB.Manager.ToList();
            }
            else
            {
                MessageBox.Show("Выберите менеджера из списка!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_deleteManager_Click(object sender, RoutedEventArgs e)
        {
            if (lv_ManagerList.SelectedItem is Manager manager)
            {
                var result = MessageBox.Show("Вы действительно хотите удалить менеджера из базы?", "Удаление менеджера", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    DB.Manager.Remove(DB.Manager.Where(i => i.idManager == manager.idManager).FirstOrDefault());
                    DB.SaveChanges();
                    lv_ManagerList.ItemsSource = DB.Manager.ToList();
                }
            }
            else
            {
                MessageBox.Show("Выберите менеджера из списка!", "Удаление менеджера", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
