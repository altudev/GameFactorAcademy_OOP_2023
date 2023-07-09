namespace GFA.OOP.Common
{
    public interface IModel<TKey>
    {
        TKey Id { get; set; }
    }
}
