

using GFA.OOP.Enums;

namespace GFA.OOP.Models
{
    public class Player
    {
        private int _level;

        public Guid Id { get; }
        public string Name { get; set; }
        public int Level => _level;
        public Race Race { get; private set; }
        public PlayerClassType ClassType { get; set; }
        public int  FavouriteNumber { get; set; }

        public Player()
        {
            Id = Guid.NewGuid();

            SetUpFavouriteNumber();
        }

        public Player(string name, int level, Race race, PlayerClassType classType)
        {
            Id = Guid.NewGuid();

            Name = name;

            _level = level;

            Race = race;

            ClassType = classType;

            SetUpFavouriteNumber();
        }

        public void LevelUp()
        {
            _level += 1;

            Console.WriteLine($"{Name} named character was leveled up to {_level}");
        }

        public void ChangeRace(Race race)
        {
            Race = race;
        }

        public void SetUpFavouriteNumber()
        {
            var random = new Random();

            FavouriteNumber = random.Next(9999);
        }

    }
}
