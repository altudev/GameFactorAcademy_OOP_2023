

using GFA.OOP.Common;
using GFA.OOP.Enums;

namespace GFA.OOP.Models
{
    public class Player:BaseModel<Guid>
    {
        private int _level;

        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int Level => _level;
        public Race Race { get; private set; }
        public PlayerClassType ClassType { get; set; }
        public int  FavouriteNumber { get; set; }
        public double Hp { get; set; }

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

        public static implicit operator Player(NPC npc)
        {
            return new Player()
            {
                Id = npc.Id,
                Name = npc.Name,
                Hp = npc.Hp,
                CreatedOn = npc.CreatedOn,
                CreatedByUserId = npc.CreatedByUserId,
            };
        }

    }
}
