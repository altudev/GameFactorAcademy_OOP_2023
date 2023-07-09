namespace GFA.OOP.Common
{
    public abstract class BaseModel<TKey>:IModel<TKey>,ICreatedByModel,IModifiedByModel
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string? CreatedByUserId { get; set; }
        public DateTimeOffset? LastModifiedOn { get; set; }
        public string? ModifiedByUserId { get; set; }
    }
}
