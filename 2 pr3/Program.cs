// Работа с файлами: создание и заполнение, выбор по названию.
// Working with files: creation and filling, selection by name.

using System;                   
namespace project;              
using System.Linq;
using System.IO;

public class Program {
    
    public static void Main() {                                 
        Dictionary<string, string> files = new Dictionary<string, string>();    // Создаем словарь
                
        for (int i = 0; i < 3; i++) {
            Console.WriteLine($"Введите название {i+1} файла: ");               // i+1 т.к. индексы с нуля, а нам нужен отсчет с 1
            string name_file = Console.ReadLine() ?? "";                        // + проверка на значение 0
            Console.WriteLine($"Введите содержимое {i+1} файла: ");
            string content_fail = Console.ReadLine() ?? "";
            
            try {                                                               // Проверка на повторение ключей
                files.Add(name_file, content_fail);
                
            }
            catch (System.ArgumentException) {
                i--;                                                            // Возврат к предыд. индексу, чтобы не было пропуска цикла
                Console.WriteLine("такой ключ уже есть, введите заново");
            }
        }
        
        var result = files.Where(i => i.Key.StartsWith("q"));                   // Выборка по названию файлов

        foreach (var el in result){
            string fileName = el.Key;
            string content = el.Value;

            using (FileStream file = new FileStream($"{fileName}.txt", FileMode.OpenOrCreate)) {
                byte[] array = System.Text.Encoding.Default.GetBytes(content);  // Преобразование строк в биты
                file.Write(array);
            }
        }
    }
} 
