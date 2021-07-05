﻿using Oddin.OddinSdk.SDK.AMQP.Abstractions;
using Oddin.OddinSdk.SDK.AMQP.Enums;
using Oddin.OddinSdk.SDK.API.Abstractions;
using System.Collections.Generic;

namespace Oddin.OddinSdk.SDK.AMQP.Mapping
{
    internal class MarketWithOdds : Market, IMarketWithOdds
    {
        public MarketStatus Status { get; }

        public bool IsFavorite { get; }

        public IEnumerable<IOutcomeOdds> OutcomeOdds { get; }

        public IMarketMetadata MarketMetadata { get; }

        public MarketWithOdds(
            int marketId,
            IDictionary<string, string> specifiers,
            IApiClient apiClient,
            MarketStatus marketStatus,
            bool isFavorite,
            IEnumerable<IOutcomeOdds> outcomeOdds,
            IMarketMetadata marketMetadata)
            : base(marketId, specifiers, apiClient)
        {
            Status = marketStatus;
            IsFavorite = isFavorite;
            OutcomeOdds = outcomeOdds;
            MarketMetadata = marketMetadata;
        }
    }
}
