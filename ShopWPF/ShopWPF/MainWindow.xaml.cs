using ShopWPF.Models;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ShopWPF.Payments;

namespace ShopWPF
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Product> ShoppingCart { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>();             //создание коллекции для товаров из БД
            ShoppingCart = new ObservableCollection<Product>();         //создание коллекции для товаров, добавленных в корзину.
            ProductListView.ItemsSource = Products;                     //устанавливаем источник данных для ListBox - это коллекция Products
            LoadProducts();
        }

        private void LoadProducts()                                     // метод для добавления товаров из БД в коллекцию Products
        {
            using (var context = new AppDBContext())
            {
                var products = context.Shop.ToList();
                 
                foreach (var product in products)                       //перебираем данные из БД
                {
                    string imagePath = product.GetImage();
                    product.Image = imagePath;                          //при этом в поле картинки вставляем путь к файлу + имя из БД
                    //MessageBox.Show(imagePath); // для самопроверки
                    Products.Add(product);                              //и добавляем их в коллекцию Products
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)  // метод срабатывает при нажатии на кнопку "добавить в корзину"
        {
            Button button = (Button)sender;
            int id = Convert.ToInt32(button.Tag);
            var product = Products.FirstOrDefault(p => p.Id == id);     //ищем товар в коллекции
            if (product != null)
            {                                                       
                ShoppingCart.Add(product);                              // добавляем в корзину
                //MessageBox.Show("Товар добавлен в корзину"); // для самопроверки
            }
            UpdateShoppingCartInfo();                                   // метод для обновления корзины - покажет количество и общую стоимость выбранных товаров
        }

        private void UpdateShoppingCartInfo()                           // метод для обновления корзины
        {
            if (ShoppingCart.Count > 0)
            {
                string total_price = "Общая стоимость: ";               // переменная для вывода текста - добавляем к ней стоимость товаров, добавленных в корзину 
                Price.Text = total_price.ToString() + ShoppingCart.Sum(obj => obj.Price).ToString("C", CultureInfo.GetCultureInfo("en-US"));    //добавлена обработка валюты для отображения в $ независимо от настроек ОС и ПО
                Basket.Content = "В корзине есть товары";
                string total_quantity = "Количество товаров: ";         // переменная для вывода текста - добавляем к ней общее количество товаров, добавленных в корзину 
                Quantity.Text = total_quantity.ToString() + ShoppingCart.Count.ToString();
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)  // метод срабатывает при нажатии на кнопку "Оплатить"
        {
            if(ShoppingCart.Count > 0)                                  // если в корзине есть товары переходим на страницу оплаты
            {
                PaymentRequest();
            }
            else                                                        // если корзина пуста выводим сообщение об этом
            {
                MessageBox.Show("Ваша корзина пуста! Добавьте товары в корзину");
            }
        }

        public void PaymentRequest()                                    // метод перенаправляет на страницу оплаты
        {
            decimal price = ShoppingCart.Sum(obj => obj.Price);         // подсчет суммы
            int price_int = Convert.ToInt32(price);
            price_int *= 100;                                           // умножаем сумму на 100 для корректного отображения на странице оплаты (два разряда для центов)
            Payment inst = new Payment(price_int);
        }
    }
}


