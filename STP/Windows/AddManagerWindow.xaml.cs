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
    /// Логика взаимодействия для AddManagerWindow.xaml
    /// </summary>
    public partial class AddManagerWindow : Window
    {
        public AddManagerWindow()
        {
            InitializeComponent();
        }

        private void btn_addManager_Click(object sender, RoutedEventArgs e)
        {
            DB.Manager.Add(new Manager
            {
                nameManager = tb_nameManager.Text
            });
            DB.SaveChanges();
            this.Close();
        }
    }
}
