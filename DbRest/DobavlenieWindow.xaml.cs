using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DbRest.Suschnosti;

namespace DbRest
{
    public partial class DobavlenieWindow : Window
    {
        public DobavlenieWindow()
        {
            InitializeComponent();
            restaurantdbEntities newTestD = new restaurantdbEntities();

        }

        private void Button_Click(object sender, RoutedEventArgs e)// клиенты
        {
            DobavPolzWindow dobavPolzWindow = new DobavPolzWindow();
            dobavPolzWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)// сотрудники
        {
            DobavSotrudWindow dobavSotrudWindow = new DobavSotrudWindow();
            dobavSotrudWindow.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)// меню
        {
            DobavMenuWindow dobavMenuWindow = new DobavMenuWindow();
            dobavMenuWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)//запасы
        {
            DobavZapasWindow dobavZapasWindow = new DobavZapasWindow();
            dobavZapasWindow.Show();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)// поставщики
        {
            DobavPostavWindow dobavPostavWindow = new DobavPostavWindow();
            dobavPostavWindow.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)//закрыть
        {

            if (MessageBox.Show("Вы уверены, что хотите закрыть окно?", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
