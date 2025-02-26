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
    /// Логика взаимодействия для DobavSotrudWindow.xaml
    /// </summary>
    public partial class DobavSotrudWindow : Window
    {
        public DobavSotrudWindow()
        {
            InitializeComponent();

           
        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string imyaSotrudnika = TextBoxName.Text;
        }

        private void TextBoxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            string login = TextBoxLogin.Text;
        }

        private void TextBoxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            string parol = TextBoxPassword.Text;
        }

        private void TextBoxRole_TextChanged(object sender, TextChangedEventArgs e)
        {
            string role = TextBoxRole.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получаем данные из текстовых полей
            string imyaSotrudnika = TextBoxName.Text;
            string login = TextBoxLogin.Text;
            string parol = TextBoxPassword.Text;
            string role = TextBoxRole.Text;

            // Преобразование роли в int
            int roleValue;
            switch (role.ToLower())
            {
                case "администратор":
                    roleValue = 1;
                    break;
                case "сотрудник":
                    roleValue = 2;
                    break;
                default:
                    MessageBox.Show("Пожалуйста, введите корректную роль (администратор или сотрудник).");
                    return;
            }
            try
            {
                using (restaurantdbEntities db = new restaurantdbEntities())
                {
                    // Проверяем, существует ли уже пользователь с таким логином
                    if (db.sotrudniki.Any(u => u.login == login))
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.");
                        return;
                    }

                    // Создаем нового пользователя
                    var newUser = new sotrudniki
                    {
                        imya_sotrudnika = imyaSotrudnika,
                        login = login,
                        parol = parol,
                        role_polzovatel = roleValue // Используем целочисленное значение роли
                    };

                    db.sotrudniki.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("Сотрудник успешно добавлен.");
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

