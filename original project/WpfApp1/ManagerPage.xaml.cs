using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookLib;
using EmployeeLib;
using SalesLib;

namespace BookStoreGUI
{
    [Serializable]

    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {

        //EmployeeManager employeeManager = new EmployeeManager();
        SalesManager salesManager = new SalesManager();
        //SupplyManager supplyManager = new SupplyManager();

        bool _isBook;
        public ManagerPage()
        {
            InitializeComponent();
            

            titleTxtBox.IsEnabled = false;
            authorTxtBox.IsEnabled = false;
            PublisherTxtBox.IsEnabled = false;
            ISBNTxtBox.IsEnabled = false;
            editionTxtBox.IsEnabled = false;
            PublishDateTxtBox.IsEnabled = false;
            GanereListBox.IsEnabled = false;
            
            //employeeManager.AddEmployee(new Manager("admin", "admin111", DateTime.Now));
            //employeeManager.AddEmployee(new Manager("admin2", "admin222", DateTime.Now));
            //employeeManager.AddEmployee(new SalesPerson("Dany", "somewhere12", DateTime.Now));

            //GanereListBox.ItemsSource = Enum.GetValues(typeof(Ganres));
            


            List<Employee> managerList = new List<Employee>();
            //foreach (var item in employeeManager.EmployeeList)
            //{
            //    if(item.GetType() == typeof(Manager))
            //    {
            //        managerList.Add(item);
            //    }
            //}
            managerListBox.DataContext = managerList;
        }

        private void ShowAllSales_Click(object sender, RoutedEventArgs e)
        {
            salesManager.GetSalesList();
        }

        private void addToSupplyBtn_Click(object sender, RoutedEventArgs e)
        {
            if(_isBook == true)
            {
                int _date = int.Parse(PublishDateTxtBox.Text);
                int _year = _date % 10000;
                _date /= 10000;
                int _month = _date % 100;
                _date /= 100;
                int _day = _date;
                int _ganreSelectionIndx = GanereListBox.SelectedIndex;


                //Book newBook = new Book(double.Parse(priceTxtBox.Text), int.Parse(quantityTxtBox.Text), titleTxtBox.Text, authorTxtBox.Text, PublisherTxtBox.Text, int.Parse(ISBNTxtBox.Text), int.Parse(editionTxtBox.Text), new DateTime(_year, _month, _day), Ganres.Advanture);
                //supplyManager.AddToSupply(newBook);
            }
            
        }

        private void bookPick_Click(object sender, RoutedEventArgs e)
        {
            
            bookPick.Background = Brushes.RosyBrown;

            titleTxtBox.IsEnabled = true;
            authorTxtBox.IsEnabled = true;
            PublisherTxtBox.IsEnabled = true;
            ISBNTxtBox.IsEnabled = true;
            editionTxtBox.IsEnabled = true;
            PublishDateTxtBox.IsEnabled = true;
            GanereListBox.IsEnabled = true;

            _isBook = true;

        }
    }
}
