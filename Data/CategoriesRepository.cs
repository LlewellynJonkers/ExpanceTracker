using Expance_Tracker.Models;

namespace Expance_Tracker.Data
{
    public class CategoriesRepository:RepositoryBase<ExpenceCategory>
    {
        public CategoriesRepository(AppDbContext context) :base(context) { }
    }
}
