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
    /// Логика взаимодействия для IsmenitWindow.xaml
    /// </summary>
    public partial class IsmenitWindow : Window
    {
        public IsmenitWindow()
        {
            InitializeComponent();
        }


        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxPhone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private polzovateli _user;

        public IsmenitWindow(polzovateli user)
        {
            InitializeComponent();
            _user = user;

            TextBoxName.Text = _user.imya_polzovatelya;
            TextBoxPhone.Text = _user.telefon;
            TextBoxLogin.Text = _user.login;
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("Ошибка: пользователь не инициализирован.");
                return;
            }

            try
                {
                    using (restaurantdbEntities db = new restaurantdbEntities())
                    {
                        // Обновляем данные пользователя
                        var userToUpdate = db.polzovateli.FirstOrDefault(u => u.login == _user.login);
                        if (userToUpdate != null)
                        {
                            userToUpdate.imya_polzovatelya = TextBoxName.Text;
                            userToUpdate.telefon = TextBoxPhone.Text;
                            userToUpdate.login = TextBoxLogin.Text;

                            db.SaveChanges();
                            MessageBox.Show("Данные пользователя успешно обновлены.");
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не найден.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }

                this.Close();
            
        }
    }
}

