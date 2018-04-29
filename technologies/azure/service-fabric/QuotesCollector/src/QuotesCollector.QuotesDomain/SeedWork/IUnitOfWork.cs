using System.Threading;
using System.Threading.Tasks;

namespace QuotesCollector.QuotesDomain.SeedWork
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
