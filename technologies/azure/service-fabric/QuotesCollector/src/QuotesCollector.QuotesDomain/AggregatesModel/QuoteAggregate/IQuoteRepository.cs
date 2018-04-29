using QuotesCollector.QuotesDomain.SeedWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuotesCollector.QuotesDomain.AggregatesModel.QuoteAggregate
{
    public interface IQuoteRepository : IRepository<Quote>
    {
        Task<IEnumerable<Quote>> GetQuotesAsync();

        Task AddQuoteAsync(Quote quote);
    }
}
