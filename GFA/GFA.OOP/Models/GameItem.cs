using GFA.OOP.Common;

namespace GFA.OOP.Models
{
    public class GameItem:BaseModel<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public GameItem()
        {
            LastModifiedOn = DateTimeOffset.Now;
        }
    }
}
