using System;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.ComponentModel;

namespace database;

class Program 
{
    public static void Main() 
    {
        
        using (AppContext context = new AppContext()) 
        {
            //AddUsers2person(app) - для добавления 2 пользователей
            
            //AddUsers(app); // - для добавления произвольного числа пользователей, получая данные через консоль

            EditUser(context, 1, 30);

            FindByUsername(context, "Bob");

            FindByAgeBetween(context, 10, 35);

            DeleteUsername(context, "Bob");
        }   
    }

            //  // Вариант 1 - создаем 2 новых пользователя с определенными данными
    // public void AddUsers2person(app)
    // User user1 = new User { username = "Alex", age = 41 };
    // User user2 = new User { username = "Bob", age = 33 }; 
    // context.users.AddRange(user1, user2);
    // context.SaveChanges();

        // Вариант 2 - создаем произвольное число пользователей, получая данные через консоль
    public static void AddUsers(AppContext context)
    {
        int i = 1;  // Вспомогательный счетчик введенных пользователей
        while(true)
        {
            Console.WriteLine("Введите имя пользователя " + i + ". (Для окончания ввода нажмите +)");
            string get = Console.ReadLine();
            if(get == "+")      // Для выхода из цикла
            {        
                break;
            }
            else 
            {
                User new_user = new User();
                new_user.username = get;
                Console.WriteLine("Введите возраст пользователя " + i);
                new_user.age = int.Parse(Console.ReadLine());
                context.users.Add(new_user);
                context.SaveChanges();
            }
            i++;
        }
    }

    public static void EditUser(AppContext context, int id_user, int age_user)
    {
        List<User> users = context.users.ToList();
        Console.WriteLine("Все пользователи:");
        foreach(User el in users)
            Console.WriteLine($"{el.id}. {el.username} - {el.age}");
    
        User user = context.users.Find(id_user); // Создали объект и поместили в него значения строки с id 2
        if(user != null) 
        {
            user.age = age_user;
            context.users.Update(user);
            context.SaveChanges();
        }
    }

    public static void FindByUsername(AppContext context, string name)        // Нахождение польз по полю Username. Найдите всех пользователей со значением Bob в этом поле
    {
        List<User> user_named = context.users.Where(el => el.username == name).ToList();
        Console.WriteLine("Пользователи с именем " + name + ":");
        foreach(User el in user_named)
            Console.WriteLine(el);
    } 

    public static void FindByAgeBetween(AppContext context, int min_age, int max_age)    // Нахождение записей в диап по возрасту в диапазоне от 10 (включительно) до 35 (не включительно)
    {
        List<User> user_age = context.users.Where(el => el.age >= min_age && el.age < max_age).ToList();
        Console.WriteLine("Пользователи с возрастом от " + min_age + " до " + max_age + ":");
        foreach(User el in user_age) 
            Console.WriteLine(el);
    }  

    public static void DeleteUsername(AppContext context, string name_del)       // Удаление польз по имени
    {
        User user_del = context.users.Where(el => el.username == name_del);
        if(user_del != null)
        {
            context.users.Remuve(user_del);
            context.SaveChanges();
            Console.WriteLine("Удален пользователь: " + user_del.username);
        }
    }   
}