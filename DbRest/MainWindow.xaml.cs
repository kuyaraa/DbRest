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
using DbRest.Suschnosti;


namespace DbRest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            restaurantdbEntities newTestDb = new restaurantdbEntities();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string login = Login.Text;
            string passowrd = Password.Password;



            if (login == "admin" && passowrd == "123")
            {
                MessageBox.Show("Вы вошли как админ", "Успешный вход");

                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();


            }
            else if (login == "vikapika" && passowrd == "456")
            {
                MessageBox.Show("Вы вошли как сотрудник", "Успешный вход");

                SotrudnikiWindow sotrudnikiWindow = new SotrudnikiWindow();
                sotrudnikiWindow.Show();
            }
            else if (login == "gege" && passowrd == "789")
            {
                MessageBox.Show("Вы вошли как клиент", "Успешный вход");
                PolzovateliWindow polzovateliWindow = new PolzovateliWindow();
                polzovateliWindow.Show();

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка");

            }





        }
    }
}
