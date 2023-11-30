using System;
namespace RockPaper {
    class MainClass {
        public static void Main(string[] args) {
            Player bot = new Player();
            Player alex = new Player(Variants.Scissors, "Alex");
            Console.WriteLine("Победил игрок с именем: " + bot.whoWins(bot, alex));
        }
    }
}
                        