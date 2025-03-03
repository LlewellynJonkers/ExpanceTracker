
namespace Expance_Tracker.Data
{
    public class RepositoryBase<T> : IRepository<T>
    {
        private AppDbContext _context;
        public RepositoryBase(AppDbContext context) 
        {
            _context = context;
        }
        public void Add(T Item)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }
    }
}
