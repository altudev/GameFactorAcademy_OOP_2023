using GFA.OOP.Common;

namespace GFA.OOP.Models
{
    public class EnemyPlayer:IModel<Guid>,ICreatedByModel
    {
        public string Name { get; set; }
        public double Hp { get; set; }
        public Guid Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string? CreatedByUserId { get; set; }
    }
}
