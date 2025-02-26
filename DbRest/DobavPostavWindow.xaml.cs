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
    /// Логика взаимодействия для DobavPostavWindow.xaml
    /// </summary>
    public partial class DobavPostavWindow : Window
    {
        public DobavPostavWindow()
        {
            InitializeComponent();
        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string imyaPostavchika = TextBoxName.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imyaPostavchika = TextBoxName.Text;

            // Проверяем, введено ли имя поставщика
            if (string.IsNullOrWhiteSpace(imyaPostavchika))
            {
                MessageBox.Show("Введите корректное имя поставщика.");
                return;
            }

            try
            {
                using (restaurantdbEntities db = new restaurantdbEntities())
                {
                    // Создаем нового поставщика
                    var newPostavchik = new postavchik
                    {
                        nazvanie_postavchika = imyaPostavchika
                    };

                    // Добавляем нового поставщика в базу данных
                    db.postavchik.Add(newPostavchik);
                    db.SaveChanges(); // Сохраняем изменения

                    MessageBox.Show("Поставщик успешно добавлен.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении поставщика: {ex.Message}");
            }
        }
    }
    
}
