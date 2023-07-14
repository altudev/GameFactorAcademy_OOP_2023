using GFA.OOP.Common;

namespace GFA.OOP.Models
{
    public class NPC:BaseModel<Guid>
    {
        public string Name { get; set; }
        public double Hp { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public NPC()
        {
            Id = new Guid();

            Id = Guid.NewGuid();
        }

        public static explicit operator NPC(Player player)
        {
            return new NPC()
            {
                Id = player.Id,
                Name = player.Name,
                Hp = player.Hp,
                CreatedOn = player.CreatedOn,
                CreatedByUserId = player.CreatedByUserId,
                Description = player.Description,
                Address = player.Address,
            };
        }
    }
}
