using GFA.OOP.Common;

namespace GFA.OOP.ComplexTypes
{
    public class GameFactoryAcademyList<T,TKey> where T : IModel<TKey>
    {
        public List<T> Items { get; set; }

        public GameFactoryAcademyList()
        {
            Items = new List<T>();
        }
    }
}
