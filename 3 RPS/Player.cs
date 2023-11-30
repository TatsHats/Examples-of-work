
using System;
using System.Security.Principal;
namespace RockPaper;
public enum Variants {Rock, Paper, Scissors}  // Перечисление вариантов

public class Player {

    public string name = "Bot";         
    private Variants choice;           
    
    public Player (Variants _choice, string _name) { // Эти два параметра должны устанавливаться в 2 поля выше
        name = _name;
        choice = _choice;
    }
    
       public Player() {                   //Установливаем случайное значение из перечисления
        Random random = new Random();
        int randomIndex = random.Next(0, 3);
        choice = (Variants)randomIndex;
        System.Console.WriteLine("Для первого игрока было установлено значение: " + choice.ToString());
    }

    public string whoWins (Player firstPlayer, Player secondPlayer) {   
        
        string winner = "";

        if (firstPlayer.choice == Variants.Paper) {
            if (secondPlayer.choice == Variants.Rock){
                winner = firstPlayer.name;
            }
            else if (secondPlayer.choice == Variants.Paper){
                winner = "---(draw)";
            }
            else if (secondPlayer.choice == Variants.Scissors){
                winner = secondPlayer.name;
            }
        }
        if (firstPlayer.choice == Variants.Rock) {
            if (secondPlayer.choice == Variants.Rock){
                winner = "---(draw)";
            }
            else if (secondPlayer.choice == Variants.Paper){
                winner = secondPlayer.name;
            }
            else if (secondPlayer.choice == Variants.Scissors){
                winner = firstPlayer.name;
            }
        }
        if (firstPlayer.choice == Variants.Scissors) {
            if (secondPlayer.choice == Variants.Rock){
                winner = secondPlayer.name;
            }
            else if (secondPlayer.choice == Variants.Paper){
                winner = firstPlayer.name;
            }
            else if (secondPlayer.choice == Variants.Scissors){
                winner = "---(draw)";
            }
        }
        return winner;
    }       
} 