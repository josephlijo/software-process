using Microsoft.ServiceFabric.Data;
using Microsoft.ServiceFabric.Data.Collections;
using QuotesCollector.QuotesDomain.AggregatesModel.QuoteAggregate;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QuotesCollector.QuotesCatalog.Repositories
{
    internal sealed class QuoteRepository : IQuoteRepository
    {
        private const string DICTIONARY_NAME = "Quotes";

        private readonly IReliableStateManager _reliableStateManager;

        public QuoteRepository(IReliableStateManager stateManager)
        {
            _reliableStateManager = stateManager;
        }

        public async Task AddQuoteAsync(Quote quote)
        {
            // Get a reference to reliable dictionary
            var quotesDictionary = await _reliableStateManager.GetOrAddAsync<IReliableDictionary<Guid, Quote>>(DICTIONARY_NAME);

            // Create a transaction and insert or update quote
            using (var tx = _reliableStateManager.CreateTransaction())
            {
                await quotesDictionary.AddOrUpdateAsync(tx, quote.Identity, quote, (id, value) => quote);
                await tx.CommitAsync();
            }
        }

        public async Task<IEnumerable<Quote>> GetQuotesAsync()
        {
            // Get a reference to reliable dictionary
            var quotesDictionary = await _reliableStateManager.GetOrAddAsync<IReliableDictionary<Guid, Quote>>(DICTIONARY_NAME);
            var quotes = new List<Quote>();

            using (var tx = _reliableStateManager.CreateTransaction())
            {
                var enumerableOfQuotes = await quotesDictionary.CreateEnumerableAsync(tx, EnumerationMode.Unordered);
                using (var enumeratorOfQuotes = enumerableOfQuotes.GetAsyncEnumerator())
                {
                    while (await enumeratorOfQuotes.MoveNextAsync(CancellationToken.None))
                    {
                        var current = enumeratorOfQuotes.Current;
                        quotes.Add(current.Value);
                    }
                }
            }

            return quotes;
        }
    }
}
