using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AzureSqlUtil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public DbServers dbservers = new DbServers();
        public ObservableCollection<AzureDatabaseServer> dbserverlist
        {
            get { return dbservers.DbServersList; }
        }

        ObservableCollection<string> list1 = new ObservableCollection<string>() { "one", "two", "three" };
        public ObservableCollection<string> databaselist => list1;

        



        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
