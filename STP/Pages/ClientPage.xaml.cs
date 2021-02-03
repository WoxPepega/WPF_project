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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            lv_ClientList.ItemsSource = DB.Client.ToList();

            List<Manager> manager = DB.Manager.ToList();
            manager.Insert(0, new Manager() { nameManager = "Имя клиента" });
            cb_Manager.ItemsSource = manager;
            cb_Manager.DisplayMemberPath = "nameManager";
            cb_Manager.SelectedIndex = 0;

            List<ClientStatus> clStatus = DB.ClientStatus.ToList();
            clStatus.Insert(0, new ClientStatus() { nameStatus = "Статус" });
            cb_Status.ItemsSource = clStatus;
            cb_Status.DisplayMemberPath = "nameStatus";
            cb_Status.SelectedIndex = 0;
        }

        private void cb_Manager_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void cb_Status_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void btn_addClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow();
            addClientWindow.ShowDialog();
            lv_ClientList.ItemsSource = DB.Client.ToList();
        }

        private void btn_editClient_Click(object sender, RoutedEventArgs e)
        {
            EditClientWindow editClientWindow = new EditClientWindow();
            editClientWindow.ShowDialog();
            lv_ClientList.ItemsSource = DB.Client.ToList();
            Filter();
        }

        private void btn_deleteClient_Click(object sender, RoutedEventArgs e)
        {
            if (lv_ClientList.SelectedItem is Client client)
            {
                var result = MessageBox.Show("Вы действительно хотите удалить клиента из базы?", "Удаление клиента", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    DB.Client.Remove(DB.Client.Where(i => i.idClient == client.idClient).FirstOrDefault());
                    DB.SaveChanges();
                    lv_ClientList.ItemsSource = DB.Client.ToList();
                    Filter();
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента из списка!", "Удаление клиента", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void Filter()
        {
            var list = DB.Client.ToList();
            lv_ClientList.ItemsSource = list;

            if (cb_Manager.SelectedIndex <= 0)
            {
                lv_ClientList.ItemsSource = list;
            }
            else
            {
                var Mng = cb_Manager.SelectedItem as Manager;
                list = list.Where(i => i.idManager == Mng.idManager).ToList();
                lv_ClientList.ItemsSource = list;
            }

            if (cb_Status.SelectedIndex <= 0)
            {
                lv_ClientList.ItemsSource = list;
            }
            else
            {
                var Sts = cb_Status.SelectedItem as ClientStatus;
                list = list.Where(i => i.idStatus == Sts.idStatus).ToList();
                lv_ClientList.ItemsSource = list;
            }
        }
    }
}
