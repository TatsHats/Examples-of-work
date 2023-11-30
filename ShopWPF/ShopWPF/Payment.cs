using System;
using CloudIpspSDK;
using CloudIpspSDK.Checkout;
using System.Windows;
using System.Diagnostics;
using System.IO;


namespace ShopWPF.Payments
{
    public class Payment
    {
        /// <summary>
        /// класс для получения url адреса и перенаправления на страницу оплаты
        /// </summary>
        /// <param name="_amount"></param>
        public Payment(int _amount)                     
        {
            Config.MerchantId = 1396424;
            Config.SecretKey = "test";

            var req = new CheckoutRequest
            {
                order_id = Guid.NewGuid().ToString("N"),
                amount = _amount,
                order_desc = "Оплата товаров",
                currency = "USD"
            };
            var resp = new Url().Post(req);
            if (resp.Error == null)
            {
                
                string url = resp.checkout_url;
                OpenUrlInBrowser(url);
                WriteToFile($"url: {url}");
            }
            else
            {
                MessageBox.Show($"Error: {resp.Error.ToString()}"); 
            }
        }

        public void OpenUrlInBrowser(string url)            // открывает страницу для оплаты
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии URL: {ex.Message}");
            }
        }

        public void WriteToFile(string textToWrite)         // сохранение лога в файл 
        {
            string filePath = "Log.txt";
            try
            {
                File.WriteAllText(filePath, textToWrite);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи в файл: {ex.Message}");
            }
        }
    }
}



