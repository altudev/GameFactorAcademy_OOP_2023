namespace GFA.OOP.Common
{
    public interface IModifiedByModel
    {
        DateTimeOffset? LastModifiedOn { get; set; }
        string? ModifiedByUserId { get; set; }
    }
}
