namespace Expance_Tracker.Data
{
    public interface IRepository<T>
    {
        void Add(T Item);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T item);
        void DeleteById(int id);
        void DeleteAll();
        void Delete(T item);

    }
}
