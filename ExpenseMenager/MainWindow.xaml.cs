
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


using ExpenseMenager.SimpleClasses;

namespace ExpenseMenager
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitialMainView();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nowy \n i kuj!");
        }

        private void InitialMainView()
        {
            var mainList = new List<ExpenseEntity>();

            mainList.Add(new ExpenseEntity());
            mainList.Add(new ExpenseEntity("Dupa", 0.59));
            mainList.Add(new ExpenseEntity());

            dataSheet.ItemsSource = mainList;

            var monthList = new List<string>();

            monthList.Add("Styczen");
            monthList.Add("Luty");
            monthList.Add("Marzec");
            monthList.Add("Kwiecien");
            monthList.Add("Maj");

            monthSet.ItemsSource = monthList;

        }

        private void NewMonthButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New month!!! xD");
        }
    }
}
