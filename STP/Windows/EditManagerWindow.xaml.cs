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
    public partial class EditManagerWindow : Window
    {
        public EditManagerWindow()
        {
            InitializeComponent();
            var manager = DB.Manager.Where(i => i.idManager == idManager).FirstOrDefault();
            tb_nameManager.Text = manager.nameManager;
        }

        private void btn_EditManager_Click(object sender, RoutedEventArgs e)
        {
            var Mng = DB.Manager.Where(i => i.idManager == idManager).FirstOrDefault();
            Mng.nameManager = tb_nameManager.Text;
            DB.SaveChanges();
            this.Close();
        }
    }
}
