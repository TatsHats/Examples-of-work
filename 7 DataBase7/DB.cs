using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;

namespace database;

class DB {
    private const string HOST = "localhost";
    private const string PORT = "3306"; 
    private const string DATABASE = "progr";
    private const string USER = "root"; 
    private const string PASS = "root"; 
    private string connect;

    public DB() {
        connect = $"Server={HOST};User={USER};Password={PASS};Database={DATABASE};Port={PORT};";
    }

    public async Task SetOrders() {    
        
        uint  user_id = 0;
        using (MySqlConnection conn = new MySqlConnection(connect)) {
            await conn.OpenAsync();
            MySqlCommand command = new MySqlCommand("SELECT id, login FROM users WHERE login = 'john'", conn);                               
            MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync();
            if(reader.HasRows) {
                while(await reader.ReadAsync()) {
                    object id = reader["id"];
                    object login = reader["login"];
                    user_id = (uint)id;
                    Console.WriteLine($"{id} - {login}");
                }
            } 
            await reader.CloseAsync();                                
        }
     
        using (MySqlConnection conn = new MySqlConnection(connect)) {
            await conn.OpenAsync();
            MySqlCommand command = new MySqlCommand("SELECT id, category FROM items WHERE category = 'hats'", conn); 
            MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync();
            if(reader.HasRows) {
                while(await reader.ReadAsync()) {
                    object id_it = reader["id"];
                    object category = reader["category"];
                    Console.WriteLine($"{id_it} - {category}");
                    await InsertData(user_id, (uint)id_it);
                }                            
            }                               
            await reader.CloseAsync();
        }  
    }

    public async Task InsertData(uint id, uint id_it) {
        string sql = "INSERT INTO orders (user_id, item_id) VALUES (@user_id, @item_id)";
        Dictionary<string, uint> parametrs = new Dictionary<string, uint>();
        parametrs.Add("user_id", id);
        parametrs.Add("item_id", id_it);
        await ExecuteQuery(sql, parametrs);
    }                           
    
    private async Task ExecuteQuery(string sql, Dictionary<string, uint> parameters) {
        using (MySqlConnection conn = new MySqlConnection(connect)) {       //Открывает соединение
            await conn.OpenAsync();                                         // Подкл. к БД
            MySqlCommand command = new MySqlCommand(sql, conn);
            if (parameters != null) {
                foreach (var el in parameters) {
                    MySqlParameter param = new MySqlParameter($"@{el.Key}", el.Value);
                    command.Parameters.Add(param);
                }
            }
            await command.ExecuteNonQueryAsync();
        }
    }
}