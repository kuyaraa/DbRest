using DbRest.Suschnosti;
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


namespace DbRest
{
    /// <summary>
    /// Логика взаимодействия для DobavPolzWindow.xaml
    /// </summary>
    public partial class DobavPolzWindow : Window
    {
        public DobavPolzWindow()
        {
            InitializeComponent();
            restaurantdbEntities newTestDb = new restaurantdbEntities();
        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string imyaPolzovatelya = TextBoxName.Text;
            
        }

        private void TextBoxTelefon_TextChanged(object sender, TextChangedEventArgs e)
        {
            string telefon = TextBoxTelefon.Text;
        }

        private void TextBoxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            string login = TextBoxLogin.Text;
            
        }

        private void TextBoxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            string parol = TextBoxPassword.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получаем данные из текстовых полей
            string imyaPolzovatelya = ((TextBox)FindName("TextBoxName")).Text;
            string telefon = ((TextBox)FindName("TextBoxTelefon")).Text;
            string login = ((TextBox)FindName("TextBoxLogin")).Text;
            string parol = ((TextBox)FindName("TextBoxPassword")).Text;

            try
            {
                using (restaurantdbEntities db = new restaurantdbEntities())
                {
                    // Проверяем, существует ли уже пользователь с таким логином
                    if (db.polzovateli.Any(u => u.login == login))
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.");
                        return;
                    }

                    // Создаем нового пользователя
                    var newUser = new polzovateli
                    {
                        imya_polzovatelya = imyaPolzovatelya,
                        telefon = telefon,
                        login = login,
                        parol = parol
                    };

                    db.polzovateli.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("Пользователь успешно добавлен.");
                    this.Close(); // Закрываем окно после добавления
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");

            }
        }
    }
}
