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
    /// Логика взаимодействия для DobavZapasWindow.xaml
    /// </summary>
    public partial class DobavZapasWindow : Window
    {
        public DobavZapasWindow()
        {
            InitializeComponent();
        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nazvanieProdukta = TextBoxName.Text;
        }

        private void TextBoxKolichestvo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string kolichestvo = TextBoxKolichestvo.Text;
        }

        private void TextBoxMinOst_TextChanged(object sender, TextChangedEventArgs e)
        {
            string minimal_ostatok = TextBoxMinOst.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nazvanieProdukta = TextBoxName.Text;
            string kolichestvoString = TextBoxKolichestvo.Text;
            string minimal_ostatokString = TextBoxMinOst.Text;

            {
                

                // Проверяем ввод цены
                if (string.IsNullOrWhiteSpace(minimal_ostatokString))
                {
                    MessageBox.Show("Введите корректное значение для цены.");
                    return;
                }

                // Пробуем преобразовать цену в decimal
                if (!decimal.TryParse(minimal_ostatokString, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal minimal_ostatok))
                {
                    MessageBox.Show("Введите корректное значение для цены. Используйте '.'  для десятичного разделителя.");
                    return;
                }

                if (!decimal.TryParse(kolichestvoString, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal kolichestvo))
                {
                    MessageBox.Show("Введите корректное значение для цены. Используйте '.' для десятичного разделителя.");
                    return;
                }

                try
                {
                    using (restaurantdbEntities db = new restaurantdbEntities())
                    {
                        // Создаем новый объект блюда
                        var newStock = new zapas
                        {
                            imya_produkta = nazvanieProdukta,
                            kolichestvo = (double)kolichestvo,
                            minimal_ostatok = (double)minimal_ostatok,
                            
                        };

                        // Добавляем новое блюдо в базу данных
                        db.zapas.Add(newStock);
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
    
}
