using System;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using UserNamespace;
namespace App;
class Program {
        
    public static void Main() {
        Console.WriteLine("Введите имя: ");
        string? get_name = Console.ReadLine();
        Console.WriteLine("Введите логин: ");
        string? get_login = Console.ReadLine(); 
        
        int get_age;
        do {
            Console.WriteLine("Введите возраст: ");
            if(int.TryParse(Console.ReadLine(), out get_age) && get_age >= 10 && get_age <= 100) {
                break;
            }
            else {
                Console.WriteLine("Введено неверное значение возраста. Введите значение от 10 до 100");
            }
        } while (true); 
        
        
        Console.WriteLine("Введите хобби: ");
        string? get_hobby = Console.ReadLine();

        User user = new User(get_name, get_login, get_age, get_hobby);                      //Создаем объект
              
        XmlSerializer xml = new XmlSerializer(typeof(User));
        using(FileStream file = new FileStream("Users.xml", FileMode.OpenOrCreate)) {       // Создаем файл
            xml.Serialize(file, user);                                                      // Помещаем в файл объекты 
        }

        using(FileStream file = new FileStream("Users.xml", FileMode.OpenOrCreate)) {
            User user2 = xml.Deserialize(file) as User ?? new User();
            Console.WriteLine("Десериализация прошла успешно!");
            user2.SetData();
        }
    }
}