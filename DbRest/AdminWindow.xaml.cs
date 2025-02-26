using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DbRest.Suschnosti;

namespace DbRest
{
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // меню
        {
            using (restaurantdbEntities db = new restaurantdbEntities())
            {
                UserDataGrid.ItemsSource = db.menu.ToList();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // запасы
        {
            using (restaurantdbEntities db = new restaurantdbEntities())
            {
                UserDataGrid.ItemsSource = db.zapas.ToList();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // закрыть окно
        {
            if (MessageBox.Show("Вы уверены, что хотите закрыть окно?", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) // сотрудники
        {
            using (restaurantdbEntities db = new restaurantdbEntities())
            {
                UserDataGrid.ItemsSource = db.sotrudniki.ToList();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) // поставщик
        {
            using (restaurantdbEntities db = new restaurantdbEntities())
            {
                UserDataGrid.ItemsSource = db.postavchik.ToList();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) // клиенты
        {
            using (restaurantdbEntities db = new restaurantdbEntities())
            {
                UserDataGrid.ItemsSource = db.polzovateli.ToList();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) // добавление 
        {
            DobavlenieWindow dobavlenieWindow = new DobavlenieWindow();
            dobavlenieWindow.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) // удаление 
        {
            if (UserDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            try
            {
                using (restaurantdbEntities db = new restaurantdbEntities())
                {
                    object selectedItem = UserDataGrid.SelectedItem;

                    if (selectedItem is polzovateli user)
                    {
                        var entity = db.polzovateli.FirstOrDefault(u => u.polzovatel_id == user.polzovatel_id);
                        if (entity != null) db.polzovateli.Remove(entity);
                    }
                    else if (selectedItem is sotrudniki sotrudnik)
                    {
                        var entity = db.sotrudniki.FirstOrDefault(s => s.sotrudnik_id == sotrudnik.sotrudnik_id);
                        if (entity != null) db.sotrudniki.Remove(entity);
                    }
                    else if (selectedItem is menu dish)
                    {
                        var entity = db.menu.FirstOrDefault(m => m.menu_id == dish.menu_id);
                        if (entity != null) db.menu.Remove(entity);
                    }
                    else if (selectedItem is zapas stock)
                    {
                        var entity = db.zapas.FirstOrDefault(z => z.produkt_id == stock.produkt_id);
                        if (entity != null) db.zapas.Remove(entity);
                    }
                    else if (selectedItem is postavchik supplier)
                    {
                        var entity = db.postavchik.FirstOrDefault(p => p. postavchik_id == supplier.postavchik_id);
                        if (entity != null) db.postavchik.Remove(entity);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось определить таблицу.");
                        return;
                    }

                    db.SaveChanges();
                    MessageBox.Show("Запись успешно удалена.");

                    // Обновляем DataGrid
                    UserDataGrid.ItemsSource = db.polzovateli.ToList();
                    UserDataGrid.ItemsSource = db.sotrudniki.ToList();
                    UserDataGrid.ItemsSource = db.menu.ToList();
                    UserDataGrid.ItemsSource = db.zapas.ToList();
                    UserDataGrid.ItemsSource = db.postavchik.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        

        private void Button_Click_8(object sender, RoutedEventArgs e) // обновление данных
        {
            using (restaurantdbEntities db = new restaurantdbEntities())
            {
                UserDataGrid.ItemsSource = db.polzovateli.ToList();
                UserDataGrid.ItemsSource = db.sotrudniki.ToList();
                UserDataGrid.ItemsSource = db.menu.ToList();
                UserDataGrid.ItemsSource = db.zapas.ToList();
                UserDataGrid.ItemsSource = db.postavchik.ToList();
            }
        }

        private void UserDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e) // сохранение изменений
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                using (restaurantdbEntities db = new restaurantdbEntities())
                {
                    object editedItem = e.Row.Item;

                    if (editedItem is polzovateli user)
                    {
                        var entity = db.polzovateli.FirstOrDefault(u => u.polzovatel_id == user.polzovatel_id);
                        if (entity != null)
                        {
                            entity.imya_polzovatelya = user.imya_polzovatelya;
                            entity.telefon = user.telefon;
                            entity.login = user.login;
                            entity.parol = user.parol;
                        }
                    }
                    else if (editedItem is sotrudniki employee)
                    {
                        var entity = db.sotrudniki.FirstOrDefault(s => s.sotrudnik_id == employee.sotrudnik_id);
                        if (entity != null)
                        {
                            entity.imya_sotrudnika = employee.imya_sotrudnika;
                            entity.login = employee.login;
                            entity.parol = employee.parol;
                            entity.role_polzovatel = employee.role_polzovatel;
                        }
                    }
                    else if (editedItem is menu dish)
                    {
                        var entity = db.menu.FirstOrDefault(m => m.menu_id == dish.menu_id);
                        if (entity != null)
                        {
                            entity.kategoriya = dish.kategoriya;
                            entity.nazvanie_bluda = dish.nazvanie_bluda;
                            entity.ingredient = dish.ingredient;
                            entity.cena = dish.cena;
                        }
                    }
                    else if (editedItem is zapas stock)
                    {
                        var entity = db.zapas.FirstOrDefault(z => z.produkt_id == stock.produkt_id);
                        if (entity != null)
                        {
                            entity.imya_produkta = stock.imya_produkta;
                            entity.kolichestvo = stock.kolichestvo;
                        }
                    }
                    else if (editedItem is postavchik supplier)
                    {
                        var entity = db.postavchik.FirstOrDefault(p => p.postavchik_id == supplier.postavchik_id);
                        if (entity != null)
                        {
                            entity.nazvanie_postavchika = supplier.nazvanie_postavchika;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удалось определить таблицу.");
                        return;
                    }

                    db.SaveChanges();
                    MessageBox.Show("Изменения успешно сохранены.");
                }
            }
        }

        private void UserDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
