using GFA.OOP.Enums;
using GFA.OOP.Models;


namespace GFA.OOP
{
    internal class FirstLectureCodes
    {
        public FirstLectureCodes()
        {
            // See https://aka.ms/new-console-template for more information


            var firstPlayer = new Player("Gandhalf 38", 38, Race.Human, PlayerClassType.Mage);

            Console.WriteLine($"ID:{firstPlayer.Id}, Character Name:{firstPlayer.Name}, Character Level:{firstPlayer.Level}, Character Favourite Number:{firstPlayer.FavouriteNumber}");

            firstPlayer.LevelUp();
            firstPlayer.LevelUp();
            firstPlayer.LevelUp();
            firstPlayer.LevelUp();
            firstPlayer.LevelUp();

            Console.WriteLine($"ID:{firstPlayer.Id}, Character Name:{firstPlayer.Name}, Character Level:{firstPlayer.Level}, Character Favourite Number:{firstPlayer.FavouriteNumber}");

            firstPlayer.ChangeRace(Race.Dwarf);

            Console.WriteLine(firstPlayer.Race.ToString());

            var secondPlayer = new Player("Excalibur", 10, Race.Orc, PlayerClassType.DeathKnight);

            Console.WriteLine($"ID:{secondPlayer.Id}, Character Name:{secondPlayer.Name}, Character Level:{secondPlayer.Level}, Character Favourite Number:{secondPlayer.FavouriteNumber}");

            var thirdPlayer = new Player("Tarkan", 55, Race.Undead, PlayerClassType.Assassin);

            Console.WriteLine($"ID:{thirdPlayer.Id}, Character Name:{thirdPlayer.Name}, Character Level:{thirdPlayer.Level}, Character Favourite Number:{thirdPlayer.FavouriteNumber}");


            Console.ReadLine();
        }
    }
}
