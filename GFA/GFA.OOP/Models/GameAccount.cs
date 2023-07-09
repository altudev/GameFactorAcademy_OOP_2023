using GFA.OOP.Common;
using GFA.OOP.Enums;
using IdGen;

namespace GFA.OOP.Models
{
    public class GameAccount : BaseModel<string>
    {
        private static IdGenerator _generator = new IdGenerator(0);
        public string UserName { get; set; }
        public string Password { get; set; }
        public Platform Platform { get; set; }
        public int Level { get; set; }
        public string GameName { get; set; }
        public decimal Price { get; set; }


        public GameAccount()
        {
            Id = _generator.CreateId().ToString();

            CreatedOn = DateTime.Now;
        }


        public static int ConvertStringToLevel(string levelText)
        {
            int level = 0;

            if (!int.TryParse(levelText,out level))
                return 0;

            return level;

        }

        public static Platform ConvertStringToPlatform(string platform)
        {

            if (string.IsNullOrWhiteSpace(platform))
                return Platform.Unknown;

            switch (platform.ToLower())
            {
                case "steam":
                    return Platform.Steam;

                case "origin":
                    return Platform.Origin;

                case "battle.net":
                    return Platform.BattleNet;

                case "uplay":
                    return Platform.UPlay;

                case "epic games":
                    return Platform.EpicGames;

                default:
                    return Platform.Unknown;
            }
        }
    }
}
