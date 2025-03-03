using Expance_Tracker.Models;

namespace Expance_Tracker.Data
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private AppDbContext _context;
        private IRepository<ExpenceItem> expences;
        private IRepository<ExpenceCategory> category;
        public RepositoryWrapper(AppDbContext context) 
        {
            _context = context;
        }
        public IRepository<ExpenceItem> ExpenceItem
        {
            get
            {
                if (expences == null)
                {
                    expences = new ExpencesRepository(_context);
                }
                return expences;
            }
        }

        public IRepository<ExpenceCategory> ExpenceCategory
        {
            get
            {
                if (category == null)
                {
                    category = new CategoriesRepository(_context);
                }
                return category;
            }
        }
    }
}
