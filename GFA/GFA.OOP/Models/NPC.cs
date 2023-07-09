using GFA.OOP.Common;

namespace GFA.OOP.Models
{
    public class NPC:BaseModel<Guid>
    {
        public string Name { get; set; }
        public double Hp { get; set; }

        public NPC()
        {
            Id = new Guid();

            Id = Guid.NewGuid();
        }
    }
}
