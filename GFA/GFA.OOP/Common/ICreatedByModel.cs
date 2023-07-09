namespace GFA.OOP.Common
{
    public interface ICreatedByModel
    {
        DateTimeOffset CreatedOn { get; set; }
        public string? CreatedByUserId { get; set; }
    }
}
