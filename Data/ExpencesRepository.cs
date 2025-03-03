using Expance_Tracker.Models;

namespace Expance_Tracker.Data
{
    public class ExpencesRepository : RepositoryBase<ExpenceItem>
    {
        public ExpencesRepository(AppDbContext context) : base(context)
        {
        }
    }
}
