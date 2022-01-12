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
using System.Windows.Navigation;
using BookLib;
using EmployeeLib;
using SalesLib;
using BookStoreGUI;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee currentEmployee;
        Sale currentSale;
        SupplyManager supplyManager;

        public MainWindow()
        {
            //supplyManager = new SupplyManager();
            InitializeComponent();   
        }

        private void searchBtnClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new SearchPage();
        }

        private void ManagerAreaClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new ManagerPage();
        }

        private void EmployeeSystemClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new EmployeeSystem();
        }
    }
}
