
using Microsoft.EntityFrameworkCore;

namespace ShopWPF.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public Product()                                                                        //пустой конструктор для корректной работы
        {
        }

        public Product(int id, string name, string description, decimal price, string image)    //конструктор для создания объекта "товар" по данным БД
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Image = image;
        }
       
        public string GetImage()                                                                // Метод возвращает путь к фото и название самого фото одной строкой
        {  
            return "/Img/" + Image; 
        }
    }
}
