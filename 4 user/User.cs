using System;
using System.IO;
using System.Collections;
namespace UserNamespace;
[Serializable]

public class User {
    public string? name, login;
    public int age;                
    public string? hobby;

    public User() {}                                                        // Конструктор по умолчанию - для сериализации

    public User(string? name, string? login, int age, string? hobby) {      //Конструктор для создания объекта
        this.name = name;
        this.login = login;
        this.age = age;
        this.hobby = hobby;
    }

    public void SetData () {
        string[] array_hobby = hobby.Split(',');                            // Создание массива (для вывода элем по одному)
        Console.WriteLine($"Пользователь: {name} с логином {login}. Его возраст: {age} лет. Хобби:");
        foreach (string el in array_hobby) {
            Console.WriteLine(el);
        }
    }
}