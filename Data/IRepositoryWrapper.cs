using Expance_Tracker.Models;

namespace Expance_Tracker.Data
{
    public interface IRepositoryWrapper
    {
        IRepository<ExpenceItem> ExpenceItem { get; }
        IRepository<ExpenceCategory> ExpenceCategory { get; }
    }
}
