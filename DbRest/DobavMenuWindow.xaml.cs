using DbRest.Suschnosti;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для DobavMenuWindow.xaml
    /// </summary>
    public partial class DobavMenuWindow : Window
    {
        public DobavMenuWindow()
        {
            InitializeComponent();
        }

        private void TextBoxKategoriya_TextChanged(object sender, TextChangedEventArgs e)
        {
            string kategoriya = TextBoxKategoriya.Text;
        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nazvanieBluda = TextBoxName.Text;
        }

        private void TextBoxIngredient_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ingredient = TextBoxIngredient.Text;
        }

        private void TextBoxCena_TextChanged(object sender, TextChangedEventArgs e)
        {
            string cena = TextBoxCena.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string kategoriya = TextBoxKategoriya.Text.Trim();
            string nazvanieBluda = TextBoxName.Text.Trim();
            string ingredient = TextBoxIngredient.Text.Trim();
            string cenaString = TextBoxCena.Text.Trim();

            // Проверяем ввод цены
            if (string.IsNullOrWhiteSpace(cenaString))
            {
                MessageBox.Show("Введите корректное значение для цены.");
                return;
            }

            // Пробуем преобразовать цену в decimal
            if (!decimal.TryParse(cenaString, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal cena))
            {
                
                    MessageBox.Show("Введите корректное значение для цены. Используйте '.' для десятичного разделителя.");
                    return;
                
            }

            try
            {
                using (restaurantdbEntities db = new restaurantdbEntities())
                {
                    // Создаем новый объект блюда
                    var newDish = new menu
                    {
                        kategoriya = kategoriya,
                        nazvanie_bluda = nazvanieBluda,
                        ingredient = ingredient,
                        cena = (double)cena // Здесь мы используем decimal
                    };

                    // Добавляем новое блюдо в базу данных
                    db.menu.Add(newDish);
                    db.SaveChanges(); // Сохраняем изменения

                    MessageBox.Show("Блюдо успешно добавлено.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении блюда: {ex.Message}");
            }
        }
    }
}

