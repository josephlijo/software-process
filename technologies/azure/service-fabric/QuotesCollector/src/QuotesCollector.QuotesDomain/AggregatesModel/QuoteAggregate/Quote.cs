using QuotesCollector.QuotesDomain.SeedWork;
using System;

namespace QuotesCollector.QuotesDomain.AggregatesModel.QuoteAggregate
{
    public class Quote
        : Entity, IAggregateRoot
    {
        public Guid Identity { get; private set; }

        public string Name { get; private set; }

        public string SourceIdentity { get; private set; }

        public Quote(Guid identityString, string name, string sourceIdentity = null)
        {
            Identity = identityString;
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
            SourceIdentity = !string.IsNullOrWhiteSpace(sourceIdentity) ? sourceIdentity : throw new ArgumentNullException(nameof(sourceIdentity));
        }
    }
}
