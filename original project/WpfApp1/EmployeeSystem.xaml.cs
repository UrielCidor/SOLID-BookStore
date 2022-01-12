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
using EmployeeLib;
namespace BookStoreGUI
{
    /// <summary>
    /// Interaction logic for EmployeeSystem.xaml
    /// </summary>
    public partial class EmployeeSystem : Page
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public EmployeeSystem()
        {
            InitializeComponent();
            //employeeManager.AddEmployee(new Manager("Dany", "1212 rd", DateTime.Now));
            EmployeeListView.ItemsSource = employeeManager.GetEmployeeList();

        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if(managerCheck.IsChecked == true)
            {
                employeeManager.AddEmployee(new Manager(eName.Text, eAddress.Text, (DateTime)eDate.SelectedDate));
            }
            if(salesCheck.IsChecked == true)
            {
                employeeManager.AddEmployee(new SalesPerson(eName.Text, eAddress.Text, (DateTime)eDate.SelectedDate));

            }
            employeeManager.InitEmployeeList();
            EmployeeListView.ItemsSource = employeeManager.GetEmployeeList();
        }
    }
}
